using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// Checked
    /// </summary>
    [ComVisible(true),
     ComImport,
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
     Guid("5cc5293d-af6f-41d4-9619-44bd31ba4c93")]
    public interface ICoreWebView2
    {
        // Properties
        [DispId(1610678272)]
        ICoreWebView2Settings Settings { get; }

        [DispId(1610678273)]
        string Source
        {
            [return: MarshalAs(UnmanagedType.LPWStr)]
            get;
        }

        void Navigate([In, MarshalAs(UnmanagedType.LPWStr)] string uri);

        void NavigateToString([In, MarshalAs(UnmanagedType.LPWStr)] string htmlContent);

        void add_NavigationStarting([In] ICoreWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token);

        void remove_NavigationStarting([In] EventRegistrationToken token);

        void add_ContentLoading([In] ICoreWebView2ContentLoadingEventHandler eventHandler, out EventRegistrationToken token);

        void remove_ContentLoading([In] EventRegistrationToken token);

        void add_SourceChanged([In] ICoreWebView2SourceChangedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_SourceChanged([In] EventRegistrationToken token);

        void add_HistoryChanged([In] ICoreWebView2HistoryChangedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_HistoryChanged([In] EventRegistrationToken token);

        void add_NavigationCompleted([In] ICoreWebView2NavigationCompletedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_NavigationCompleted([In] EventRegistrationToken token);

        void add_FrameNavigationStarting([In] ICoreWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token);

        void remove_FrameNavigationStarting([In] EventRegistrationToken token);

        void add_ScriptDialogOpening([In] ICoreWebView2ScriptDialogOpeningEventHandler eventHandler, out EventRegistrationToken token);

        void remove_ScriptDialogOpening([In] EventRegistrationToken token);

        void add_PermissionRequested([In] ICoreWebView2PermissionRequestedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_PermissionRequested([In] EventRegistrationToken token);

        void add_ProcessFailed([In] ICoreWebView2ProcessFailedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_ProcessFailed([In] EventRegistrationToken token);

        void AddScriptToExecuteOnDocumentCreated([In, MarshalAs(UnmanagedType.LPWStr)] string javaScript, ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler);

        void RemoveScriptToExecuteOnDocumentCreated([In, MarshalAs(UnmanagedType.LPWStr)] string id);

        void ExecuteScript([In, MarshalAs(UnmanagedType.LPWStr)] string javaScript, ICoreWebView2ExecuteScriptCompletedHandler handler);

        void CapturePreview(WEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream, ICoreWebView2CapturePreviewCompletedHandler handler);

        void Reload();

        void PostWebMessageAsJson([In, MarshalAs(UnmanagedType.LPWStr)] string webMessageAsJson);

        void PostWebMessageAsString([In, MarshalAs(UnmanagedType.LPWStr)] string webMessageAsString);

        void add_WebMessageReceived([In] ICoreWebView2WebMessageReceivedEventHandler handler, out EventRegistrationToken token);

        void remove_WebMessageReceived([In] EventRegistrationToken token);

        void CallDevToolsProtocolMethod([In, MarshalAs(UnmanagedType.LPWStr)] string methodName, [In, MarshalAs(UnmanagedType.LPWStr)] string parametersAsJson, ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler);

        [DispId(1610678304)]
        uint BrowserProcessId { get; }

        [DispId(1610678305)]
        bool CanGoBack
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
        }

        [DispId(1610678306)]
        bool CanGoForward
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
        }

        void GoBack();

        void GoForward();

        void GetDevToolsProtocolEventReceiver([In, MarshalAs(UnmanagedType.LPWStr)] string eventName, [Out] out ICoreWebView2DevToolsProtocolEventReceiver handler);

        /// <summary>
        /// Stop all navigations and pending resource fetches
        /// </summary>
        void Stop();

        /// <summary>
        /// Add an event handler for the NewWindowRequested event.
        /// Fires when content inside the WebView requested to open a new window,
        /// such as through window.open. The app can pass a target
        /// webview that will be considered the opened window.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        void add_NewWindowRequested([In] ICoreWebView2NewWindowRequestedEventHandler eventHandler, out EventRegistrationToken token);

        /// <summary>
        /// Remove an event handler previously added with add_NewWindowRequested.
        /// </summary>
        /// <param name="token"></param>
        void remove_NewWindowRequested([In] EventRegistrationToken token);

        /// <summary>
        /// Add an event handler for the DocumentTitleChanged event.
        /// The event fires when the DocumentTitle property of the WebView changes.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        void add_DocumentTitleChanged([In] ICoreWebView2DocumentTitleChangedEventHandler eventHandler, out EventRegistrationToken token);

        /// <summary>
        /// Remove an event handler previously added with add_DocumentTitleChanged.
        /// </summary>
        /// <param name="token"></param>
        void remove_DocumentTitleChanged([In] EventRegistrationToken token);

        /// <summary>
        /// The title for the current top level document.
        /// If the document has no explicit title or is otherwise empty, then the URI
        /// of the top level document is used.
        /// </summary>
        /// <param name="title"></param>
        void DocumentTitle([MarshalAs(UnmanagedType.LPWStr)] out string title);

        void AddRemoteObject([In, MarshalAs(UnmanagedType.LPWStr)] string name, [In] ref object @object);

        /// <summary>
        /// Remove the host object specified by the name so that it is no longer
        /// accessible from JavaScript code in the WebView.
        /// While new access attempts will be denied, if the object is already
        /// obtained by JavaScript code in the WebView, the JavaScript code will
        /// continue to have access to that object.
        /// Calling this method for a name that is already removed or never added will
        /// fail.
        /// </summary>
        /// <param name="name"></param>
        void RemoveRemoteObject([In, MarshalAs(UnmanagedType.LPWStr)] string name);

        /// <summary>
        /// Opens the DevTools window for the current document in the WebView.
        /// Does nothing if called when the DevTools window is already open
        /// </summary>
        void OpenDevToolsWindow();

        void add_ContainsFullScreenElementChanged([In] ICoreWebView2ContainsFullScreenElementChangedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_ContainsFullScreenElementChanged([In] EventRegistrationToken token);

        [DispId(1610678321)]
        bool ContainsFullScreenElement
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
        }

        void add_WebResourceRequested([In] ICoreWebView2WebResourceRequestedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_WebResourceRequested(EventRegistrationToken token);

        void AddWebResourceRequestedFilter([In, MarshalAs(UnmanagedType.LPWStr)] string uri, [In] WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContext);

        void RemoveWebResourceRequestedFilter([In, MarshalAs(UnmanagedType.LPWStr)] string uri, [In] WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContext);

        void add_WindowCloseRequested([In] ICoreWebView2WindowCloseRequestedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_WindowCloseRequested(EventRegistrationToken token);
    }
}
