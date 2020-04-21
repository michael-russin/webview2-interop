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
    [Guid("E4CDFD7A-AA15-4738-8A8F-4C8C28A9BAC1")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2ScriptDialogOpeningEventHandler
	{
		
		void Invoke([In] ICoreWebView2 webview, [In] ICoreWebView2ScriptDialogOpeningEventArgs args);
	}
}