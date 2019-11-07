using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// Checked
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("0E682B9A-B686-4327-9A56-E0305705A3DB")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2WebMessageReceivedEventHandler
	{

        //		void Invoke([In] IWebView2WebView webview, [In] IWebView2WebMessageReceivedEventArgs args);
        void Invoke([In] IWebView2WebView webview, [In] IWebView2WebMessageReceivedEventArgs args);
    }
}