#region License
// Copyright (c) 2019 Michael T. Russin
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using MtrDev.WebView2.Interop;
using MtrDev.WebView2.Wrapper.Handlers;
using System;

namespace MtrDev.WebView2.Wrapper
{
    /// <summary>
    /// A Receiver is created for a particular DevTools Protocol event and allows
    /// you to subscribe and unsubsribe from that event.
    /// Obtained from the WebView object via GetDevToolsProtocolEventReceiver.
    /// </summary>
    public class WebView2DevToolsProtocolEventReceiver
    {
        private ICoreWebView2DevToolsProtocolEventReceiver _reciever;

        internal WebView2DevToolsProtocolEventReceiver(string eventName, ICoreWebView2DevToolsProtocolEventReceiver receiver)
        {
            EventName = eventName;
            _reciever = receiver;
        }

        public string EventName
        {
            get;
            private set;
        }

        public long RegisterDevToolsProtocolEventReceived(Action<DevToolsProtocolEventReceivedEventArgs> callback)
        {
            DevToolsProtocolEventReceivedEventHandler completedHandler = new DevToolsProtocolEventReceivedEventHandler(EventName, callback);

            EventRegistrationToken token;
            _reciever.add_DevToolsProtocolEventReceived(completedHandler, out token);
            return token.value;
        }

        /// <summary>
        /// Remove an event handler previously added with RegisterDevToolsProtocolEventReceived
        /// </summary>
        /// <param name="token"></param>
        public void UnregisterDevToolsProtocolEventReceived(long token)
        {
            EventRegistrationToken registrationToken = new EventRegistrationToken()
            {
                value = token
            };
            _reciever.remove_DevToolsProtocolEventReceived(registrationToken);
        }
    }
}
