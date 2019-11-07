using System;
using MtrDev.WebView2.Interop;
using MtrDev.WebView2.Interop.Test.Args;

namespace MtrDev.WebView2.Interop.Test.Handlers
{
    class ProcessFailedEventHandler : HandlerBase<ProcessFailedEventArgs>, IWebView2ProcessFailedEventHandler
    {
        public ProcessFailedEventHandler(Action<ProcessFailedEventArgs> callback) : base(callback)
        {
        }

        public void Invoke(IWebView2WebView3 webview, IWebView2ProcessFailedEventArgs args)
        {
            ProcessFailedEventArgs eventArgs = new ProcessFailedEventArgs(args);
            Callback.Invoke(eventArgs);
        }
    }
}
