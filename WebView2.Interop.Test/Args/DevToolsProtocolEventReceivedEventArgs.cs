using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop.Test.Args
{
    internal class DevToolsProtocolEventReceivedEventArgs : IWebView2DevToolsProtocolEventReceivedEventArgs
    {
        private IWebView2DevToolsProtocolEventReceivedEventArgs _args;
        private string _eventName;

        public DevToolsProtocolEventReceivedEventArgs(string eventName, IWebView2DevToolsProtocolEventReceivedEventArgs args)
        {
            _args = args;
            _eventName = eventName;
        }

        public string ParameterObjectAsJson => _args.ParameterObjectAsJson;

        public string EventName => _eventName;

        public override string ToString()
        {
            return string.Format("EventName={0}, ParameterObjectAsJson={1}", EventName, ParameterObjectAsJson);
        }
    }
}
