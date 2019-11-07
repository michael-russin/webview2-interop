using MtrDev.WebView2.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop.Test.Args
{
    internal class NavigationStartingEventArgs : IWebView2NavigationStartingEventArgs
    {
        IWebView2NavigationStartingEventArgs _args;

        public NavigationStartingEventArgs(IWebView2NavigationStartingEventArgs args)
        {
            _args = args;
        }

        public string Uri => _args.Uri;

        public bool IsUserInitiated => _args.IsUserInitiated;

        public bool IsRedirected => _args.IsRedirected;

        public IWebView2HttpRequestHeaders RequestHeaders => _args.RequestHeaders;

        public bool Cancel { get => _args.Cancel; set => _args.Cancel = value; }

        public override string ToString()
        {
            IWebView2HttpHeadersCollectionIterator iterator;
            RequestHeaders.GetIterator(out iterator);
            int hasNext;
            iterator.MoveNext(out hasNext);
            while(hasNext == 1)
            {
                string name;
                string value;
                iterator.GetCurrentHeader(out name, out value);
                System.Diagnostics.Debug.WriteLine("Name={0} Value={1}", name, value);
                iterator.MoveNext(out hasNext);
            }

            return string.Format("Uri={0}, IsUserInitiated={1}, IsRedirected={2}, Cancel={3}", Uri, IsUserInitiated, IsRedirected, Cancel);
        }
    }
}
