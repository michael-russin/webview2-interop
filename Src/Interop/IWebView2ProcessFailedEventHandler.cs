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
    [Guid("011EC830-5DAF-4767-A099-C43DE1A925F4")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2ProcessFailedEventHandler
	{
		
		void Invoke([In, MarshalAs(UnmanagedType.Interface)] IWebView2WebView3 webview, [In, MarshalAs(UnmanagedType.Interface)] IWebView2ProcessFailedEventArgs args);
	}
}