using System;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// Reason for moving focus.
    /// </summary>
	public enum WEBVIEW2_MOVE_FOCUS_REASON
	{
        /// <summary>
        /// Code setting focus into WebView.
        /// </summary>
		WEBVIEW2_MOVE_FOCUS_REASON_PROGRAMMATIC,
        /// <summary>
        /// Moving focus due to Tab traversal forward.
        /// </summary>
		WEBVIEW2_MOVE_FOCUS_REASON_NEXT,
        /// <summary>
        /// Moving focus due to Tab traversal backward.
        /// </summary>
		WEBVIEW2_MOVE_FOCUS_REASON_PREVIOUS
    }
}