using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop.Test.Args
{
    public class WebMessageReceivedEventArgs : IWebView2WebMessageReceivedEventArgs
    {
        private IWebView2WebMessageReceivedEventArgs _args;

        public WebMessageReceivedEventArgs(IWebView2WebMessageReceivedEventArgs args)
        {
            _args = args;
        }

        public string Source => _args.Source;

        public string WebMessageAsJson
        {
            get
            {
                try
                {
                    return _args.WebMessageAsJson;
                }
                catch
                { }
                return string.Empty;
            }
        }

        public string WebMessageAsString
        {
            get
            {
                try
                {
                    return _args.WebMessageAsString;
                }
                catch
                { }
                return string.Empty;
            }
        }

        public override string ToString()
        {
            return string.Format("Source={0}, WebMessageAsJson={1}, WebMessageAsString={2}", Source, WebMessageAsJson, WebMessageAsString);
        }
    }
}
