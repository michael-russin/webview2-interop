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
    [Guid("34896570-DC04-40F9-A2DA-8582551A707D")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2NavigationStartingEventHandler
	{
        void Invoke([In, MarshalAs(UnmanagedType.Interface)] IWebView2WebView3 webview, [In] IWebView2NavigationStartingEventArgs args);
    }
}