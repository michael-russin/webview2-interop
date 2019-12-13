using System;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    [ComVisible(true)]
    [ComImport]
    [Guid("37CF6A21-4B0C-41B6-81A6-C85C0D0A7543")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWebView2ContainsFullScreenElementChangedEventHandler
    {
        void Invoke([In, MarshalAs(UnmanagedType.Interface)] IWebView2WebView5 webview, [In, MarshalAs(UnmanagedType.Interface)] object args);
    }
}
