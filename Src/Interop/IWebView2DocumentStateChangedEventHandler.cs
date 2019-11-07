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
    [Guid("88E66305-3A5A-4E7F-9C76-2EBFC138CAFD")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2DocumentStateChangedEventHandler
	{
		
		void Invoke([In, MarshalAs(UnmanagedType.Interface)] IWebView2WebView3 webview, [In, MarshalAs(UnmanagedType.Interface)] IWebView2DocumentStateChangedEventArgs args);
	}
}