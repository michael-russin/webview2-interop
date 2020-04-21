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
    [Guid("6EF9912F-5A9D-42A9-8C17-9BB53E1D5C63")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICoreWebView2WebResourceRequestedEventArgs
    {
        [DispId(1610678272)]
        ICoreWebView2WebResourceRequest Request
        {
            get;
        }

        [DispId(1610678273)]
        ICoreWebView2WebResourceResponse Response
        {
            get;
            set;
        }

        ICoreWebView2Deferral GetDeferral();

        void ResourceContext(ref WEBVIEW2_WEB_RESOURCE_CONTEXT context);
    }
}
