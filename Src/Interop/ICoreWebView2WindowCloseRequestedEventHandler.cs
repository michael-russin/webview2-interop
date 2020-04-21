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
    [Guid("1AE0297A-9671-4ED6-902A-4544B9B4AECD")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICoreWebView2WindowCloseRequestedEventHandler
    {
        void Invoke([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2 webview, [In, MarshalAs(UnmanagedType.Interface)] object args);
    }
}
