using MtrDev.WebView2.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop.Test.Args
{
    internal class NavigationCompletedEventArgs : IWebView2NavigationCompletedEventArgs
    {
        IWebView2NavigationCompletedEventArgs _args;

        public NavigationCompletedEventArgs(IWebView2NavigationCompletedEventArgs args)
        {
            _args = args;
        }

        public bool IsSuccess => _args.IsSuccess;

        public WEBVIEW2_WEB_ERROR_STATUS WebErrorStatus => _args.WebErrorStatus;

        public override string ToString()
        {
            return string.Format("IsSuccess={0}, WebErrorStatus={1}",IsSuccess, WebErrorStatus);
        }
    }
}
