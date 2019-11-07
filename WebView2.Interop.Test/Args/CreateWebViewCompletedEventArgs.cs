using MtrDev.WebView2.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop.Test.Args
{
    internal class CreateWebViewCompletedEventArgs
    {
        public int Result;
        public IWebView2WebView3 WebView;

        internal CreateWebViewCompletedEventArgs(int result, IWebView2WebView3 webView)
        {
            Result = result;
            WebView = webView;
        }
    }
}
