﻿/*
Hotbar Randomizer - Tool for building structures in Minecraft with random material distribution
Copyright (C) 2020  voltavidTony

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <https://www.gnu.org/licenses/>
*/

using static Hotbar_Randomizer.Program;
using InputTracking;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;

namespace Hotbar_Randomizer {
    public partial class HotbarRandomizerWindow : Form {

        #region Attributes

        private readonly Panel[] recipePanels;

        private readonly Dictionary<string, Action<object, EventArgs>> commands;
        private readonly InputTracker<KBDLLHOOKSTRUCT> keyboard;
        private readonly InputTracker<MSLLHOOKSTRUCT> mouse;
        private readonly Random rng = new Random();
        private readonly SoundPlayer actuator_off = new SoundPlayer(Properties.Resources.actuator_off);
        private readonly SoundPlayer actuator_on = new SoundPlayer(Properties.Resources.actuator_on);
        private readonly TextBox textBoxCmd;
        private readonly WinEventDelegate window;

        private readonly IntPtr windowPtr;

        private readonly int[] recipeValues = { 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        private readonly string[] recipeLabels = { "1", "1", "1", "1", "1", "1", "1", "1", "1" };

        private AboutBox1 aboutBox;

        private IntPtr MCWindow = IntPtr.Zero;

        private bool doCount = false;
        private bool doSlot = false;
        private bool doSwap = false;
        private int selectedRecipe = -1;
        private int selectedSlot = 0;

        #endregion

        #region Constructors

        public HotbarRandomizerWindow() {
            InitializeComponent();

            commands = new Dictionary<string, Action<object, EventArgs>>() {
                { "/hot count", LeverCount_Click },
                { "/hot slot", LeverSlots_Click },
                { "/hot swap", LeverSwap_Click },
                { "/hot quit", ButtonClose_Click }
            };

            recipePanels = new Panel[] { panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8, panel9 };

            textBoxCmd = new TextBox() {
                AutoCompleteMode = AutoCompleteMode.Append,
                AutoCompleteSource = AutoCompleteSource.CustomSource,
                TabStop = false
            };
            textBoxCmd.TextChanged += TextBoxCmd_TextChanged;

            Font = new Font(Fonts.Families[0], 12);
            labelCount.Font = labelSlots.Font = labelSwap.Font = panelCmd.Font = new Font(Font.FontFamily, 9);

            (keyboard = new InputTracker<KBDLLHOOKSTRUCT>()).WMEvent += Keyboard_WMEvent;
            (mouse = new InputTracker<MSLLHOOKSTRUCT>()).WMEvent += Mouse_WMEvent;
            window = new WinEventDelegate(ForegroundChanged);
            windowPtr = SetWinEventHook(3, 3, IntPtr.Zero, window, 0, 0, 0);
        }

        #endregion

        #region Private Methods

        private bool SelectSlot() {
            int recipeCount = 0;
            foreach (int r in recipeValues) recipeCount += r;
            if (recipeCount == 0) return false;
            selectedSlot = 0;
            for (int i = rng.Next(recipeCount) + 1; i > recipeValues[selectedSlot]; i -= recipeValues[selectedSlot++]) ;
            hotbarLayout.Invalidate();
            return true;
        }

        #endregion

        #region Events

        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x0200_0000;
                return cp;
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e) =>
            new System.Threading.Tasks.Task((hWnd) => {
                layoutClose.BackgroundImage = Properties.Resources.button_on;
                actuator_off.PlaySync();
                PostMessage((IntPtr)hWnd, (uint)WM.CLOSE, 0, 0);
            }, Handle).Start();

        private void ButtonClose_Paint(object sender, PaintEventArgs e) =>
            e.Graphics.DrawString("X", Font, Brushes.Red, ((Control)sender).ClientRectangle, new StringFormat {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
            });

        private void ButtonQuestion_Click(object sender, EventArgs e) {
            new System.Threading.Tasks.Task(() => {
                actuator_on.Play();
                layoutQuestion.BackgroundImage = Properties.Resources.button_on;
                System.Threading.Thread.Sleep(1000);
                actuator_off.Play();
                layoutQuestion.BackgroundImage = Properties.Resources.button_off;
            }).Start();
            aboutBox = new AboutBox1();
            aboutBox.Show();
        }

        private void ButtonQuestion_Paint(object sender, PaintEventArgs e) =>
            e.Graphics.DrawString("?", Font, Brushes.PaleTurquoise, ((Control)sender).ClientRectangle, new StringFormat {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
            });

        private void ForegroundChanged(IntPtr hWinEventHook, uint eventType, IntPtr hWnd,
            int idObject, int idChild, uint idEventThread, uint dwmsEventTime) {
            panelCmd.Visible = false;
            MCWindow = IntPtr.Zero;
            try {
                GetWindowThreadProcessId(hWnd, out int pid);
                var proc = Process.GetProcessById(pid);
                if (proc.MainModule.ModuleName.Equals("javaw.exe") && proc.MainWindowTitle.Contains("Minecraft"))
                    MCWindow = hWnd;
            } catch { }
        }

        private void HotbarCell_MouseClick(object sender, MouseEventArgs e) {
            if (doSlot) return;
            selectedRecipe = hotbarLayout.GetColumn((Control)sender);
            ((Control)sender).Invalidate();
        }

        private void HotbarCell_MouseEnter(object sender, EventArgs e) => ((Control)sender).BackColor = doSlot
                ? Color.Transparent
                : Color.FromArgb(0x40, Color.White);

        private void HotbarCell_MouseLeave(object sender, EventArgs e) => ((Control)sender).BackColor = Color.Transparent;

        private void HotbarCell_Paint(object sender, PaintEventArgs e) {
            int i = hotbarLayout.GetColumn((Control)sender);
            e.Graphics.DrawString(recipeLabels[i],
                new Font(Font.FontFamily, 12, i == selectedRecipe ? FontStyle.Bold : FontStyle.Regular), Brushes.White,
                ((Control)sender).ClientRectangle,
                new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
        }

        private void HotbarLayout_Paint(object sender, PaintEventArgs e) {
            if (doCount) e.Graphics.DrawImage(Properties.Resources.hotbar_selection, 60 * selectedSlot, 0, 72, 72);
        }

        private void HotbarRandomizerWindow_FormClosing(object sender, FormClosingEventArgs e) {
            keyboard.Dispose();
            mouse.Dispose();
            GC.KeepAlive(window);
            UnhookWinEvent(windowPtr);
        }

        private void HotbarRandomizerWindow_KeyUp(object sender, KeyEventArgs e) {
            if (selectedRecipe < 0) return;

            string recipeLabel = recipeLabels[selectedRecipe];

            // Modify Recipe
            switch (e.KeyCode) {
            case Keys.Back: // Remove LSD
                recipeLabels[selectedRecipe] = recipeLabel.Length > 1 ? recipeLabel.Substring(0, recipeLabel.Length - 1) : "0";
                recipePanels[selectedRecipe].Invalidate();
                break;
            case Keys.Delete: // Reset to 0
                recipeLabels[selectedRecipe] = "0";
                recipePanels[selectedRecipe].Invalidate();
                break;
            case Keys.Enter: // Apply
                recipeValues[selectedRecipe] = int.Parse(recipeLabel);
                recipePanels[selectedRecipe].Invalidate();
                selectedRecipe = -1;
                break;
            case Keys.Escape: // Revert
                recipeLabels[selectedRecipe] = recipeValues[selectedRecipe].ToString();
                recipePanels[selectedRecipe].Invalidate();
                selectedRecipe = -1;
                break;
            default: // Type
                if (recipeLabel.Length == 3) break;
                Keys key = e.KeyCode;
                if (Keys.NumPad0 <= key && key <= Keys.NumPad9)
                    key -= Keys.NumPad0 - Keys.D0;
                if (Keys.D0 <= key && key <= Keys.D9) {
                    recipeLabels[selectedRecipe] = recipeLabel == "0" ? $"{(char)key}" : $"{recipeLabel}{(char)key}";
                    recipePanels[selectedRecipe].Invalidate();
                }
                break;
            }
        }

        private void Keyboard_WMEvent(object sender, WMEventArgs<KBDLLHOOKSTRUCT> e) {
            if (MCWindow == IntPtr.Zero) return;

            // Start command
            if (!panelCmd.Visible) {
                if ((byte)e.Info.vkCode != HotKeys[0]) return;
                textBoxCmd.Clear();
                panelCmd.Visible = true;
            }

            // Handle command
            if (panelCmd.Visible) switch (e.Info.vkCode) {
                case Keys.Enter: // Process command
                    try {
                        commands[textBoxCmd.Text](this, EventArgs.Empty);
                    } catch (KeyNotFoundException) { }
                    panelCmd.Visible = false;
                    break;
                case Keys.Escape: // Cancel command
                    panelCmd.Visible = false;
                    break;
                default: // Leverage TextBox to get command input
                    PostMessage(textBoxCmd.Handle, (uint)e.WindowMessage, (int)e.Info.vkCode,
                        (uint)(e.WindowMessage == WM.KEYUP || e.WindowMessage == WM.SYSKEYUP ? 0x4000_0000 : 0x0000_0000) |
                        (uint)e.Info.flags << 24 & 0xA100_0000 | (uint)e.Info.scanCode << 16 & 0x00FF_0000 | 0x0000_0001);
                    break;
                }
        }

        private void LeverCount_Click(object sender, EventArgs e) {
            if (!doCount) {
                doCount = true;
                actuator_on.Play();
                leverCount.BackgroundImage = Properties.Resources.lever_on;
            } else {
                doCount = false;
                actuator_off.Play();
                leverCount.BackgroundImage = Properties.Resources.lever_off;
            }
            hotbarLayout.Invalidate();
        }

        private void LeverSlots_Click(object sender, EventArgs e) {
            if (!doSlot) {
                if (!SelectSlot()) return;
                doSlot = true;
                actuator_on.Play();
                leverSlots.BackgroundImage = Properties.Resources.lever_on;
            } else {
                doSlot = false;
                actuator_off.Play();
                leverSlots.BackgroundImage = Properties.Resources.lever_off;
            }
        }

        private void LeverSwap_Click(object sender, EventArgs e) {
            if (!doSwap) {
                doSwap = true;
                actuator_on.Play();
                leverSwap.BackgroundImage = Properties.Resources.lever_on;
            } else {
                doSwap = false;
                actuator_off.Play();
                leverSwap.BackgroundImage = Properties.Resources.lever_off;
            }
        }

        private void Mouse_WMEvent(object sender, WMEventArgs<MSLLHOOKSTRUCT> e) {
            switch (e.WindowMessage) {
            case WM.LBUTTONDOWN: // Apply Recipe
                if (selectedRecipe >= 0) {
                    recipeValues[selectedRecipe] = int.Parse(recipeLabels[selectedRecipe]);
                    recipePanels[selectedRecipe].Invalidate();
                    selectedRecipe = -1;
                }
                goto case WM.LBUTTONUP;
            case WM.LBUTTONUP: // Swap Offhand
                if (MCWindow != IntPtr.Zero && doSwap) {
                    PostMessage(MCWindow, (uint)WM.KEYDOWN, HotKeys[10], 0x0000_0001);
                    PostMessage(MCWindow, (uint)WM.KEYUP, HotKeys[10], 0xC000_0001);
                }
                break;
            case WM.RBUTTONDOWN: // Revert Recipe
                if (selectedRecipe >= 0) {
                    recipeLabels[selectedRecipe] = recipeValues[selectedRecipe].ToString();
                    recipePanels[selectedRecipe].Invalidate();
                    selectedRecipe = -1;
                }
                break;
            case WM.RBUTTONUP: // Switch Slot
                if (MCWindow == IntPtr.Zero || !doSlot) break;
                if (doCount) { // Portion decrement
                    recipeLabels[selectedSlot] = (--recipeValues[selectedSlot]).ToString();
                    recipePanels[selectedSlot].Invalidate();
                }
                if (!SelectSlot()) { // Out of portions
                    LeverCount_Click(null, null);
                    LeverSlots_Click(null, null);
                    break;
                }
                PostMessage(MCWindow, (uint)WM.KEYDOWN, HotKeys[selectedSlot + 1], 0x0000_0001);
                PostMessage(MCWindow, (uint)WM.KEYUP, HotKeys[selectedSlot + 1], 0xC000_0001);
                break;
            }
        }

        private void PanelCmd_Paint(object sender, PaintEventArgs e) {
            if (!panelCmd.Visible) return;
            e.Graphics.FillRectangle(new SolidBrush(NamePlate), panelCmd.ClientRectangle);
            e.Graphics.DrawString(textBoxCmd.Text, panelCmd.Font, Brushes.White, panelCmd.ClientRectangle,
                new StringFormat() {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Near,
                    Trimming = StringTrimming.EllipsisCharacter
                });
        }

        private void TextBoxCmd_TextChanged(object sender, EventArgs e) => panelCmd.Invalidate(false);

        private void TitleBar_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            PostMessage(Handle, (uint)WM.NCLBUTTONDOWN, 0x2, 0);
        }

        private void TitleBar_Paint(object sender, PaintEventArgs e) {
            RectangleF titlePlate = new RectangleF(5, 5, e.Graphics.MeasureString("Welcome to Minecraft Hotbar Randomizer!", Font, 600).Width, 26);
            e.Graphics.FillRectangle(new SolidBrush(NamePlate), titlePlate);
            e.Graphics.DrawString("Welcome to Minecraft Hotbar Randomizer!", Font, Brushes.White, titlePlate,
                new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
        }

        #endregion
    }
}
