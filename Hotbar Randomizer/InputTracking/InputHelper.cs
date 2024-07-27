using System;
using System.Runtime.InteropServices;

namespace InputTracking {
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct KBDLLHOOKSTRUCT {
        public readonly System.Windows.Forms.Keys vkCode;
        public readonly int scanCode, flags, time;
        public readonly IntPtr dwExtraInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct MSLLHOOKSTRUCT {
        public readonly System.Drawing.Point point;
        public readonly int mouseData, flags, time;
        public readonly IntPtr dwExtraInfo;
    }

    public class WMEventArgs<HS> : EventArgs {
        public readonly WM WindowMessage;
        public readonly HS Info;

        public WMEventArgs(WM windowMessage, HS infoStruct) {
            WindowMessage = windowMessage;
            Info = infoStruct;
        }
    }

    public static class WindowsHookHelper {
        public delegate IntPtr HookDelegate(int Code, IntPtr wParam, IntPtr lParam);

        [DllImport("User32.dll")]
        public static extern IntPtr CallNextHookEx(IntPtr hHook, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("User32.dll")]
        public static extern IntPtr UnhookWindowsHookEx(IntPtr hHook);

        [DllImport("User32.dll")]
        public static extern IntPtr SetWindowsHookEx(int idHook, HookDelegate lpfn, IntPtr hmod, int dwThreadId);
    }
}
