using System;

namespace Russinsoft.WebView2.Interop
{
    /// <summary>
    /// Response to a permission request.
    /// </summary>
	public enum WEBVIEW2_PERMISSION_STATE
	{
        /// <summary>
        /// Use default browser behavior, which normally prompt users for decision.
        /// </summary>
		WEBVIEW2_PERMISSION_STATE_DEFAULT,
        /// <summary>
        /// Grant the permission request.
        /// </summary>
		WEBVIEW2_PERMISSION_STATE_ALLOW,
        /// <summary>
        /// Deny the permission request.
        /// </summary>
		WEBVIEW2_PERMISSION_STATE_DENY
    }
}