using System;
using MtrDev.WebView2.Interop;
using MtrDev.WebView2.Interop.Test.Args;

namespace MtrDev.WebView2.Interop.Test.Handlers
{
    internal class ZoomFactorChangedEventHandler : IWebView2ZoomFactorChangedEventHandler
    {
        Action<ZoomFactorCompletedEventArgs> _callback;

        internal ZoomFactorChangedEventHandler(Action<ZoomFactorCompletedEventArgs> callback)
        {
            _callback = callback;
        }


        public void Invoke(IWebView2WebView webview, object args)
        {
            ZoomFactorCompletedEventArgs eventArgs = new ZoomFactorCompletedEventArgs(args);
            _callback.Invoke(eventArgs);
        }
    }
}
