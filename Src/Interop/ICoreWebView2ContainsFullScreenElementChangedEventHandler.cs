using System;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    [ComVisible(true)]
    [ComImport]
    [Guid("EC2AF7C6-4579-40AB-8C36-5CCEE58EB7CB")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICoreWebView2ContainsFullScreenElementChangedEventHandler
    {
        void Invoke([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2 webview, [In, MarshalAs(UnmanagedType.Interface)] object args);
    }
}
