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
    [Guid("DCEB3A27-C8C0-4DE7-889D-AF3DE80EDB3C")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2NavigationCompletedEventHandler
	{
		
		void Invoke([In] IWebView2WebView webview, [In] IWebView2NavigationCompletedEventArgs args);
	}
}