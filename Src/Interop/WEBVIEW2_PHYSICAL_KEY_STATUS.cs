using System;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WEBVIEW2_PHYSICAL_KEY_STATUS
    {
        public uint RepeatCount;

        public uint ScanCode;

        public int IsExtendedKey;

        public int IsMenuKeyDown;

        public int WasKeyDown;

        public int IsKeyReleased;
    }
}
