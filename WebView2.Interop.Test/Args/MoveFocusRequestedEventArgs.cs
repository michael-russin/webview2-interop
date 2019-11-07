using MtrDev.WebView2.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop.Test.Args
{
    internal class MoveFocusRequestedEventArgs : IWebView2MoveFocusRequestedEventArgs
    {
        IWebView2MoveFocusRequestedEventArgs _args;

        public MoveFocusRequestedEventArgs(IWebView2MoveFocusRequestedEventArgs args)
        {
            _args = args;
        }

        public WEBVIEW2_MOVE_FOCUS_REASON Reason => _args.Reason;

        public bool Handled { get => _args.Handled; set => _args.Handled = value; }

        public override string ToString()
        {
            return string.Format("Reason={0}, Handled={1}", Reason, Handled);
        }
    }
}
