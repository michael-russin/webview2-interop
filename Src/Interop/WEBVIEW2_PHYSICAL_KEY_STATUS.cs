using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop
{
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
