using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// Fires when an HTTP request is made in the webview. The host can override
    /// request, response headers and response content.
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("E2AE08C1-4F67-4348-AE05-C89CB14C2ADD")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2WebResourceRequestedEventHandler
	{
        /// <summary>
        /// Called to provide the implementer with the event args for the
        /// corresponding event.
        /// </summary>
        /// <param name="webview"></param>
        /// <param name="args"></param>
        void Invoke([In] IWebView2WebView webview, 
                    [In] IWebView2WebResourceRequestedEventArgs args);
	}
}