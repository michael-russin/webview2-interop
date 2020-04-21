using System;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// Kind of JavaScript dialog used in the IWebView2ScriptDialogOpeningEventHandler
    /// interface.
    /// </summary>
    public enum WEBVIEW2_SCRIPT_DIALOG_KIND
	{
        /// <summary>
        /// A dialog invoked via the window.alert JavaScript function.
        /// </summary>
		WEBVIEW2_SCRIPT_DIALOG_KIND_ALERT,
        /// <summary>
        /// A dialog invoked via the window.confirm JavaScript function.
        /// </summary>
		WEBVIEW2_SCRIPT_DIALOG_KIND_CONFIRM,
        /// <summary>
        /// A dialog invoked via the window.prompt JavaScript function.
        /// </summary>
		WEBVIEW2_SCRIPT_DIALOG_KIND_PROMPT,
        /// <summary>
        /// A dialog invoked via the beforeunload JavaScript event.
        WEBVIEW2_SCRIPT_DIALOG_KIND_BEFOREUNLOAD
        /// </summary>
    }
}