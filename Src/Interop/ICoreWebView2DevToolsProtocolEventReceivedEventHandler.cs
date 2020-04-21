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
    [Guid("8B0DF849-2D94-47FB-8072-FE7A4D5FBA6A")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2DevToolsProtocolEventReceivedEventHandler
	{
		
		void Invoke([In] ICoreWebView2 webview, [In] ICoreWebView2DevToolsProtocolEventReceivedEventArgs args);
	}
}