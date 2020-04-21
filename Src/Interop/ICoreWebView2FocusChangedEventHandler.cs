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
    [Guid("19F31771-9BB5-422B-9A0A-6EDDAF4FFE0F")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2FocusChangedEventHandler
	{
		
		void Invoke([In] ICoreWebView2Host webview, [In, MarshalAs(UnmanagedType.IUnknown)] object args);
	}
}