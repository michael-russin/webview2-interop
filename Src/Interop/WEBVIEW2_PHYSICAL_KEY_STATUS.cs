using System;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// A structure representing the information packed into the LPARAM given
    /// to a Win32 key event.  See the documentation for WM_KEYDOWN for details
    /// at https://docs.microsoft.com/windows/win32/inputdev/wm-keydown
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct WEBVIEW2_PHYSICAL_KEY_STATUS
    {
        /// <summary>
        /// The repeat count for the current message.
        /// /// </summary>
        public uint RepeatCount;

        /// <summary>
        /// The scan code.
        /// </summary>
        public uint ScanCode;

        /// <summary>
        /// Indicates whether the key is an extended key.
        /// </summary>
        public int IsExtendedKey;

        /// <summary>
        /// The context code.
        /// </summary>
        public int IsMenuKeyDown;

        /// <summary>
        /// The previous key state.
        /// </summary>
        public int WasKeyDown;

        /// <summary>
        /// The transition state.
        /// </summary>
        public int IsKeyReleased;
    }
}
