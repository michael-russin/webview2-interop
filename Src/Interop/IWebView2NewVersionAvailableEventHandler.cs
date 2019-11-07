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
    [Guid("9E21312F-6FE7-4118-8CA1-6317C9CD627B")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWebView2NewVersionAvailableEventHandler
    {
        void Invoke([In] IWebView2Environment webViewEnvironment, [In] IWebView2NewVersionAvailableEventArgs args);
    }
}
