using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop.Test.Args
{
    internal class ScriptDialogOpeningEventArgs : IWebView2ScriptDialogOpeningEventArgs
    {
        private IWebView2ScriptDialogOpeningEventArgs _args;

		public ScriptDialogOpeningEventArgs(IWebView2ScriptDialogOpeningEventArgs args)
        {
            _args = args;
        }

        public string Uri => _args.Uri;

        public WEBVIEW2_SCRIPT_DIALOG_KIND Kind => _args.Kind;

        public string Message => _args.Message;

        public void Accept()
        {
            _args.Accept();
        }

        public string DefaultText => _args.DefaultText;

        public string ResultText { get => _args.ResultText; set => _args.ResultText = value; }

        public IWebView2Deferral GetDeferral()
        {
            return _args.GetDeferral();
        }

        public override string ToString()
        {
            return string.Format("Uri={0}, Kind={1}, Message={4}, DefaultText={2}, ResultText={3},",
                Uri, Kind, DefaultText, ResultText, Message);
        }
    }
}
