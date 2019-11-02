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
    [Guid("34896570-DC04-40F9-A2DA-8582551A707D")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2NavigationStartingEventHandler
	{
		
		void Invoke([In] IWebView2WebView webview, [In] IWebView2NavigationStartingEventArgs args);
	}
}