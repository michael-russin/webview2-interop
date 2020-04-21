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
    [Guid("A85C66A9-DE47-47F7-AD64-ABB32F1CF14D")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2ProcessFailedEventHandler
	{
		
		void Invoke([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2 webview, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ProcessFailedEventArgs args);
	}
}