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
    [Guid("A5C0B08B-25D7-4BAC-AD06-11783393088E")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2ZoomFactorChangedEventHandler
	{
		
		void Invoke([In, MarshalAs(UnmanagedType.Interface)] IWebView2WebView3 webview, [In, MarshalAs(UnmanagedType.Interface)] object args);
	}
}