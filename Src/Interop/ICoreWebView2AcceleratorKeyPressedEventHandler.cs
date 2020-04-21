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
    [Guid("253D0AA2-6F85-4FB2-9D6B-0DC5FEDBB085")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICoreWebView2AcceleratorKeyPressedEventHandler
    {
        void Invoke([In] ICoreWebView2Host webview, [In] ICoreWebView2AcceleratorKeyPressedEventArgs args);
    }
}
