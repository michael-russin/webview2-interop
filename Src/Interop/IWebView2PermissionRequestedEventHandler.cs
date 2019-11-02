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
    [Guid("C5DA3C20-95AC-4345-B3C9-5FCA3B92C9DB")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2PermissionRequestedEventHandler
	{
		
		void Invoke([In] IWebView2WebView webview, [In] IWebView2PermissionRequestedEventArgs args);
	}
}