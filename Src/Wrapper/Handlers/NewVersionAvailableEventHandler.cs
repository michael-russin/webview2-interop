using MtrDev.WebView2.Interop;
using System;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Wrapper.Handlers
{
    public class NewVersionAvailableEventHandler : HandlerBase<NewVersionAvailableEventArgs>, 
        IWebView2NewVersionAvailableEventHandler
    {
        public NewVersionAvailableEventHandler(Action<NewVersionAvailableEventArgs> callback) : base(callback)
        {
        }

        public void Invoke([In] IWebView2Environment webViewEnvironment, [In] IWebView2NewVersionAvailableEventArgs args)
        {
            NewVersionAvailableEventArgs eventArgs = new NewVersionAvailableEventArgs(args);
            Callback.Invoke(eventArgs);
        }
    }
}
