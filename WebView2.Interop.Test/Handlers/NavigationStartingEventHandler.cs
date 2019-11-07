using System;
using System.Runtime.InteropServices;
using MtrDev.WebView2.Interop;
using MtrDev.WebView2.Interop.Test.Args;

namespace MtrDev.WebView2.Interop.Test.Handlers
{
    internal class NavigationStartingEventHandler : HandlerBase<NavigationStartingEventArgs>,
        IWebView2NavigationStartingEventHandler
    {
        public NavigationStartingEventHandler(Action<NavigationStartingEventArgs> callback) : base(callback)
        {
        }

        public void Invoke(IWebView2WebView webview, IWebView2NavigationStartingEventArgs args)
        {
            NavigationStartingEventArgs completedArgs = new NavigationStartingEventArgs(args);
            Callback(completedArgs);
        }
    }
}
