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
    [Guid("F3A49DD0-EA49-469C-8B7A-8CC5E8E4EF27")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2MoveFocusRequestedEventHandler
	{
		
		void Invoke([In] IWebView2WebView3 webview, [In] IWebView2MoveFocusRequestedEventArgs args);
	}
}