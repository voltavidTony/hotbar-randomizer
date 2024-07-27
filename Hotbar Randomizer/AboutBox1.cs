/*
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
using System;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Windows.Forms;
using InputTracking;

namespace Hotbar_Randomizer {
    partial class AboutBox1 : Form {
        #region Attributes

        private readonly Random rng = new Random();

        private readonly SoundPlayer[] pageSounds = {
            new SoundPlayer(Properties.Resources.open_flip1),
            new SoundPlayer(Properties.Resources.open_flip2),
            new SoundPlayer(Properties.Resources.open_flip3)
        };

        private readonly string[] aboutPages;

        private int page = 0;

        #endregion

        #region Constructors

        public AboutBox1() {
            InitializeComponent();
            aboutPages = Properties.Resources.ResourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentUICulture, true, true)
                .Cast<System.Collections.DictionaryEntry>()
                .Where(entry => entry.Key is string key && key.StartsWith("about_"))
                .Select(entry => entry.Value as string).ToArray();
            pageCount.Font = new Font(Fonts.Families[0], 18);
            pageCount.Text = $"1/{aboutPages.Length}";
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

        private void AboutBox1_Deactivate(object sender, EventArgs e) => PostMessage(Handle, (uint)WM.CLOSE, 0, 0);

        private void AboutBox1_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) Close();
        }

        private void AboutBox1_Shown(object sender, EventArgs e) => aboutRTF.Rtf = aboutPages[page];

        private void AboutRTF_LinkClicked(object sender, LinkClickedEventArgs e) => System.Diagnostics.Process.Start(e.LinkText);

        private void BookLayout_Click(object sender, EventArgs e) {
            Point mouse = aboutRTF.PointToClient(MousePosition);
            PostMessage(aboutRTF.Handle, (uint)WM.LBUTTONDOWN, 1, (mouse.Y << 16) | (mouse.X & 0xFFFF));
            PostMessage(aboutRTF.Handle, (uint)WM.LBUTTONUP, 0, (mouse.Y << 16) | (mouse.X & 0xFFFF));
            PostMessage(aboutRTF.Handle, (uint)WM.KILLFOCUS, 0, 0);
        }

        private void BookLayout_MouseMove(object sender, MouseEventArgs e) {
            if ((e.Button & MouseButtons.Left) == 0) return;
            ReleaseCapture();
            PostMessage(Handle, (uint)WM.NCLBUTTONDOWN, 0x2, 0);
        }

        private void Button_MouseEnter(object sender, EventArgs e) {
            if (sender is Control control && control.Enabled) {
                Rectangle rect = (Rectangle)control.Tag;
                rect.X = 72;
                control.Tag = rect;
                control.Invalidate();
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e) {
            if (sender is Control control) {
                Rectangle rect = (Rectangle)control.Tag;
                rect.X = 0;
                control.Tag = rect;
                control.Invalidate();
            }
        }

        private void Button_Paint(object sender, PaintEventArgs e) =>
            e.Graphics.DrawImage(Properties.Resources.arrows,
                new Rectangle(0, 0, 72, 40), (Rectangle)((Control)sender).Tag, GraphicsUnit.Pixel);

        private void ButtonBack_Click(object sender, EventArgs e) {
            if (page <= 0) return;
            aboutRTF.Rtf = aboutPages[--page];
            pageCount.Text = $"{page + 1}/{aboutPages.Length}";
            forwardButton.Enabled = true;
            if (page == 0) backButton.Enabled = false;
            pageSounds[rng.Next(pageSounds.Length)].Play();
        }

        private void ButtonForward_Click(object sender, EventArgs e) {
            if (page >= aboutPages.Length - 1) return;
            aboutRTF.Rtf = aboutPages[++page];
            pageCount.Text = $"{page + 1}/{aboutPages.Length}";
            backButton.Enabled = true;
            if (page == aboutPages.Length - 1) forwardButton.Enabled = false;
            pageSounds[rng.Next(pageSounds.Length)].Play();
        }

        #endregion
    }
}
