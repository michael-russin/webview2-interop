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
    [Guid("865E16C4-A24D-4AC1-BC23-2E608CA313F9")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICoreWebView2NewBrowserVersionAvailableEventHandler
    {
        void Invoke([In] ICoreWebView2Environment webViewEnvironment, [In] ICoreWebView2NewBrowserVersionAvailableEventArgs args);
    }
}
