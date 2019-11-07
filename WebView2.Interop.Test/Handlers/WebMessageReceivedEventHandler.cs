using System;
using MtrDev.WebView2.Interop;

namespace MtrDev.WinForms.Handlers
{
    public class WebMessageReceivedEventHandler : IWebView2WebMessageReceivedEventHandler
    {
        Action<WebMessageReceivedEventArgs> _callback;

        public WebMessageReceivedEventHandler(Action<WebMessageReceivedEventArgs> callback)
        {
            _callback = callback;
        }

        public void Invoke(IWebView2WebView3 webview, IWebView2WebMessageReceivedEventArgs args)
        {
            WebMessageReceivedEventArgs eventArgs = new WebMessageReceivedEventArgs(args);
            _callback.Invoke(eventArgs);
        }
    }
}
