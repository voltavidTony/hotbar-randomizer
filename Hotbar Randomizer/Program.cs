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

using Hotbar_Randomizer.Properties;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Hotbar_Randomizer {
    static class Program {
        #region DLLImports

        [DllImport("gdi32.dll")]
        static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, out uint pcFonts);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int processId);

        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, long lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, IntPtr hmodWinEventProc, WinEventDelegate lpfnWinEventProc, uint idProcess, uint idThread, uint dwFlags);
        [DllImport("user32.dll")]
        public static extern bool UnhookWinEvent(IntPtr hWinEventHook);
        public delegate void WinEventDelegate(IntPtr hWindowEventHook, uint eventType, IntPtr hWnd, int idObject, int idChild, uint idEventThread, uint dwmsEventTime);

        [DllImport("user32.dll")]
        static extern short VkKeyScan(char ch);
        #endregion

        #region Global Variables

        public static readonly System.Drawing.Color NamePlate = System.Drawing.Color.FromArgb(0xA0, System.Drawing.Color.Black);
        public static readonly System.Drawing.Text.PrivateFontCollection Fonts = new System.Drawing.Text.PrivateFontCollection();

        public static byte CmdKey = (byte)VkKeyScan('/');
        public static byte[] HotbarKeys = { (byte)VkKeyScan('1'), (byte)VkKeyScan('2'), (byte)VkKeyScan('3'), (byte)VkKeyScan('4'),
            (byte)VkKeyScan('5'), (byte)VkKeyScan('6'), (byte)VkKeyScan('7'), (byte)VkKeyScan('8'), (byte)VkKeyScan('9') };
        public static byte OffhandKey = (byte)VkKeyScan('F');

        #endregion

        // Parse literal or hex escapement
        static bool ParseChar(string format, ref byte ch) {
            switch (format.Length) {
            case 4 when format[1] == 'x' || format[1] == 'X':
            case 2:
                try {
                    ch = (byte)VkKeyScan((char)Convert.ToInt32(format, 16));
                    return true;
                } catch (FormatException) { return false; }
            case 1:
                ch = (byte)VkKeyScan(format[0]);
                return true;
            }
            return false;
        }

        [STAThread]
        static void Main() {
            // Only one instance
            new System.Threading.Mutex(true, "40aaa81a-5692-41b3-bd39-3854e2e4c58b", out bool created);
            if (!created) return;

            // Custom keybinds
            string pName = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            int start = pName.IndexOf('{'), end = pName.LastIndexOf('}');
            if (start >= 0 && end >= 0) {
                // Check formatting
                string[] options = pName.Substring(start + 1, end - start - 1).Split(',');
                if (options.Length != 11) {
                    MessageBox.Show($"Incorrect number of key assignments! (Got {options.Length}/11)");
                    return;
                }
                // Save new keybinds
                for (int i = 0; i < options.Length; i++)
                    if (i == 0 && !ParseChar(options[0], ref CmdKey) ||
                        i == 10 && !ParseChar(options[10], ref OffhandKey) ||
                        !ParseChar(options[i], ref HotbarKeys[i - 1]))
                        MessageBox.Show($"Incorrect character format! (Got {options[i]})\n" +
                            $"Using default assignment. ({(i == 0 ? CmdKey : i == 10 ? OffhandKey : HotbarKeys[i - 1])})");
            }

            // Minecraftia font
            IntPtr fontPtr = Marshal.AllocCoTaskMem(Resources.MINECRAFTIA.Length);
            Marshal.Copy(Resources.MINECRAFTIA, 0, fontPtr, Resources.MINECRAFTIA.Length);
            Fonts.AddMemoryFont(fontPtr, Resources.MINECRAFTIA.Length);
            AddFontMemResourceEx(fontPtr, (uint)Resources.MINECRAFTIA.Length, IntPtr.Zero, out _);
            Marshal.FreeCoTaskMem(fontPtr);

            // Start form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HotbarRandomizerWindow());
        }
    }
}
