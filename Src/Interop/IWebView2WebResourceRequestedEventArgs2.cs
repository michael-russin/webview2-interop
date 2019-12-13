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
    [Guid("b38f6f16-9568-4f12-9996-dca7a06299f4")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWebView2WebResourceRequestedEventArgs2 : IWebView2WebResourceRequestedEventArgs
    {
        [DispId(1610678272)]
        new IWebView2WebResourceRequest Request
        {
            get;
        }

        [DispId(1610678273)]
        new IWebView2WebResourceResponse Response
        {
            get;
            set;
        }

        new IWebView2Deferral GetDeferral();

        void resourceContext(ref WEBVIEW2_WEB_RESOURCE_CONTEXT context);
    }
}
