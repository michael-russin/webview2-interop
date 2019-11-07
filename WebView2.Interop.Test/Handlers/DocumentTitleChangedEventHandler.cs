using System;
using MtrDev.WebView2.Interop;
using MtrDev.WebView2.Interop.Test.Args;

namespace MtrDev.WebView2.Interop.Test.Handlers
{
    internal class DocumentTitleChangedEventHandler : HandlerBase<DocumentTitleChangedEventArgs>, 
        IWebView2DocumentTitleChangedEventHandler
    {
        public DocumentTitleChangedEventHandler(Action<DocumentTitleChangedEventArgs> callback) : base(callback)
        {
        }

        public void Invoke(IWebView2WebView3 webview, object args)
        {
            DocumentTitleChangedEventArgs completedArgs = new DocumentTitleChangedEventArgs(webview);
            Callback(completedArgs);
        }
    }
}
