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
    [Guid("29211B19-F775-48CC-9757-5DA3CA1F626A")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICoreWebView2HistoryChangedEventHandler
    {
        void Invoke([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2 webview, [In, MarshalAs(UnmanagedType.IUnknown)] object args);
    }
}
