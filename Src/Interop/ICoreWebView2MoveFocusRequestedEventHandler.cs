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
    [Guid("01BA7131-3DBE-4C83-A789-99C467A2C3F5")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2MoveFocusRequestedEventHandler
	{
		
		void Invoke([In] ICoreWebView2Host webview, [In] ICoreWebView2MoveFocusRequestedEventArgs args);
	}
}