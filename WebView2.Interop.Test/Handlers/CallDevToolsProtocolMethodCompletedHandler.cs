using System;
using MtrDev.WebView2.Interop;
using MtrDev.WebView2.Interop.Test.Args;

namespace MtrDev.WebView2.Interop.Test.Handlers
{
    internal class CallDevToolsProtocolMethodCompletedHandler : HandlerBase<CallDevToolsProtocolMethodCompletedEventArgs>, 
        IWebView2CallDevToolsProtocolMethodCompletedHandler
    {
        private string _methodName;

        public CallDevToolsProtocolMethodCompletedHandler(string methodName, Action<CallDevToolsProtocolMethodCompletedEventArgs> callback) : base(callback)
        {
            _methodName = methodName;
        }

        public void Invoke(int errorCode, string returnObjectAsJson)
        {
            CallDevToolsProtocolMethodCompletedEventArgs eventArgs = new CallDevToolsProtocolMethodCompletedEventArgs(_methodName, errorCode, returnObjectAsJson);
            Callback(eventArgs);
        }
    }
}
