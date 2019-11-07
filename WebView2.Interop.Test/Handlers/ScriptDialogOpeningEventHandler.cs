using System;
using MtrDev.WebView2.Interop;
using MtrDev.WebView2.Interop.Test.Args;

namespace MtrDev.WebView2.Interop.Test.Handlers
{
    internal class ScriptDialogOpeningEventHandler : HandlerBase<ScriptDialogOpeningEventArgs>, IWebView2ScriptDialogOpeningEventHandler
    {
        public ScriptDialogOpeningEventHandler(Action<ScriptDialogOpeningEventArgs> callback) : base(callback)
        {
        }

        public void Invoke(IWebView2WebView webview, IWebView2ScriptDialogOpeningEventArgs args)
        {
            ScriptDialogOpeningEventArgs eventArgs = new ScriptDialogOpeningEventArgs(args);
            Callback.Invoke(eventArgs);
        }
    }
}
