using System;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    [ComVisible(true)]
    [ComImport]
    [Guid("70057D5C-0BAA-4219-97B0-FFF1C088ED32")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICoreWebView2ContentLoadingEventHandler
    {
        void Invoke([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2 webview, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ContentLoadingEventArgs args);
    }
}
