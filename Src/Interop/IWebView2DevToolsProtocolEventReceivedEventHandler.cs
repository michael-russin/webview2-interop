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
    [Guid("37D087EA-12F6-4856-81D8-5596C708CA59")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2DevToolsProtocolEventReceivedEventHandler
	{
		
		void Invoke([In] IWebView2WebView webview, [In] IWebView2DevToolsProtocolEventReceivedEventArgs args);
	}
}