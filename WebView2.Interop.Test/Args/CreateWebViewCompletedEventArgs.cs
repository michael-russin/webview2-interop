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
        public IWebView2WebView WebView;

        internal CreateWebViewCompletedEventArgs(int result, IWebView2WebView webView)
        {
            Result = result;
            WebView = webView;
        }
    }
}
