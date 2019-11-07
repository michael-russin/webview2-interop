using System;
using MtrDev.WebView2.Interop;
using MtrDev.WebView2.Interop.Test.Args;

namespace MtrDev.WebView2.Interop.Test.Handlers
{
    internal class DevToolsProtocolEventReceivedEventHandler : HandlerBase<DevToolsProtocolEventReceivedEventArgs>,
        IWebView2DevToolsProtocolEventReceivedEventHandler
    {
        private string _eventName;

        public DevToolsProtocolEventReceivedEventHandler(string eventName, Action<DevToolsProtocolEventReceivedEventArgs> callback) :
            base(callback)
        {
            _eventName = eventName;
        }

        public void Invoke(IWebView2WebView webview, IWebView2DevToolsProtocolEventReceivedEventArgs args)
        {
            DevToolsProtocolEventReceivedEventArgs eventArgs = new DevToolsProtocolEventReceivedEventArgs(_eventName, args);
            Callback.Invoke(eventArgs);
        }
    }
}
