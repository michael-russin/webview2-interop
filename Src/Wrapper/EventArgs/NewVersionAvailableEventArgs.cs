using MtrDev.WebView2.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Wrapper
{
    public class NewVersionAvailableEventArgs : EventArgs, IWebView2NewVersionAvailableEventArgs
    {
        private IWebView2NewVersionAvailableEventArgs _args;

        public NewVersionAvailableEventArgs(IWebView2NewVersionAvailableEventArgs args)
        {
            _args = args;
        }

        public string NewVersion => _args.NewVersion;
    }
}
