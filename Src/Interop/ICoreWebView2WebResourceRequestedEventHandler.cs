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
    [Guid("A8DC0663-3C2C-4190-8129-5F1F598CA7B8")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2WebResourceRequestedEventHandler
	{
        /// <summary>
        /// Called to provide the implementer with the event args for the
        /// corresponding event.
        /// </summary>
        /// <param name="webview"></param>
        /// <param name="args"></param>
        void Invoke([In] ICoreWebView2 webview, 
                    [In] ICoreWebView2WebResourceRequestedEventArgs args);
	}
}