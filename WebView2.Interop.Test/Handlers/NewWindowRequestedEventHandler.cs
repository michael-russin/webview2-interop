using System;
using MtrDev.WebView2.Interop;
using MtrDev.WebView2.Interop.Test.Args;

namespace MtrDev.WebView2.Interop.Test.Handlers
{
    internal class NewWindowRequestedEventHandler : HandlerBase<NewWindowRequestedEventArgs>, IWebView2NewWindowRequestedEventHandler
    {
        public NewWindowRequestedEventHandler(Action<NewWindowRequestedEventArgs> callback) : base(callback)
        {
        }

        public void Invoke(IWebView2WebView webview, IWebView2NewWindowRequestedEventArgs args)
        {
            NewWindowRequestedEventArgs eventArgs = new NewWindowRequestedEventArgs(args);
            Callback.Invoke(eventArgs);
        }
    }
}
