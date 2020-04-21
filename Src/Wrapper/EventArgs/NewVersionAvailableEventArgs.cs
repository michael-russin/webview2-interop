using MtrDev.WebView2.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Wrapper
{
    public class NewVersionAvailableEventArgs : EventArgs, ICoreWebView2NewBrowserVersionAvailableEventArgs
    {
        private ICoreWebView2NewBrowserVersionAvailableEventArgs _args;

        public NewVersionAvailableEventArgs(ICoreWebView2NewBrowserVersionAvailableEventArgs args)
        {
            _args = args;
        }

        public string NewVersion => _args.NewVersion;
    }
}
