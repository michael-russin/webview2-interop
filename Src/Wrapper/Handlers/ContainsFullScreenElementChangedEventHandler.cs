using MtrDev.WebView2.Interop;
using System;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Wrapper.Handlers
{
    public class ContainsFullScreenElementChangedEventHandler : HandlerBase<ContainsFullScreenElementChangedEventArgs>, IWebView2ContainsFullScreenElementChangedEventHandler
    {
        public ContainsFullScreenElementChangedEventHandler(Action<ContainsFullScreenElementChangedEventArgs> callback) : base(callback)
        {
        }

        public void Invoke(IWebView2WebView5 webview, object args)
        {
            ContainsFullScreenElementChangedEventArgs eventArgs = new ContainsFullScreenElementChangedEventArgs();
            Callback(eventArgs);
        }
    }
}
