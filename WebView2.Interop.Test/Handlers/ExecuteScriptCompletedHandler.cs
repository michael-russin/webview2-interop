using System;
using MtrDev.WebView2.Interop;
using MtrDev.WebView2.Interop.Test.Args;

namespace MtrDev.WebView2.Interop.Test.Handlers
{
    internal class ExecuteScriptCompletedHandler : HandlerBase<ExecuteScriptCompletedEventArgs>, IWebView2ExecuteScriptCompletedHandler
    {
        public ExecuteScriptCompletedHandler(Action<ExecuteScriptCompletedEventArgs> callback) : base(callback)
        {
        }

        public void Invoke(int errorCode, string resultObjectAsJson)
        {
            ExecuteScriptCompletedEventArgs eventArgs = new ExecuteScriptCompletedEventArgs(errorCode, resultObjectAsJson);
            Callback.Invoke(eventArgs);
        }
    }
}
