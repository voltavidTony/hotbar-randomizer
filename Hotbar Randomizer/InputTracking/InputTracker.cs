using System;
using System.Runtime.InteropServices;

namespace InputTracking {
    public class InputTracker<HS> : IDisposable {
        public event EventHandler<WMEventArgs<HS>> WMEvent;

        private readonly WindowsHookHelper.HookDelegate WMDelegate;
        private readonly IntPtr WMHandle;

        private bool disposed;

        public InputTracker() {
            if (typeof(HS) == typeof(KBDLLHOOKSTRUCT))
                WMHandle = WindowsHookHelper.SetWindowsHookEx(13, WMDelegate = WMHookDelegate, IntPtr.Zero, 0);
            else if (typeof(HS) == typeof(MSLLHOOKSTRUCT))
                WMHandle = WindowsHookHelper.SetWindowsHookEx(14, WMDelegate = WMHookDelegate, IntPtr.Zero, 0);
            else throw new NotImplementedException($"No procedure defined for hook associated with {typeof(HS)}");
        }

        private IntPtr WMHookDelegate(int code, IntPtr wParam, IntPtr lParam) {
            if (code >= 0) WMEvent?.Invoke(this, new WMEventArgs<HS>((WM)wParam, (HS)Marshal.PtrToStructure(lParam, typeof(HS))));
            return WindowsHookHelper.CallNextHookEx(WMHandle, code, wParam, lParam);
        }

        public void Dispose() {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing) {
            if (!disposed) {
                GC.KeepAlive(WMDelegate);
                if (WMHandle != IntPtr.Zero) WindowsHookHelper.UnhookWindowsHookEx(WMHandle);
                disposed = true;
            }
        }

        ~InputTracker() {
            Dispose(false);
        }
    }
}
