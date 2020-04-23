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
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Wrapper
{
    /// <summary>
    /// WebView2 enables you to host web content using the
    /// latest Edge web browser technology.
    /// </summary>
    public class WebView2WebView 
    {
        private ICoreWebView2Host _webviewHost;
        private ICoreWebView2 _webview;

        internal WebView2WebView(ICoreWebView2Host webview)
        {
            _webviewHost = webview;
            _webview = _webviewHost.CoreWebView2;
        }

        public ICoreWebView2 InnerWebView2WebView
        {
            get
            {
                return _webview;
            }
        }

        #region ICoreWebView2
        /// <summary>
        /// Wrapper around IWebView2Settings object contains various modifiable settings for the running WebView.
        /// </summary>
        public WebView2Settings Settings
        {
            get
            {
                return new WebView2Settings(_webview.Settings);
            }
        }

        /// <summary>
        /// The URI of the current top level document. This value potentially
        /// changes as a part of the DocumentStateChanged event firing for some cases
        /// such as navigating to a different site or fragment navigations. It will
        /// remain the same for other types of navigations such as page reloads or
        /// history.pushState with the same URL as the current page.
        /// </summary>
        public string Source
        {
            get
            {
                return _webview.Source;
            }
        }

        /// <summary>
        /// Cause a navigation of the top level document to the specified URI. See
        /// the navigation events for more information. Note that this starts a
        /// navigation and the corresponding NavigationStarting event will fire
        /// sometime after this Navigate call completes.
        /// </summary>
        /// <param name="uri"></param>
        public void Navigate(string uri)
        {
            _webview.Navigate(uri);
        }

        /// <summary>
        /// Initiates a navigation to htmlContent as source HTML of a new
        /// document. The htmlContent parameter may not be larger than 2 MB of
        /// characters. The origin of the new page will be about:blank.
        /// </summary>
        /// <param name="htmlContent"></param>
        public void NavigateToString(string htmlContent)
        {
            _webview.NavigateToString(htmlContent);
        }

        private IDictionary<long, Action<NavigationStartingEventArgs>> _navigationStartingEventDictionary =
                new Dictionary<long, Action<NavigationStartingEventArgs>>();

        /// <summary>
        /// Add an event handler for the NavigationStarting event.
        /// NavigationStarting fires when the WebView main frame is
        /// requesting permission to navigate to a different URI. This will fire for
        /// redirects as well.
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        public long RegisterNavigationStarting(Action<NavigationStartingEventArgs> callback)
        {
            NavigationStartingEventHandler completedHandler = new NavigationStartingEventHandler(callback);

            EventRegistrationToken token;
            _webview.add_NavigationStarting(completedHandler, out token);
            _navigationStartingEventDictionary.Add(token.value, callback);
            return token.value;
        }

        /// <summary>
        /// Remove an event handler for the NavigationStarting event
        /// </summary>
        /// <param name="token"></param>
        public void UnregisterNavigationStarting(long token)
        {
            if (_navigationStartingEventDictionary.ContainsKey(token))
            {
                _navigationStartingEventDictionary.Remove(token);
            }
            EventRegistrationToken registrationToken = new EventRegistrationToken();
            registrationToken.value = token;
            _webview.remove_NavigationStarting(registrationToken);
        }

        private IDictionary<long, Action<ContentLoadingEventArgs>> _contentLoadingEventDictionary =
                new Dictionary<long, Action<ContentLoadingEventArgs>>();

        /// <summary>
        /// Add an event handler for the ContentLoading event.
        /// ContentLoading fires before any content is loaded, including scripts added with
        /// AddScriptToExecuteOnDocumentCreated
        /// ContentLoading will not fire if a same page navigation occurs
        /// (such as through fragment navigations or history.pushState navigations).
        /// This follows the NavigationStarting and SourceChanged events and
        /// precedes the HistoryChanged and NavigationCompleted events.
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        public long RegisterContentLoading(Action<ContentLoadingEventArgs> callback)
        {
            ContentLoadingEventHandler completedHandler = new ContentLoadingEventHandler(callback);

            EventRegistrationToken token;
            _webview.add_ContentLoading(completedHandler, out token);
            _contentLoadingEventDictionary.Add(token.value, callback);
            return token.value;
        }

        /// <summary>
        /// Remove an event handler for ContentLoading eventg.
        /// </summary>
        /// <param name="token"></param>
        public void UnregisterContentLoading(long token)
        {
            if (_contentLoadingEventDictionary.ContainsKey(token))
            {
                _contentLoadingEventDictionary.Remove(token);
            }
            EventRegistrationToken registrationToken = new EventRegistrationToken();
            registrationToken.value = token;
            _webview.remove_ContentLoading(registrationToken);
        }

        private IDictionary<long, Action<SourceChangedEventArgs>> _sourceChangedEventDictionary =
                new Dictionary<long, Action<SourceChangedEventArgs>>();

        /// <summary>
        /// SourceChanged fires when the Source property changes.
        /// SourceChanged fires for navigating to a different site or fragment navigations.
        /// It will not fires for other types of navigations such as page reloads or
        /// history.pushState with the same URL as the current page.
        /// SourceChanged fires before ContentLoading for navigation to a new document.
        /// Add an event handler for the SourceChanged event.
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        public long RegisterSourceChanged(Action<SourceChangedEventArgs> callback)
        {
            SourceChangedEventHandler completedHandler = new SourceChangedEventHandler(callback);

            EventRegistrationToken token;
            _webview.add_SourceChanged(completedHandler, out token);
            _sourceChangedEventDictionary.Add(token.value, callback);
            return token.value;
        }

        /// <summary>
        /// Remove an event handler for SourceChanged event.
        /// </summary>
        /// <param name="token"></param>
        public void UnregisterSourceChanged(long token)
        {
            if (_sourceChangedEventDictionary.ContainsKey(token))
            {
                _sourceChangedEventDictionary.Remove(token);
            }
            EventRegistrationToken registrationToken = new EventRegistrationToken();
            registrationToken.value = token;
            _webview.remove_SourceChanged(registrationToken);
        }

        private IDictionary<long, Action<HistoryChangedEventArgs>> _historyChangedEventDictionary =
                new Dictionary<long, Action<HistoryChangedEventArgs>>();

        /// <summary>
        /// HistoryChange listen to the change of navigation history for the top level
        /// document. Use HistoryChange to check if get_CanGoBack/get_CanGoForward value
        /// has changed. HistoryChanged also fires for using GoBack/GoForward.
        /// HistoryChanged fires after SourceChanged and ContentLoading.
        /// Add an event handler for the HistoryChanged event.
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        public long RegisterHistoryChanged(Action<HistoryChangedEventArgs> callback)
        {
            HistoryChangedEventHandler completedHandler = new HistoryChangedEventHandler(callback);

            EventRegistrationToken token;
            _webview.add_HistoryChanged(completedHandler, out token);
            _historyChangedEventDictionary.Add(token.value, callback);
            return token.value;
        }

        /// <summary>
        /// Remove an event handler for HistoryChanged event.
        /// </summary>
        /// <param name="token"></param>
        public void UnregisterHistoryChanged(long token)
        {
            if (_historyChangedEventDictionary.ContainsKey(token))
            {
                _historyChangedEventDictionary.Remove(token);
            }
            EventRegistrationToken registrationToken = new EventRegistrationToken();
            registrationToken.value = token;
            _webview.remove_HistoryChanged(registrationToken);
        }

        private IDictionary<long, Action<NavigationCompletedEventArgs>> _navigationCompletedEventDictionary =
            new Dictionary<long, Action<NavigationCompletedEventArgs>>();

        /// <summary>
        /// Add an event handler for the NavigationCompleted event.
        /// NavigationCompleted event fires when the WebView has completely loaded
        /// (body.onload has fired) or loading stopped with error.
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        public long RegisterNavigationCompleted(Action<NavigationCompletedEventArgs> callback)
        {
            NavigationCompletedEventHandler completedHandler = new NavigationCompletedEventHandler(callback);

            EventRegistrationToken token;
            _webview.add_NavigationCompleted(completedHandler, out token);
            _navigationCompletedEventDictionary.Add(token.value, callback);
            return token.value;
        }

        /// <summary>
        /// Remove an event handler previously added with RegisterNavigationCompleted.
        /// </summary>
        /// <param name="token"></param>
        public void UnregisterNavigationCompleted(long token)
        {
            if (_navigationCompletedEventDictionary.ContainsKey(token))
            {
                _navigationCompletedEventDictionary.Remove(token);
            }
            EventRegistrationToken registrationToken = new EventRegistrationToken();
            registrationToken.value = token;
            _webview.remove_NavigationCompleted(registrationToken);
        }

        private IDictionary<long, Action<NavigationStartingEventArgs>> _frameNavigationStartingCallbacks =
            new Dictionary<long, Action<NavigationStartingEventArgs>>();

        /// <summary>
        /// Add an event handler for the FrameNavigationStarting event.
        /// FrameNavigationStarting fires when a child frame in the WebView
        /// requesting permission to navigate to a different URI. This will fire for
        /// redirects as well.
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        public long RegisterFrameNavigationStarting(Action<NavigationStartingEventArgs> callback)
        {
            NavigationStartingEventHandler completedHandler = new NavigationStartingEventHandler(callback);

            EventRegistrationToken token;
            _webview.add_FrameNavigationStarting(completedHandler, out token);
            _frameNavigationStartingCallbacks.Add(token.value, callback);
            return token.value;
        }

        /// <summary>
        /// Remove an event handler previously added with RegisterFrameNavigationStarting
        /// </summary>
        /// <param name="token"></param>
        public void UnregisterFrameNavigationStarting(long token)
        {
            _frameNavigationStartingCallbacks.Remove(token);

            EventRegistrationToken registrationToken = new EventRegistrationToken()
            {
                value = token
            };
            _webview.remove_FrameNavigationStarting(registrationToken);
        }

        private IDictionary<long, Action<ScriptDialogOpeningEventArgs>> _scriptDialogOpeningCallbacks =
            new Dictionary<long, Action<ScriptDialogOpeningEventArgs>>();

        /// <summary>
        /// Add an event handler for the ScriptDialogOpening event.
        /// The event fires when a JavaScript dialog (alert, confirm, or prompt) will
        /// show for the webview. This event only fires if the
        /// IWebView2Settings::AreDefaultScriptDialogsEnabled property is set to false.
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        public long RegisterScriptDialogOpening(Action<ScriptDialogOpeningEventArgs> callback)
        {
            ScriptDialogOpeningEventHandler completedHandler = new ScriptDialogOpeningEventHandler(callback);

            EventRegistrationToken token;
            _webview.add_ScriptDialogOpening(completedHandler, out token);
            _scriptDialogOpeningCallbacks.Add(token.value, callback);
            return token.value;
        }

        /// <summary>
        /// Remove an event handler previously added with RegisterScriptDialogOpening
        /// </summary>
        /// <param name="token"></param>
        public void UnregisterScriptDialogOpening(long token)
        {
            _scriptDialogOpeningCallbacks.Remove(token);

            EventRegistrationToken registrationToken = new EventRegistrationToken()
            {
                value = token
            };
            _webview.remove_ScriptDialogOpening(registrationToken);
        }

        private IDictionary<long, Action<PermissionRequestedEventArgs>> _permissionRequestedCallbacks =
            new Dictionary<long, Action<PermissionRequestedEventArgs>>();

        /// <summary>
        /// Add an event handler for the PermissionRequested event.
        /// Fires when content in a WebView requests permission to access some
        /// privileged resources.
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        public long RegisterPermissionRequested(Action<PermissionRequestedEventArgs> callback)
        {
            PermissionRequestedEventHandler completedHandler = new PermissionRequestedEventHandler(callback);

            EventRegistrationToken token;
            _webview.add_PermissionRequested(completedHandler, out token);
            _permissionRequestedCallbacks.Add(token.value, callback);
            return token.value;
        }

        /// <summary>
        /// Remove an event handler previously added with RegisterPermissionRequested
        /// </summary>
        /// <param name="token"></param>
        public void UnregisterPermissionRequested(long token)
        {
            _permissionRequestedCallbacks.Remove(token);

            EventRegistrationToken registrationToken = new EventRegistrationToken()
            {
                value = token
            };
            _webview.remove_PermissionRequested(registrationToken);
        }

        private IDictionary<long, Action<ProcessFailedEventArgs>> _processFailedCallbacks =
            new Dictionary<long, Action<ProcessFailedEventArgs>>();

        /// <summary>
        /// Add an event handler for the ProcessFailed event.
        /// Fires when a WebView process terminated unexpectedly or
        /// become unresponsive.
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        public long RegisterProcessFailed(Action<ProcessFailedEventArgs> callback)
        {
            ProcessFailedEventHandler completedHandler = new ProcessFailedEventHandler(callback);

            EventRegistrationToken token;
            _webview.add_ProcessFailed(completedHandler, out token);
            _processFailedCallbacks.Add(token.value, callback);
            return token.value;
        }

        /// <summary>
        /// Remove an event handler previously added with RegisterProcessFailed
        /// </summary>
        /// <param name="token"></param>
        public void UnregisterProcessFailed(long token)
        {
            _processFailedCallbacks.Remove(token);

            EventRegistrationToken registrationToken = new EventRegistrationToken()
            {
                value = token
            };
            _webview.remove_ProcessFailed(registrationToken);
        }

        /// <summary>
        /// Add the provided JavaScript to a list of scripts
        /// that should be executed after the global object has been created, but
        /// before the HTML document has been parsed and before any other script
        /// included by the HTML document is executed. The
        /// injected script will apply to all future top level document and child
        /// frame navigations until removed with RemoveScriptToExecuteOnDocumentCreated.
        /// This is applied asynchronously and you must wait for the completion
        /// handler to run before you can be sure that the script is ready to
        /// execute on future navigations.
        ///
        /// Note that if an HTML document has sandboxing of some kind via [sandbox](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/iframe#attr-sandbox)
        /// properties or the [Content-Security-Policy HTTP header](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy)
        /// this will affect the script run
        /// here. So, for example, if the 'allow-modals' keyword is not set then calls
        /// to the `alert` function will be ignored.
        /// </summary>
        /// <param name="javaScript"></param>
        /// <param name="callback"></param>
        public void AddScriptToExecuteOnDocumentCreated(string javaScript, Action<AddScriptToExecuteOnDocumentCreatedCompletedEventArgs> callback)
        {
            AddScriptToExecuteOnDocumentCreatedCompletedHandler completedHandler = new AddScriptToExecuteOnDocumentCreatedCompletedHandler(callback);

            _webview.AddScriptToExecuteOnDocumentCreated(javaScript, completedHandler);
        }

        /// <summary>
        /// Remove the corresponding JavaScript added via AddScriptToExecuteOnDocumentCreated
        /// </summary>
        /// <param name="id"></param>
        public void RemoveScriptToExecuteOnDocumentCreated(string id)
        {
            _webview.RemoveScriptToExecuteOnDocumentCreated(id);
        }

        /// <summary>
        /// Execute JavaScript code from the javascript parameter in the
        /// current top level document rendered in the WebView. This will execute
        /// asynchronously and when complete, if a handler is provided in the
        /// ExecuteScriptCompletedHandler parameter, its Invoke method will be
        /// called with the result of evaluating the provided JavaScript. The result
        /// value is a JSON encoded string.
        /// If the result is undefined, contains a reference cycle, or otherwise
        /// cannot be encoded into JSON, the JSON null value will be returned as the
        /// string 'null'. Note that a function that has no explicit return value
        /// returns undefined.
        /// If the executed script throws an unhandled exception, then the result is
        /// also 'null'.
        /// This method is applied asynchronously. If the call is made while the
        /// webview is on one document, and a navigation occurs after the call is
        /// made but before the JavaScript is executed, then the script will not be
        /// executed and the handler will be called with E_FAIL for its errorCode
        /// parameter.
        /// ExecuteScript will work even if IsScriptEnabled is set to FALSE.
        /// </summary>
        /// <param name="javaScript"></param>
        /// <param name="callback"></param>
        public void ExecuteScript(string javaScript, Action<ExecuteScriptCompletedEventArgs> callback)
        {
            ExecuteScriptCompletedHandler callbackHandler = null;
            if (callback != null)
            {
                callbackHandler = new ExecuteScriptCompletedHandler(callback);
            }
            _webview.ExecuteScript(javaScript, callbackHandler);
        }

        /// <summary>
        /// Capture an image of what WebView is displaying. Specify the
        /// format of the image with the imageFormat parameter.
        /// The resulting image binary data is written to the provided imageStream
        /// parameter. When CapturePreview finishes writing to the stream, the Invoke
        /// method on the provided handler parameter is called.
        /// </summary>
        /// <param name="imageFormat"></param>
        /// <param name="imageStream"></param>
        /// <param name="handler"></param>
        public void CapturePreview(WEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, Stream imageStream, Action<CapturePreviewCompletedArgs> callback)
        {
            ManagedIStream stream = new ManagedIStream(imageStream);
            CapturePreviewCompletedHandler callbackHandler = new CapturePreviewCompletedHandler(callback);
            _webview.CapturePreview(imageFormat, stream, callbackHandler);
        }

        /// <summary>
        /// Reload the current page. This is similar to navigating to the URI of
        /// current top level document including all navigation events firing and
        /// respecting any entries in the HTTP cache. But, the back/forward history
        /// will not be modified.
        /// </summary>
        public void Reload()
        {
            _webview.Reload();
        }

        /// <summary>
        /// Post the specified webMessage to the top level document in this
        /// IWebView2WebView. The top level document's window.chrome.webview's message
        /// event fires. JavaScript in that document may subscribe and unsubscribe to
        /// the event via the following:
        /// ```
        ///    window.chrome.webview.addEventListener('message', handler)
        ///    window.chrome.webview.removeEventListener('message', handler)
        /// ```
        /// The event args is an instance of `MessageEvent`.
        /// The IWebView2Settings::IsWebMessageEnabled setting must be true or this method
        /// will fail with E_INVALIDARG.
        /// The event arg's data property is the webMessage string parameter parsed
        /// as a JSON string into a JavaScript object.
        /// The event arg's source property is a reference to the
        /// `window.chrome.webview` object.
        /// See SetWebMessageReceivedEventHandler for information on sending messages
        /// from the HTML document in the webview to the host.
        /// This message is sent asynchronously. If a navigation occurs before the
        /// message is posted to the page, then the message will not be sent.
        /// </summary>
        /// <param name="webMessageAsJson"></param>
        public void PostWebMessageAsJson(string webMessageAsJson)
        {
            _webview.PostWebMessageAsJson(webMessageAsJson);
        }

        /// <summary>
        /// This is a helper for posting a message that is a simple string
        /// rather than a JSON string representation of a JavaScript object. This
        /// behaves in exactly the same manner as PostWebMessageAsJson but the
        /// `window.chrome.webview` message event arg's data property will be a string
        /// with the same value as webMessageAsString. Use this instead of
        /// PostWebMessageAsJson if you want to communicate via simple strings rather
        /// than JSON objects.
        /// </summary>
        /// <param name="webMessageAsString"></param>
        public void PostWebMessageAsString(string webMessageAsString)
        {
            _webview.PostWebMessageAsString(webMessageAsString);
        }

        private IDictionary<long, Action<WebMessageReceivedEventArgs>> _webMessageReceivedEventDictionary =
            new Dictionary<long, Action<WebMessageReceivedEventArgs>>();

        /// <summary>
        /// This event fires when the IsWebMessageEnabled setting is set and the top
        /// level document of the webview calls `window.chrome.webview.postMessage`.
        /// The postMessage function is `void postMessage(object)` where
        /// object is any object supported by JSON conversion.
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        public long RegisterWebMessageReceived(Action<WebMessageReceivedEventArgs> callback)
        {
            WebMessageReceivedEventHandler completedHandler = new WebMessageReceivedEventHandler(callback);

            EventRegistrationToken token;
            _webview.add_WebMessageReceived(completedHandler, out token);
            _webMessageReceivedEventDictionary.Add(token.value, callback);
            return token.value;
        }

        /// <summary>
        /// Remove an event handler previously added with RegisterWebMessageReceived
        /// </summary>
        /// <param name="token"></param>
        public void UnregisterWebMessageReceived(long token)
        {
            if (_webMessageReceivedEventDictionary.ContainsKey(token))
            {
                _webMessageReceivedEventDictionary.Remove(token);
            }
            EventRegistrationToken registrationToken = new EventRegistrationToken();
            registrationToken.value = token;
            _webview.remove_WebMessageReceived(registrationToken);
        }

        /// <summary>
        /// Call an asynchronous DevToolsProtocol method. See the
        /// [DevTools Protocol Viewer](https://aka.ms/DevToolsProtocolDocs)
        /// for a list and description of available methods.
        /// The methodName parameter is the full name of the method in the format
        /// `{domain}.{method}`.
        /// The parametersAsJson parameter is a JSON formatted string containing
        /// the parameters for the corresponding method.
        /// The handler's Invoke method will be called when the method asynchronously
        /// completes. Invoke will be called with the method's return object as a
        /// JSON string.
        /// </summary>
        /// <param name="methodName"></param>
        /// <param name="parametersAsJson"></param>
        public void CallDevToolsProtocolMethod(string methodName, string parametersAsJson)
        {
            _webview.CallDevToolsProtocolMethod(methodName, parametersAsJson, null);
        }

        public void CallDevToolsProtocolMethod(string methodName, string parametersAsJson, Action<CallDevToolsProtocolMethodCompletedEventArgs> callback)
        {
            CallDevToolsProtocolMethodCompletedHandler callbackHandler = null;
            if (callback != null)
            {
                callbackHandler = new CallDevToolsProtocolMethodCompletedHandler(methodName, callback);
            }
            _webview.CallDevToolsProtocolMethod(methodName, parametersAsJson, callbackHandler);
        }

        /// <summary>
        /// The process id of the browser process that hosts the WebView.
        /// </summary>
        public uint BrowserProcessId
        {
            get
            {
                return _webview.BrowserProcessId;
            }
        }

        /// <summary>
        /// Can navigate the webview to the previous page in the navigation history.
        /// get_CanGoBack change value with the DocumentStateChanged event.
        /// </summary>
        public bool CanGoBack
        {
            get => _webview.CanGoBack;
        }

        /// <summary>
        /// Can navigate the webview to the next page in the navigation history.
        /// get_CanGoForward change value with the DocumentStateChanged event.
        /// </summary>
        public bool CanGoForward
        {
            get => _webview.CanGoForward;
        }

        /// <summary>
        /// Navigates the webview to the previous page in the navigation history.
        /// </summary>
        public void GoBack()
        {
            _webview.GoBack();
        }

        /// <summary>
        /// Navigates the webview to the next page in the navigation history.
        /// </summary>
        public void GoForward()
        {
            _webview.GoForward();
        }

        private IDictionary<long, DevToolProtocol> _devToolsProtocolCallbacks =
            new Dictionary<long, DevToolProtocol>();

        /// <summary>
        /// Subscribe to a DevToolsProtocol event. See the
        /// [DevTools Protocol Viewer](https://aka.ms/DevToolsProtocolDocs)
        /// for a list and description of available events.
        /// The eventName parameter is the full name of the event in the format
        /// `{domain}.{event}`.
        /// The handler's Invoke method will be called whenever the corresponding
        /// DevToolsProtocol event fires. Invoke will be called with the
        /// an event args object containing the CDP event's parameter object as a JSON
        /// string.
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public WebView2DevToolsProtocolEventReceiver GetDevToolsProtocolEventReceiver(string eventName)
        {
            ICoreWebView2DevToolsProtocolEventReceiver reciever = null;
            _webview.GetDevToolsProtocolEventReceiver(eventName, out reciever);
            return new WebView2DevToolsProtocolEventReceiver(eventName, reciever);
        }

        /// <summary>
        /// Stop all navigations and pending resource fetches
        /// </summary>
        public void Stop()
        {
            _webview.Stop();
        }

        private IDictionary<long, Action<NewWindowRequestedEventArgs>> _newWindowRequestedEventDictionary =
    new Dictionary<long, Action<NewWindowRequestedEventArgs>>();

        /// <summary>
        /// Add an event handler for the NewWindowRequested event.
        /// Fires when content inside the WebView requested to open a new window,
        /// such as through window.open. The app can pass a target
        /// webview that will be considered the opened window. 
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        public long RegisterNewWindowRequested(Action<NewWindowRequestedEventArgs> callback)
        {
            NewWindowRequestedEventHandler completedHandler = new NewWindowRequestedEventHandler(callback);

            EventRegistrationToken token;
            _webview.add_NewWindowRequested(completedHandler, out token);
            _newWindowRequestedEventDictionary.Add(token.value, callback);
            return token.value;
        }

        /// <summary>
        /// Remove an event handler previously added with RegisterNewWindowRequested
        /// </summary>
        /// <param name="token"></param>
        public void UnregisterNewWindowRequested(long token)
        {
            _newWindowRequestedEventDictionary.Remove(token);

            EventRegistrationToken registrationToken = new EventRegistrationToken()
            {
                value = token
            };
            _webview.remove_NewWindowRequested(registrationToken);
        }

        private IDictionary<long, Action<DocumentTitleChangedEventArgs>> _titleChangedEventDictionary =
            new Dictionary<long, Action<DocumentTitleChangedEventArgs>>();

        /// <summary>
        /// Add an event handler for the DocumentTitleChanged event.
        /// The event fires when the DocumentTitle property of the WebView changes
        /// and may fire before or after the NavigationCompleted event.
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        public long RegisterDocumentTitledChanged(Action<DocumentTitleChangedEventArgs> callback)
        {
            DocumentTitleChangedEventHandler completedHandler = new DocumentTitleChangedEventHandler(callback);

            EventRegistrationToken token;
            _webview.add_DocumentTitleChanged(completedHandler, out token);
            _titleChangedEventDictionary.Add(token.value, callback);
            return token.value;
        }

        /// <summary>
        /// Remove an event handler previously added with RegisterDocumentTitledChanged
        /// </summary>
        /// <param name="token"></param>
        public void UnregisterDocumentTitledChanged(long token)
        {
            _titleChangedEventDictionary.Remove(token);

            EventRegistrationToken registrationToken = new EventRegistrationToken()
            {
                value = token
            };
            _webview.remove_DocumentTitleChanged(registrationToken);
        }

        /// <summary>
        /// The title for the current top level document.
        /// If the document has no explicit title or is otherwise empty, then the URI
        /// of the top level document is used.
        /// </summary>
        public string DocumentTitle
        {
            get
            {
                string documentTitle;
                _webview.DocumentTitle(out documentTitle);
                return documentTitle;
            }
        }

        public void AddRemoteObject(string name, ref object remoteObject)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");

            // Check if the remote object supports IDispatch
            try
            {
                // Make sure this guy has an IDispatch
                IntPtr pdisp = Marshal.GetIDispatchForObject(remoteObject);

                // If we got here without throwing an exception, the QI for IDispatch succeeded.
                Marshal.Release(pdisp);
            }
            catch (Exception ex)
            {
                throw new InvalidComObjectException("The remote object doesn't support IDispatch interface.", ex);
            }
            _webview.AddRemoteObject(name, ref remoteObject);
        }

        /// Remove the host object specified by the name so that it is no longer
        /// accessible from JavaScript code in the WebView.
        /// While new access attempts will be denied, if the object is already
        /// obtained by JavaScript code in the WebView, the JavaScript code will
        /// continue to have access to that object.
        /// Calling this method for a name that is already removed or never added will
        /// fail.
        public void RemoveRemoteObject(string name)
        {
            _webview.RemoveRemoteObject(name);
        }

        /// Opens the DevTools window for the current document in the WebView.
        /// Does nothing if called when the DevTools window is already open
        public void OpenDevToolsWindow()
        {
            _webview.OpenDevToolsWindow();
        }

        private IDictionary<long, Action<ContainsFullScreenElementChangedEventArgs>> _containsFullScreenElementChangedDictionary =
            new Dictionary<long, Action<ContainsFullScreenElementChangedEventArgs>>();

        /// <summary>
        /// Notifies when the ContainsFullScreenElement property changes. This means
        /// that an HTML element inside the WebView is entering fullscreen to the size
        /// of the WebView or leaving fullscreen.
        /// This event is useful when, for example, a video element requests to go
        /// fullscreen. The listener of ContainsFullScreenElementChanged can then
        /// resize the WebView in response.
        /// </summary>
        /// <param name="callback"></param>
        public long RegisterContainsFullScreenElementChanged(Action<ContainsFullScreenElementChangedEventArgs> callback)
        {
            ContainsFullScreenElementChangedEventHandler completedHandler = new ContainsFullScreenElementChangedEventHandler(callback);

            EventRegistrationToken token;
            _webview.add_ContainsFullScreenElementChanged(completedHandler, out token);
            _containsFullScreenElementChangedDictionary.Add(token.value, callback);
            return token.value;
        }

        /// <summary>
        /// Remove an event handler previously added with RegisterContainsFullScreenElementChanged.
        /// </summary>
        /// <param name="token"></param>
        public void UnRegisterContainsFullScreenElementChanged(long token)
        {
            _containsFullScreenElementChangedDictionary.Remove(token);

            EventRegistrationToken registrationToken = new EventRegistrationToken()
            {
                value = token
            };
            _webview.remove_ContainsFullScreenElementChanged(registrationToken);
        }

        public bool ContainsFullScreenElement
        {
            get => _webview.ContainsFullScreenElement;
        }
        private IDictionary<long, Action<WebResourceRequestedEventArgs>> _webResourceRequestedEventDictionary =
            new Dictionary<long, Action<WebResourceRequestedEventArgs>>();

        /// <summary>
        /// Add an event handler for the WebResourceRequested event.
        /// Fires when the WebView has performs any HTTP request.
        /// Use urlFilter to pass in a list with size filterLength of urls to listen
        /// for. Each url entry also supports wildcards: '*' matches zero or more
        /// characters, and '?' matches exactly one character. For each urlFilter
        /// entry, provide a matching resourceContextFilter as a bit vector
        /// representing the types of resources for which WebResourceRequested should
        /// fire.
        /// If filterLength is 0, the event will fire for all network requests.
        /// The supported resource contexts are:
        /// Document, Stylesheet, Image, Media, Font, Script, XHR, Fetch.
        /// </summary>
        /// <param name="urlFilter"></param>
        /// <param name="resourceContextFilter"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public long RegisterWebResourceRequested(Action<WebResourceRequestedEventArgs> callback)
        {
            WebResourceRequestedEventHandler completedHandler = new WebResourceRequestedEventHandler(callback);

            EventRegistrationToken token;
            _webview.add_WebResourceRequested(completedHandler, out token);
            _webResourceRequestedEventDictionary.Add(token.value, callback);
            return token.value;
        }

        /// <summary>
        /// Remove an event handler previously added with RegisterWebResourceRequested
        /// </summary>
        /// <param name="token"></param>
        public void UnregisterWebResourceRequested(long token)
        {
            _webResourceRequestedEventDictionary.Remove(token);
            EventRegistrationToken registrationToken = new EventRegistrationToken();
            registrationToken.value = token;
            _webview.remove_WebResourceRequested(registrationToken);
        }

        /// <summary>
        /// Adds a URI and resource context filter to the WebResourceRequested event.
        /// URI parameter can be a wildcard string ('': zero or more, '?': exactly one). 
        /// nullptr is equivalent to L"".
        /// See WEBVIEW2_WEB_RESOURCE_CONTEXT enum for description of resource context filters.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="resourceContext"></param>
        public void AddWebResourceRequestedFilter(string uri, WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContext)
        {
            _webview.AddWebResourceRequestedFilter(uri, resourceContext);
        }

        /// <summary>
        /// Removes a matching WebResource filter that was previously added for the 
        /// WebResourceRequested event. If the same filter was added multiple times, then it
        /// will need to be removed as many times as it was added for the removal to be
        /// effective. Returns E_INVALIDARG for a filter that was never added.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="resourceContext"></param>
        public void RemoveWebResourceRequestedFilter(string uri, WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContext)
        {
            _webview.RemoveWebResourceRequestedFilter(uri, resourceContext);
        }

        private IDictionary<long, Action<WindowCloseRequestedEventArgs>> _windowCloseRequestedDictionary =
            new Dictionary<long, Action<WindowCloseRequestedEventArgs>>();

        /// <summary>
        /// Add an event handler for the WindowCloseRequested event.
        /// Fires when content inside the WebView requested to close the window,
        /// such as after window.close is called. The app should close the WebView
        /// and related app window if that makes sense to the app.
        /// </summary>
        /// <param name="callback"></param>
        public long RegisterWindowCloseRequested(Action<WindowCloseRequestedEventArgs> callback)
        {
            WindowCloseRequestedEventHandler completedHandler = new WindowCloseRequestedEventHandler(callback);

            EventRegistrationToken token;
            _webview.add_WindowCloseRequested(completedHandler, out token);
            _windowCloseRequestedDictionary.Add(token.value, callback);
            return token.value;
        }

        /// <summary>
        /// Remove an event handler previously added with RegisterWindowCloseRequested.
        /// </summary>
        /// <param name="token"></param>
        public void UnRegisterWindowCloseRequested(long token)
        {
            _windowCloseRequestedDictionary.Remove(token);

            EventRegistrationToken registrationToken = new EventRegistrationToken()
            {
                value = token
            };
            _webview.remove_WindowCloseRequested(registrationToken);
        }

        #endregion

        /// This interface is the owner of the CoreWebView2 object, and provides support
        /// for resizing, showing and hiding, focusing, and other functionality related
        /// to windowing and composition. The CoreWebView2Host owns the CoreWebView2,
        /// and if all references to the CoreWebView2Host go away, the WebView will
        /// be closed.
        #region ICoreWebView2Host

        /// <summary>
        /// The IsVisible property determines whether to show or hide the webview.
        /// If IsVisible is set to false, the webview will be transparent and will
        /// not be rendered.  However, this will not affect the window containing
        /// the webview (the HWND parameter that was passed to CreateWebView).
        /// If you want that window to disappear too, call ShowWindow on it directly
        /// in addition to modifying the IsVisible property.
        /// WebView as a child window won't get window messages when the top window
        /// is minimized or restored. For performance reason, developer should set
        /// IsVisible property of the WebView to false when the app window is
        /// minimized and back to true when app window is restored. App window can do
        /// this by handling SC_MINIMIZE and SC_RESTORE command upon receiving
        /// WM_SYSCOMMAND message.
        /// </summary>
        public bool IsVisible
        {
            get => _webviewHost.IsVisible;
            set => _webviewHost.IsVisible = value;
        }

        /// <summary>
        /// The webview bounds.
        /// Bounds are relative to the parent HWND. The app has two ways it can
        /// position a WebView:
        /// 1. Create a child HWND that is the WebView parent HWND. Position this
        ///    window where the WebView should be. In this case, use (0, 0) for the
        ///    WebView's Bound's top left corner (the offset).
        /// 2. Use the app's top most window as the WebView parent HWND. Set the
        ///    WebView's Bound's top left corner so that the WebView is positioned
        ///    correctly in the app.
        /// The Bound's values are in the host's coordinate space.
        /// </summary>
        public Rectangle Bounds
        {
            get
            {
                tagRECT rect = _webviewHost.Bounds;
                return new Rectangle(rect.left, rect.top, (rect.right - rect.left), (rect.bottom - rect.top));
            }
            set
            {
                tagRECT rect = new tagRECT();
                rect.top = value.Top;
                rect.left = value.Left;
                rect.right = value.Right;
                rect.bottom = value.Bottom;
                _webviewHost.Bounds = rect;
            }
        }

        /// <summary>
        /// The zoom factor for the current page in the WebView.
        /// The zoom factor is persisted per site.
        /// Note that changing zoom factor could cause `window.innerWidth/innerHeight`
        /// and page layout to change.
        /// When WebView navigates to a page from a different site,
        /// the zoom factor set for the previous page will not be applied.
        /// If the app wants to set the zoom factor for a certain page, the earliest
        /// place to do it is in the DocumentStateChanged event handler. Note that if it
        /// does that, it might receive a ZoomFactorChanged event for the persisted
        /// zoom factor before receiving the ZoomFactorChanged event for the specified
        /// zoom factor.
        /// Specifying a zoomFactor less than or equal to 0 is not allowed.
        /// WebView also has an internal supported zoom factor range. When a specified
        /// zoom factor is out of that range, it will be normalized to be within the
        /// range, and a ZoomFactorChanged event will be fired for the real
        /// applied zoom factor. When this range normalization happens, the
        /// ZoomFactor property will report the zoom factor specified during the
        /// previous modification of the ZoomFactor property until the
        /// ZoomFactorChanged event is received after webview applies the normalized
        /// zoom factor.
        /// </summary>
        public double ZoomFactor
        {
            get
            {
                return _webviewHost.ZoomFactor;
            }
            set
            {
                _webviewHost.ZoomFactor = value;
            }
        }

        private IDictionary<long, Action<ZoomFactorCompletedEventArgs>> _zoomFactorChangedEventDictionary =
            new Dictionary<long, Action<ZoomFactorCompletedEventArgs>>();

        /// <summary>
        /// Add an event handler for the ZoomFactorChanged event.
        /// The event fires when the ZoomFactor property of the WebView changes.
        /// The event could fire because the caller modified the ZoomFactor property,
        /// or due to the user manually modifying the zoom. When it is modified by the
        /// caller via the ZoomFactor property, the internal zoom factor is updated
        /// immediately and there will be no ZoomFactorChanged event.
        /// WebView associates the last used zoom factor for each site. Therefore, it
        /// is possible for the zoom factor to change when navigating to a different
        /// page. When the zoom factor changes due to this, the ZoomFactorChanged
        /// event fires right after the DocumentStateChanged event.
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        public long RegisterZoomFactorChanged(Action<ZoomFactorCompletedEventArgs> callback)
        {
            ZoomFactorChangedEventHandler completedHandler = new ZoomFactorChangedEventHandler(callback);

            EventRegistrationToken token;
            _webviewHost.add_ZoomFactorChanged(completedHandler, out token);
            _zoomFactorChangedEventDictionary.Add(token.value, callback);
            return token.value;
        }

        /// <summary>
        /// Remove an event handler previously added with RegisterZoomFactorChanged
        /// </summary>
        /// <param name="token"></param>
        public void UnregisterZoomFactorChanged(long token)
        {
            if (_zoomFactorChangedEventDictionary.ContainsKey(token))
            {
                _zoomFactorChangedEventDictionary.Remove(token);
            }
            EventRegistrationToken registrationToken = new EventRegistrationToken();
            registrationToken.value = token;
            _webviewHost.remove_ZoomFactorChanged(registrationToken);
        }

        /// Update Bounds and ZoomFactor properties at the same time. This operation
        /// is atomic from the host's perspecive. After returning from this function,
        /// the Bounds and ZoomFactor properties will have both been updated if the
        /// function is successful, or neither will be updated if the function fails.
        /// If Bounds and ZoomFactor are both updated by the same scale (i.e. Bounds
        /// and ZoomFactor are both doubled), then the page will not see a change in
        /// window.innerWidth/innerHeight and the WebView will render the content at
        /// the new size and zoom without intermediate renderings.
        /// This function can also be used to update just one of ZoomFactor or Bounds
        /// by passing in the new value for one and the current value for the other.
        ///
        /// \snippet ViewComponent.cpp SetBoundsAndZoomFactor
        public void SetBoundsAndZoomFactor(Rectangle bounds, double zoomFactor)
        {
            tagRECT rect = new tagRECT();
            rect.top = bounds.Top;
            rect.left = bounds.Left;
            rect.right = bounds.Right;
            rect.bottom = bounds.Bottom;
            _webviewHost.SetBoundsAndZoomFactor(rect, zoomFactor);
        }

        /// <summary>
        /// ove focus into WebView. WebView will get focus and focus will be set to
        /// correspondent element in the page hosted in the WebView.
        /// </summary>
        /// <param name="reason"></param>
        public void MoveFocus(WEBVIEW2_MOVE_FOCUS_REASON reason)
        {
            _webviewHost.MoveFocus(reason);
        }

        private IDictionary<long, Action<MoveFocusRequestedEventArgs>> _moveFocusRequestedDictionary =
            new Dictionary<long, Action<MoveFocusRequestedEventArgs>>();

        /// <summary>
        /// Add an event handler for the MoveFocusRequested event.
        /// MoveFocusRequested fires when user tries to tab out of the WebView.
        /// The WebView's focus has not changed when this event is fired.
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        public long RegisterMoveFocusRequested(Action<MoveFocusRequestedEventArgs> callback)
        {
            MoveFocusRequestedEventHandler completedHandler = new MoveFocusRequestedEventHandler(callback);

            EventRegistrationToken token;
            _webviewHost.add_MoveFocusRequested(completedHandler, out token);
            _moveFocusRequestedDictionary.Add(token.value, callback);
            return token.value;
        }

        /// <summary>
        /// Remove an event handler previously added with RegisterMoveFocusRequested
        /// </summary>
        /// <param name="token"></param>
        public void UnregisterMoveFocusRequested(long token)
        {
            if (_moveFocusRequestedDictionary.ContainsKey(token))
            {
                _moveFocusRequestedDictionary.Remove(token);
            }
            EventRegistrationToken registrationToken = new EventRegistrationToken();
            registrationToken.value = token;
            _webviewHost.remove_MoveFocusRequested(registrationToken);
        }

        private IDictionary<long, Action<FocusChangedEventEventArgs>> _gotFocusCallbacks =
            new Dictionary<long, Action<FocusChangedEventEventArgs>>();

        /// <summary>
        /// Add an event handler for the GotFocus event.
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        public long RegisterGotFocus(Action<FocusChangedEventEventArgs> callback)
        {
            FocusChangedEventHandler completedHandler = new FocusChangedEventHandler(callback);

            EventRegistrationToken token;
            _webviewHost.add_GotFocus(completedHandler, out token);
            _gotFocusCallbacks.Add(token.value, callback);
            return token.value;
        }

        /// <summary>
        /// Remove an event handler previously added with RegisterGotFocusdEvent
        /// </summary>
        /// <param name="token"></param>
        public void UnregisterGotFocus(long token)
        {
            _frameNavigationStartingCallbacks.Remove(token);

            EventRegistrationToken registrationToken = new EventRegistrationToken()
            {
                value = token
            };
            _webviewHost.remove_GotFocus(registrationToken);
        }

        private IDictionary<long, Action<FocusChangedEventEventArgs>> _lostFocusEventDictionary =
            new Dictionary<long, Action<FocusChangedEventEventArgs>>();

        /// <summary>
        /// Add an event handler for the LostFocus event.
        /// LostFocus fires when WebView lost focus.
        /// In the case where MoveFocusRequested event is fired, the focus is still
        /// on WebView when MoveFocusRequested event fires. Lost focus only fires
        /// afterwards when app's code or default action of MoveFocusRequested event
        /// set focus away from WebView.
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        public long RegisterLostFocus(Action<FocusChangedEventEventArgs> callback)
        {
            FocusChangedEventHandler completedHandler = new FocusChangedEventHandler(callback);

            EventRegistrationToken token;
            _webviewHost.add_LostFocus(completedHandler, out token);
            _lostFocusEventDictionary.Add(token.value, callback);
            return token.value;
        }

        /// <summary>
        /// Remove an event handler previously added with RegisterLostFocus
        /// </summary>
        /// <param name="token"></param>
        public void UnregisterLostFocus(long token)
        {
            if (_lostFocusEventDictionary.ContainsKey(token))
            {
                _lostFocusEventDictionary.Remove(token);
            }
            EventRegistrationToken registrationToken = new EventRegistrationToken();
            registrationToken.value = token;
            _webviewHost.remove_LostFocus(registrationToken);
        }

        private IDictionary<long, Action<AcceleratorKeyPressedEventArgs>> _acceleratorKeyPressedDictionary =
            new Dictionary<long, Action<AcceleratorKeyPressedEventArgs>>();

        /// <summary>
        /// Add an event handler for the AcceleratorKeyPressed event.
        /// AcceleratorKeyPressed fires when an accelerator key or key combo is
        /// pressed or released while the WebView is focused. A key is considered an
        /// accelerator if either:
        ///   1. Ctrl or Alt is currently being held, or
        ///   2. the pressed key does not map to a character.
        /// A few specific keys are never considered accelerators, such as Shift.
        /// The Escape key is always considered an accelerator.
        ///
        /// Autorepeated key events caused by holding the key down will also fire this
        /// event.  You can filter these out by checking the event args'
        /// KeyEventLParam or PhysicalKeyStatus.
        ///
        /// In windowed mode, this event handler is called synchronously. Until you
        /// call Handle() on the event args or the event handler returns, the browser
        /// process will be blocked and outgoing cross-process COM calls will fail
        /// with RPC_E_CANTCALLOUT_ININPUTSYNCCALL. All WebView2 API methods will
        /// work, however.
        ///
        /// In windowless mode, the event handler is called asynchronously.  Further
        /// input will not reach the browser until the event handler returns or
        /// Handle() is called, but the browser process itself will not be blocked,
        /// and outgoing COM calls will work normally.
        ///
        /// It is recommended to call Handle(TRUE) as early as you can know that you want
        /// to handle the accelerator key.
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        public long RegisterAcceleratorKeyPressed(Action<AcceleratorKeyPressedEventArgs> callback)
        {
            AcceleratorKeyPressedEventHandler completedHandler = new AcceleratorKeyPressedEventHandler(callback);

            EventRegistrationToken token;
            _webviewHost.add_AcceleratorKeyPressed(completedHandler, out token);
            _acceleratorKeyPressedDictionary.Add(token.value, callback);
            return token.value;
        }

        /// <summary>
        /// Remove an event handler previously added with RegisterAcceleratorKeyPressed
        /// </summary>
        /// <param name="token"></param>
        public void UnregisterAcceleratorKeyPressed(long token)
        {
            _acceleratorKeyPressedDictionary.Remove(token);

            EventRegistrationToken registrationToken = new EventRegistrationToken()
            {
                value = token
            };
            _webviewHost.remove_AcceleratorKeyPressed(registrationToken);
        }

        /// <summary>
        /// The parent window provided by the app that this WebView is using to
        /// render content. This API initially returns the window passed into
        /// CreateCoreWebView2Host.
        /// </summary>
        public IntPtr ParentWindow
        {
            get => _webviewHost.ParentWindow;
            set => _webviewHost.ParentWindow = value;
        }

        /// <summary>
        /// This is a notification separate from put_Bounds that tells WebView its
        /// parent (or any ancestor) HWND moved. This is needed for accessibility and
        /// certain dialogs in WebView to work correctly.
        /// </summary>
        public void NotifyParentWindowPositionChanged()
        {
            _webviewHost.NotifyParentWindowPositionChanged();
        }

        /// <summary>
        /// Closes the webview and cleans up the underlying browser instance.
        /// Cleaning up the browser instace will release the resources powering the webview.
        /// The browser instance will be shut down if there are no other webviews using it.
        ///
        /// After calling Close, all method calls will fail and event handlers
        /// will stop firing. Specifically, the WebView will release its references
        /// to its event handlers when Close is called.
        /// </summary>
        public void Close()
        {
            _webviewHost.Close();
        }

        #endregion
    }
}
