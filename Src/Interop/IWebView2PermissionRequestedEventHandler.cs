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
    [Guid("C5DA3C20-95AC-4345-B3C9-5FCA3B92C9DB")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2PermissionRequestedEventHandler
	{
		
		void Invoke([In, MarshalAs(UnmanagedType.Interface)] IWebView2WebView3 webview, [In, MarshalAs(UnmanagedType.Interface)] IWebView2PermissionRequestedEventArgs args);
	}
}