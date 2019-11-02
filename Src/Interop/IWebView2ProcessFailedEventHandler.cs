using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Russinsoft.WebView2.Interop
{
    /// <summary>
    /// Checked
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("011EC830-5DAF-4767-A099-C43DE1A925F4")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2ProcessFailedEventHandler
	{
		
		void Invoke([In] IWebView2WebView webview, [In] IWebView2ProcessFailedEventArgs args);
	}
}