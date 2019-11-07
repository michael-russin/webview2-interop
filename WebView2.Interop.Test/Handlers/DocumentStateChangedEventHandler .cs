using System;
using MtrDev.WebView2.Interop;
using MtrDev.WebView2.Interop.Test.Args;

namespace MtrDev.WebView2.Interop.Test.Handlers
{
    internal class DocumentStateChangedEventHandler : HandlerBase<DocumentStateChangedEventArgs>, 
        IWebView2DocumentStateChangedEventHandler
    {
        public DocumentStateChangedEventHandler(Action<DocumentStateChangedEventArgs> callback) : base(callback)
        {
        }

        public void Invoke(IWebView2WebView3 webview, IWebView2DocumentStateChangedEventArgs args)
        {
            DocumentStateChangedEventArgs eventArgs = new DocumentStateChangedEventArgs(args);
            Callback.Invoke(eventArgs);
        }
    }
}
