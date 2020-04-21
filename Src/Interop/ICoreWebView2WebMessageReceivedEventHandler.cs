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
    [Guid("ABABDC66-DF8D-487D-A737-7B25E8F835AA")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2WebMessageReceivedEventHandler
	{

        //		void Invoke([In] IWebView2WebView webview, [In] IWebView2WebMessageReceivedEventArgs args);
        void Invoke([In] ICoreWebView2 webview, [In] ICoreWebView2WebMessageReceivedEventArgs args);
    }
}