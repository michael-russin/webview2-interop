using System;
using MtrDev.WebView2.Interop;
using MtrDev.WebView2.Interop.Test.Args;

namespace MtrDev.WebView2.Interop.Test.Handlers
{
    internal class FocusChangedEventHandler : HandlerBase<FocusChangedEventEventArgs>,
        IWebView2FocusChangedEventHandler
    {
        internal FocusChangedEventHandler(Action<FocusChangedEventEventArgs> callback) : base(callback)
        {
        }

        public void Invoke(IWebView2WebView3 webview, object args)
        {
            //            FocusChangedEventEventArgs eventArgs = new FocusChangedEventEventArgs(new WebView2WebView(webview), args);
            FocusChangedEventEventArgs eventArgs = new FocusChangedEventEventArgs(args);
            Callback.Invoke(eventArgs);
        }
    }
}
