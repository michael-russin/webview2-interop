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
    [Guid("76BDBECE-02CC-4E56-AD81-5F808E8572A6")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2FocusChangedEventHandler
	{
		
		void Invoke([In] IWebView2WebView webview, [In, MarshalAs(UnmanagedType.IUnknown)] object args);
	}
}