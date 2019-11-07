using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop.Test.Args
{
    internal class ProcessFailedEventArgs : IWebView2ProcessFailedEventArgs
    {
        private IWebView2ProcessFailedEventArgs _args;

        public ProcessFailedEventArgs(IWebView2ProcessFailedEventArgs args)
        {
            _args = args;
        }

        public WEBVIEW2_PROCESS_FAILED_KIND ProcessFailedKind => _args.ProcessFailedKind;

        public override string ToString()
        {
            return string.Format("ProcessFailedKind = {0}", ProcessFailedKind);
        }
    }
}
