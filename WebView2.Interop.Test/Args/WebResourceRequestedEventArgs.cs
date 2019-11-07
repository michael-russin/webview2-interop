using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop.Test.Args
{
    internal class WebResourceRequestedEventArgs : IWebView2WebResourceRequestedEventArgs
    {
        private IWebView2WebResourceRequestedEventArgs _args;

        public WebResourceRequestedEventArgs(IWebView2WebResourceRequestedEventArgs args)
        {
            _args = args;
        }

        public IWebView2WebResourceRequest Request => _args.Request;

        public IWebView2WebResourceResponse Response { get => _args.Response; set => _args.Response = value; }

        public IWebView2Deferral GetDeferral()
        {
            return _args.GetDeferral();
        }

        public override string ToString()
        {
            return string.Format("Request = {0}, Response= {1}", Request, Response);
        }
    }
}
