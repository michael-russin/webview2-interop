using System;
using MtrDev.WebView2.Interop;
using MtrDev.WebView2.Interop.Test.Args;

namespace MtrDev.WebView2.Interop.Test.Handlers
{
    internal class PermissionRequestedEventHandler : HandlerBase<PermissionRequestedEventArgs>,
        IWebView2PermissionRequestedEventHandler
    {
        public PermissionRequestedEventHandler(Action<PermissionRequestedEventArgs> callback) : base(callback)
        {
        }

        public void Invoke(IWebView2WebView3 webview, IWebView2PermissionRequestedEventArgs args)
        {
            PermissionRequestedEventArgs eventArgs = new PermissionRequestedEventArgs(args);
            Callback.Invoke(eventArgs);
        }
    }
}
