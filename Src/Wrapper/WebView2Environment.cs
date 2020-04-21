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
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace MtrDev.WebView2.Wrapper
{
    public class WebView2Environment 
    {
        private ICoreWebView2Environment _environment;

        internal WebView2Environment(ICoreWebView2Environment environment)
        {
            _environment = (ICoreWebView2Environment)environment;
        }

        /// <summary>
        /// Create a new web resource response object. The headers is the
        /// raw response header string delimited by newline. It's also possible to
        /// create this object with empty headers string and then use the
        /// IWebView2HttpResponseHeaders to construct the headers line by line.
        /// For information on other parameters see IWebView2WebResourceResponse.
        ///
        /// </summary>
        /// <param name="content"></param>
        /// <param name="statusCode"></param>
        /// <param name="reasonPhrase"></param>
        /// <param name="headers"></param>
        /// <param name="response"></param>
        public WebView2WebResourceResponse CreateWebResourceResponse(IStream content, int statusCode, string reasonPhrase, string headers)
        {
            ICoreWebView2WebResourceResponse response = null;
            _environment.CreateWebResourceResponse(content, statusCode, reasonPhrase, headers, ref response);

            WebView2WebResourceResponse wrappedResonse = new WebView2WebResourceResponse(response);
            return wrappedResonse;
        }

        /// <summary>
        /// Asynchronously create a new IWebView2WebView.
        ///
        /// parentWindow is the HWND in which the WebView should be displayed and
        /// from which receive input. The WebView will add a child window to the
        /// provided window during WebView creation. Z-order and other things impacted
        /// by sibling window order will be affected accordingly.
        /// </summary>
        /// <param name="parentHwnd">HWND in which the WebView should be displayed and from which receive input</param>
        /// <param name="handler"></param>
        public void CreateWebView(IntPtr parentHwnd, Action<CreateWebViewCompletedEventArgs> handler)
        {
            CreateWebViewCompletedHandler callback = new CreateWebViewCompletedHandler(handler);

            _environment.CreateCoreWebView2Host(parentHwnd, callback);
        }

        #region IWebView2Environment2

        /// <summary>
        /// The browser version info of the current IWebView2Environment,
        /// including channel name if it is not the stable channel.
        /// This matches the format of the GetWebView2BrowserVersionInfo API.
        /// Channel names are 'beta', 'dev', and 'canary'.
        /// </summary>
        public string BrowserVersionInfo
        {
            get
            {
                return _environment.BrowserVersionInfo;
            }
        }
        #endregion

        private IDictionary<long, Action<NewVersionAvailableEventArgs>> _newVersionAvailableCallbacks =
                new Dictionary<long, Action<NewVersionAvailableEventArgs>>();

        #region IWebView2Environment3
        /// <summary>
        /// Registers to receive NewVersionAvailable events.
        /// Use the NewVersion property of <see cref="NewVersionAvailableEventArgs"/>
        /// to get the new version number.
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        public long RegisterNewVersionAvailable(Action<NewVersionAvailableEventArgs> callback)
        {
            NewVersionAvailableEventHandler completedHandler = new NewVersionAvailableEventHandler(callback);

            EventRegistrationToken token;
            _environment.add_NewVersionAvailable(completedHandler, out token);
            _newVersionAvailableCallbacks.Add(token.value, callback);
            return token.value;
        }

        /// <summary>
        /// Unregisters a NewVersionAvailable event.
        /// </summary>
        /// <param name="token"></param>
        public void UnregisterNewVersionAvailable(long token)
        {
            _newVersionAvailableCallbacks.Remove(token);

            EventRegistrationToken registrationToken = new EventRegistrationToken()
            {
                value = token
            };
            _environment.remove_NewVersionAvailable(registrationToken);
        }
        #endregion
    }
}
