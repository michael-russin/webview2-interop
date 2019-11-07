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
    [Guid("53E3676B-287C-4967-B7E2-DA0448BEB0F1")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWebView2AcceleratorKeyPressedEventHandler
    {
        void Invoke([In] IWebView2WebView webview, [In] IWebView2AcceleratorKeyPressedEventArgs args);
    }
}
