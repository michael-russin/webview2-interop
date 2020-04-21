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
    [Guid("1B03A40F-92B7-443A-87E0-B65714B6CB9D")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2ZoomFactorChangedEventHandler
	{
		
		void Invoke([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2Host webview, [In, MarshalAs(UnmanagedType.Interface)] object args);
	}
}