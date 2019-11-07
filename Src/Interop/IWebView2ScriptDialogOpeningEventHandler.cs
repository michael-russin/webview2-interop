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
    [Guid("8EAF9A50-2AF9-45DA-9AC5-F80F4147180E")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2ScriptDialogOpeningEventHandler
	{
		
		void Invoke([In] IWebView2WebView webview, [In] IWebView2ScriptDialogOpeningEventArgs args);
	}
}