using System;
using MtrDev.WebView2.Interop;
using MtrDev.WebView2.Interop.Test.Args;

namespace MtrDev.WebView2.Interop.Test.Handlers
{
    internal class AddScriptToExecuteOnDocumentCreatedCompletedHandler : HandlerBase<AddScriptToExecuteOnDocumentCreatedCompletedEventArgs>,
        IWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler
    {
        public AddScriptToExecuteOnDocumentCreatedCompletedHandler(Action<AddScriptToExecuteOnDocumentCreatedCompletedEventArgs> callback) : base(callback)
        {
        }

        public void Invoke(int errorCode, string id)
        {
            AddScriptToExecuteOnDocumentCreatedCompletedEventArgs eventArgs = 
                new AddScriptToExecuteOnDocumentCreatedCompletedEventArgs(errorCode, id);
            Callback.Invoke(eventArgs);
        }
    }
}
