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
    [Guid("A5C0B08B-25D7-4BAC-AD06-11783393088E")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2ZoomFactorChangedEventHandler
	{
		
		void Invoke([In] IWebView2WebView webview, [In] object args);
	}
}