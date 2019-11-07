using MtrDev.WebView2.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop.Test.Args
{
    internal class DocumentStateChangedEventArgs : IWebView2DocumentStateChangedEventArgs
    {
        private IWebView2DocumentStateChangedEventArgs _args;
        public DocumentStateChangedEventArgs(IWebView2DocumentStateChangedEventArgs args)
        {
            _args = args;
        }

        public bool IsErrorPage => _args.IsErrorPage;

        public bool IsNewDocument => _args.IsNewDocument;

        public override string ToString()
        {
            return string.Format("IsErrorPage={0}, IsNewDocument={1}", IsErrorPage, IsNewDocument);
        }
    }
}
