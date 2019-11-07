using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop.Test.Args
{
    public class NewWindowRequestedEventArgs : IWebView2NewWindowRequestedEventArgs
    {
        private IWebView2NewWindowRequestedEventArgs _args;

        public NewWindowRequestedEventArgs(IWebView2NewWindowRequestedEventArgs args)
        {
            _args = args;
        }

        public string Uri => _args.Uri;

        public IWebView2WebView NewWindow { get => _args.NewWindow; set => _args.NewWindow = value; }
        public bool Handled { get => _args.Handled; set => _args.Handled = value; }

        public bool IsUserInitiated => _args.IsUserInitiated;

        public IWebView2Deferral GetDeferral()
        {
            return _args.GetDeferral();
        }

        public override string ToString()
        {
            return string.Format("Handled={0}, IsUserInitiated={1}", Handled, IsUserInitiated);
        }
    }
}
