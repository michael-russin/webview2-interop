using System;
using MtrDev.WebView2.Interop;
using MtrDev.WebView2.Interop.Test.Args;

namespace MtrDev.WebView2.Interop.Test.Handlers
{
    /// <summary>
    /// Fires when an HTTP request is made in the webview. The host can override
    /// request, response headers and response content.
    /// </summary>
    internal class WebResourceRequestedEventHandler : HandlerBase<WebResourceRequestedEventArgs>, IWebView2WebResourceRequestedEventHandler
    {
        public WebResourceRequestedEventHandler(Action<WebResourceRequestedEventArgs> callback) : base(callback)
        {
        }

        public void Invoke(IWebView2WebView webview, IWebView2WebResourceRequestedEventArgs args)
        {
            System.Diagnostics.Debug.WriteLine("hi");
//            WebResourceRequestedEventArgs eventArgs = new WebResourceRequestedEventArgs(args);
//            Callback.Invoke(eventArgs);
        }
    }
}
