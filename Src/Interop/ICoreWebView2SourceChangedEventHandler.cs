using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop
{
    [ComVisible(true)]
    [ComImport]
    [Guid("E345159A-B573-41AB-A4F7-F94CB238AF45")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICoreWebView2SourceChangedEventHandler
    {
        void Invoke([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2 webview, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2SourceChangedEventArgs args);
    }
}
