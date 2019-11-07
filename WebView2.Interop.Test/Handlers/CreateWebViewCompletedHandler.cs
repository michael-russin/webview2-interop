using System;
using MtrDev.WebView2.Interop;
using MtrDev.WebView2.Interop.Test.Args;

namespace MtrDev.WebView2.Interop.Test.Handlers
{
    internal class CreateWebViewCompletedHandler : HandlerBase<CreateWebViewCompletedEventArgs>, IWebView2CreateWebViewCompletedHandler
    {
        internal CreateWebViewCompletedHandler(Action<CreateWebViewCompletedEventArgs> callback) : base(callback)
        {
        }

        public void Invoke(int result, IWebView2WebView3 webView)
        {
            CreateWebViewCompletedEventArgs eventArgs = new CreateWebViewCompletedEventArgs(result, webView);
            Callback.Invoke(eventArgs);
        }
    }
}
