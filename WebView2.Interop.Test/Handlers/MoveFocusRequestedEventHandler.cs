using System;
using MtrDev.WebView2.Interop;
using MtrDev.WebView2.Interop.Test.Args;

namespace MtrDev.WebView2.Interop.Test.Handlers
{
    class MoveFocusRequestedEventHandler : HandlerBase<MoveFocusRequestedEventArgs>, 
        IWebView2MoveFocusRequestedEventHandler
    {
        public MoveFocusRequestedEventHandler(Action<MoveFocusRequestedEventArgs> callback) : base(callback)
        {
        }

        public void Invoke(IWebView2WebView3 webview, IWebView2MoveFocusRequestedEventArgs args)
        {
            MoveFocusRequestedEventArgs eventArgs = new MoveFocusRequestedEventArgs(args);
            Callback.Invoke(eventArgs);
        }
    }
}
