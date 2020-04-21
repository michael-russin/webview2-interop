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
    [Guid("17EB2F75-B65B-4E5F-A0E1-933126DDD5BB")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2NavigationCompletedEventHandler
	{
		
		void Invoke([In] ICoreWebView2 webview, [In] ICoreWebView2NavigationCompletedEventArgs args);
	}
}