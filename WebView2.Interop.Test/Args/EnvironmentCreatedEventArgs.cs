using MtrDev.WebView2.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop.Test.Args
{
    internal class EnvironmentCreatedEventArgs
    {
        public int Result;
        public IWebView2Environment WebViewEnvironment;

        public EnvironmentCreatedEventArgs(int result, IWebView2Environment webViewEnvironment)
        {
            Result = result;
            WebViewEnvironment = webViewEnvironment;
        }
    }
}
