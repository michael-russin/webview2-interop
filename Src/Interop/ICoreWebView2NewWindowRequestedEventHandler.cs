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
    [Guid("715E10DD-2323-4F03-B6B3-AB34006B96D5")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2NewWindowRequestedEventHandler
	{
		
		void Invoke([In] ICoreWebView2 webview, [In] ICoreWebView2NewWindowRequestedEventArgs args);
	}
}