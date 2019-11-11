using MtrDev.WebView2.Interop;
using System;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Wrapper.Handlers
{
    public class AcceleratorKeyPressedEventHandler : HandlerBase<AcceleratorKeyPressedEventArgs>, IWebView2AcceleratorKeyPressedEventHandler
    {
        public AcceleratorKeyPressedEventHandler(Action<AcceleratorKeyPressedEventArgs> callback) : base(callback)
        {
        }

        public void Invoke([In] IWebView2WebView webview, [In] IWebView2AcceleratorKeyPressedEventArgs args)
        {
            AcceleratorKeyPressedEventArgs eventArgs = new AcceleratorKeyPressedEventArgs(args);
            Callback(eventArgs);
        }
    }
}
