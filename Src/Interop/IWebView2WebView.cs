using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{    /// <summary>
     /// Checked
     /// </summary>
    [ComVisible(true),
     ComImport,
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
     Guid("76711B9E-8D56-4806-8485-35250BB2384F")]
    public interface IWebView2WebView
    {
        /// <summary>
        /// The IWebView2Settings object contains various modifiable settings for
        /// the running WebView.
        /// </summary>
        [DispId(1610678272)]
        IWebView2Settings Settings { get; }

        /// <summary>
        /// The URI of the current top level document. This value potentially
        /// changes as a part of the DocumentStateChanged event firing for some cases
        /// such as navigating to a different site or fragment navigations. It will
        /// remain the same for other types of navigations such as page reloads or
        /// history.pushState with the same URL as the current page.
        /// </summary>
        [DispId(1610678273)]
        string Source
        {
            [return: MarshalAs(UnmanagedType.LPWStr)]
            get;
        }

        /// <summary>
        /// Cause a navigation of the top level document to the specified URI. See
        /// the navigation events for more information. Note that this starts a
        /// navigation and the corresponding NavigationStarting event will fire
        /// sometime after this Navigate call completes.
        /// </summary>
        /// <param name="uri"></param>
        void Navigate([In, MarshalAs(UnmanagedType.LPWStr)]string uri);

        /// <summary>
        /// Move focus into WebView. WebView will get focus and focus will be set to
        /// correspondent element in the page hosted in the WebView.
        /// For Programmatic reason, focus is set to previously focused element or
        /// the default element if there is no previously focused element.
        /// For Next reason, focus is set to the first element.
        /// For Previous reason, focus is set to the last element.
        /// WebView can also got focus through user interaction like clicking into
        /// WebView or Tab into it.
        /// For tabbing, the app can call MoveFocus with Next or Previous to align
        /// with tab and shift+tab respectively when it decides the WebView is the
        /// next tabbable element. Or, the app can call IsDialogMessage as part of
        /// its message loop to allow the platform to auto handle tabbing. The
        /// platform will rotate through all windows with WS_TABSTOP. When the
        /// WebView gets focus from IsDialogMessage, it will internally put the focus
        /// on the first or last element for tab and shift+tab respectively.
        /// </summary>
        /// <param name="reason"></param>
        void MoveFocus(WEBVIEW2_MOVE_FOCUS_REASON reason);

        /// <summary>
        /// Initiates a navigation to htmlContent as source HTML of a new
        /// document. The htmlContent parameter may not be larger than 2 MB of
        /// characters. The origin of the new page will be about:blank.
        /// </summary>
        /// <param name="htmlContent"></param>
        void NavigateToString([In, MarshalAs(UnmanagedType.LPWStr)]string htmlContent);

        /// <summary>
        /// Add an event handler for the NavigationStarting event.
        /// NavigationStarting fires when the WebView main frame is
        /// requesting permission to navigate to a different URI. This will fire for
        /// redirects as well.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        void add_NavigationStarting([In] IWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token);

        /// <summary>
        /// Remove an event handler previously added with add_NavigationStarting.
        /// </summary>
        /// <param name="token"></param>
        void remove_NavigationStarting([In] EventRegistrationToken token);

        /// <summary>
        /// Add an event handler for the DocumentStateChanged event.
        /// DocumentStateChanged fires when new content has started loading
        /// on the webview's main frame or if a same page navigation occurs (such as
        /// through fragment navigations or history.pushState navigations).
        /// This follows the NavigationStarting event and precedes the
        /// NavigationCompleted event.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        void add_DocumentStateChanged([In] IWebView2DocumentStateChangedEventHandler eventHandler, out EventRegistrationToken token);

        /// <summary>
        /// Remove an event handler previously added with add_DocumentStateChanged.
        /// </summary>
        /// <param name="token"></param>
        void remove_DocumentStateChanged([In] EventRegistrationToken token);

        /// <summary>
        /// Add an event handler for the NavigationCompleted event.
        /// NavigationCompleted event fires when the WebView has completely loaded
        /// (body.onload has fired) or loading stopped with error.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        void add_NavigationCompleted([In] IWebView2NavigationCompletedEventHandler eventHandler, out EventRegistrationToken token);

        /// <summary>
        /// Remove an event handler previously added with add_NavigationCompleted.
        /// </summary>
        /// <param name="token"></param>
        void remove_NavigationCompleted([In] EventRegistrationToken token);

        /// <summary>
        /// Add an event handler for the FrameNavigationStarting event.
        /// FrameNavigationStarting fires when a child frame in the WebView
        /// requesting permission to navigate to a different URI. This will fire for
        /// redirects as well.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        void add_FrameNavigationStarting([In] IWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token);

        /// <summary>
        /// Remove an event handler previously added with add_FrameNavigationStarting.
        /// </summary>
        /// <param name="token"></param>
        void remove_FrameNavigationStarting([In] EventRegistrationToken token);

        /// <summary>
        /// Add an event handler for the MoveFocusRequested event.
        /// MoveFocusRequested fires when user tries to tab out of the WebView.
        /// The WebView's focus has not changed when this event is fired.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        void add_MoveFocusRequested([In] IWebView2MoveFocusRequestedEventHandler eventHandler, out EventRegistrationToken token);

        /// <summary>
        /// Remove an event handler previously added with add_MoveFocusRequested.
        /// </summary>
        /// <param name="token"></param>
        void remove_MoveFocusRequested([In] EventRegistrationToken token);

        /// <summary>
        /// Add an event handler for the GotFocus event.
        /// GotFocus fires when WebView got focus.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        void add_GotFocus([In] IWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token);

        /// <summary>
        /// Remove an event handler previously added with add_GotFocus.
        /// </summary>
        /// <param name="token"></param>
        void remove_GotFocus([In] EventRegistrationToken token);

        /// <summary>
        /// Add an event handler for the LostFocus event.
        /// LostFocus fires when WebView lost focus.
        /// In the case where MoveFocusRequested event is fired, the focus is still
        /// on WebView when MoveFocusRequested event fires. Lost focus only fires
        /// afterwards when app's code or default action of MoveFocusRequested event
        /// set focus away from WebView.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        void add_LostFocus([In] IWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token);

        /// <summary>
        /// Remove an event handler previously added with add_LostFocus.
        /// </summary>
        /// <param name="token"></param>
        void remove_LostFocus([In] EventRegistrationToken token);

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
        /// <param name="filterLength"></param>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        void add_WebResourceRequested([In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr)] ref string[] urlFilter,
                                       [In, MarshalAs(UnmanagedType.LPArray, ArraySubType=UnmanagedType.I4)] int[] resourceContextFilter,
                                       [In] ulong filterLength,
                                       [In] IWebView2WebResourceRequestedEventHandler eventHandler,
                                       out EventRegistrationToken token);

        /// <summary>
        /// Remove an event handler previously added with add_WebResourceRequested.
        /// </summary>
        /// <param name="token"></param>
        void remove_WebResourceRequested([In] EventRegistrationToken token);

        /// <summary>
        /// Add an event handler for the ScriptDialogOpening event.
        /// The event fires when a JavaScript dialog (alert, confirm, or prompt) will
        /// show for the webview. This event only fires if the
        /// IWebView2Settings::AreDefaultScriptDialogsEnabled property is set to false.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        void add_ScriptDialogOpening([In] IWebView2ScriptDialogOpeningEventHandler eventHandler, out EventRegistrationToken token);

        /// <summary>
        /// Remove an event handler previously added with add_ScriptDialogOpening.
        /// </summary>
        /// <param name="token"></param>
        void remove_ScriptDialogOpening([In] EventRegistrationToken token);

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
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        void add_ZoomFactorChanged([In] IWebView2ZoomFactorChangedEventHandler eventHandler, out EventRegistrationToken token);

        /// <summary>
        /// Remove an event handler previously added with add_ZoomFactorChanged.
        /// </summary>
        /// <param name="token"></param>
        void remove_ZoomFactorChanged([In] EventRegistrationToken token);

        /// <summary>
        /// Add an event handler for the PermissionRequested event.
        /// Fires when content in a WebView requests permission to access some
        /// privileged resources.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        void add_PermissionRequested([In] IWebView2PermissionRequestedEventHandler eventHandler, out EventRegistrationToken token);

        /// <summary>
        /// Remove an event handler previously added with add_PermissionRequested.
        /// </summary>
        /// <param name="token"></param>
        void remove_PermissionRequested([In] EventRegistrationToken token);

        /// <summary>
        /// Add an event handler for the ProcessFailed event.
        /// Fires when a WebView process terminated unexpectedly or
        /// become unresponsive.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        void add_ProcessFailed([In] IWebView2ProcessFailedEventHandler eventHandler, out EventRegistrationToken token);

        /// <summary>
        /// Remove an event handler previously added with add_ProcessFailed.
        /// </summary>
        /// <param name="token"></param>
        void remove_ProcessFailed([In] EventRegistrationToken token);

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
        /// </summary>
        /// <param name="javaScript"></param>
        /// <param name="handler"></param>
        void AddScriptToExecuteOnDocumentCreated([In, MarshalAs(UnmanagedType.LPWStr)] string javaScript, IWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler);

        /// <summary>
        /// Remove the corresponding JavaScript added via AddScriptToExecuteOnDocumentCreated.
        /// </summary>
        /// <param name="id"></param>
        void RemoveScriptToExecuteOnDocumentCreated([In, MarshalAs(UnmanagedType.LPWStr)] string id);

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
        /// <param name="handler"></param>
        void ExecuteScript([In, MarshalAs(UnmanagedType.LPWStr)] string javaScript, IWebView2ExecuteScriptCompletedHandler handler);

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
        void CapturePreview(WEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream, IWebView2CapturePreviewCompletedHandler handler);

        /// <summary>
        /// Reload the current page. This is similar to navigating to the URI of
        /// current top level document including all navigation events firing and
        /// respecting any entries in the HTTP cache. But, the back/forward history
        /// will not be modified.
        /// </summary>
        void Reload();

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
        [DispId(1610678306)]
        tagRECT Bounds { get; set; }

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

        [DispId(1610678308)]
        double ZoomFactor { get; set; }

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
        [DispId(1610678310)]
        bool IsVisible
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
            [param: MarshalAs(UnmanagedType.Bool)]
            set;
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
        void PostWebMessageAsJson([In, MarshalAs(UnmanagedType.LPWStr)]string webMessageAsJson);

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
        void PostWebMessageAsString([In, MarshalAs(UnmanagedType.LPWStr)] string webMessageAsString);

        /// <summary>
        /// This event fires when the IsWebMessageEnabled setting is set and the top
        /// level document of the webview calls `window.chrome.webview.postMessage`.
        /// The postMessage function is `void postMessage(object)` where
        /// object is any object supported by JSON conversion.
        ///
        /// \snippet ScenarioWebMessage.html chromeWebView
        ///
        /// When postMessage is called, the IWebView2WebMessageReceivedEventHandler set via
        /// this SetWebMessageReceivedEventHandler method will be invoked with the
        /// postMessage's object parameter converted to a JSON string.
        ///
        /// \snippet ScenarioWebMessage.cpp WebMessageReceived
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="token"></param>
        void add_WebMessageReceived([In] IWebView2WebMessageReceivedEventHandler handler, out EventRegistrationToken token);

        /// <summary>
        /// Remove an event handler previously added with add_WebMessageReceived.
        /// </summary>
        /// <param name="token"></param>
        void remove_WebMessageReceived([In] EventRegistrationToken token);

        /// <summary>
        /// Closes the webview and cleans up the underlying browser instance.
        /// Cleaning up the browser instace will release the resources powering the webview.
        /// The browser instance will be shut down if there are no other webviews using it.
        ///
        /// After calling Close, all method calls will fail and event handlers
        /// will stop firing.
        /// </summary>
        void Close();

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
        /// <param name="handler"></param>
        void CallDevToolsProtocolMethod([In, MarshalAs(UnmanagedType.LPWStr)] string methodName, [In, MarshalAs(UnmanagedType.LPWStr)] string parametersAsJson, IWebView2CallDevToolsProtocolMethodCompletedHandler handler);

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
        /// <param name="handler"></param>
        /// <param name="token"></param>
        void add_DevToolsProtocolEventReceived([In, MarshalAs(UnmanagedType.LPWStr)] string eventName, IWebView2DevToolsProtocolEventReceivedEventHandler handler, out EventRegistrationToken token);

        /// <summary>
        /// The process id of the browser process that hosts the WebView.
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="token"></param>
        void remove_DevToolsProtocolEventReceived([In, MarshalAs(UnmanagedType.LPWStr)] string eventName, EventRegistrationToken token);

        /// <summary>
        /// The process id of the browser process that hosts the WebView.
        /// </summary>
        [DispId(1610678320)]
        uint BrowserProcessId { get; }

        /// <summary>
        /// Can navigate the webview to the previous page in the navigation history.
        /// get_CanGoBack change value with the DocumentStateChanged event.
        /// </summary>
        [DispId(1610678321)]
        bool CanGoBack
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
        }

        /// <summary>
        /// Can navigate the webview to the next page in the navigation history.
        /// get_CanGoForward change value with the DocumentStateChanged event.
        /// </summary>
        [DispId(1610678322)]
        bool CanGoForward
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
        }

        /// <summary>
        /// Navigates the webview to the previous page in the navigation history.
        /// </summary>
        void GoBack();

        /// <summary>
        /// Navigates the webview to the next page in the navigation history.
        /// </summary>
        void GoForward();
    }
}