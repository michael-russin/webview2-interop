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
    [Guid("1DAA050A-98DE-44AD-B5BB-935C8B9C7C0B")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2NewWindowRequestedEventHandler
	{
		
		void Invoke([In] IWebView2WebView webview, [In] IWebView2NewWindowRequestedEventArgs args);
	}
}