using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Russinsoft.WebView2.Interop
{
#pragma warning disable CS0108

    /// <summary>
    /// Checked
    /// </summary>
    [ComVisible(true),
     ComImport,
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
     Guid("A16A5FF1-C23B-4489-8752-8568A1BED09C")]
    public interface IWebView2WebView3 : IWebView2WebView
    {
        // Properties
        [DispId(1610678272)]
        IWebView2Settings Settings { get; }

        [DispId(1610678273)]
        string Source
        {
            [return: MarshalAs(UnmanagedType.LPWStr)]
            get;
        }

        void Navigate([In, MarshalAs(UnmanagedType.LPWStr)] string uri);

        void MoveFocus([In] WEBVIEW2_MOVE_FOCUS_REASON reason);

        void NavigateToString([In, MarshalAs(UnmanagedType.LPWStr)] string htmlContent);

        void add_NavigationStarting([In] IWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token);

        void remove_NavigationStarting([In] EventRegistrationToken token);

        void add_DocumentStateChanged([In] IWebView2DocumentStateChangedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_DocumentStateChanged([In] EventRegistrationToken token);

        void add_NavigationCompleted([In] IWebView2NavigationCompletedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_NavigationCompleted([In] EventRegistrationToken token);

        void add_FrameNavigationStarting([In] IWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token);

        void remove_FrameNavigationStarting([In] EventRegistrationToken token);

        void add_MoveFocusRequested([In] IWebView2MoveFocusRequestedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_MoveFocusRequested([In] EventRegistrationToken token);

        void add_GotFocus([In] IWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_GotFocus([In] EventRegistrationToken token);

        void add_LostFocus([In] IWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_LostFocus([In] EventRegistrationToken token);

        void add_WebResourceRequested([In, MarshalAs(UnmanagedType.LPWStr)] ref string urlFilter, ref WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContextFilter, ulong filterLength, IWebView2WebResourceRequestedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_WebResourceRequested(EventRegistrationToken token);

        void add_ScriptDialogOpening([In] IWebView2ScriptDialogOpeningEventHandler eventHandler, out EventRegistrationToken token);

        void remove_ScriptDialogOpening([In] EventRegistrationToken token);

        void add_ZoomFactorChanged([In] IWebView2ZoomFactorChangedEventHandler eventHandler, out EventRegistrationToken token);
        void remove_ZoomFactorChanged([In] EventRegistrationToken token);

        void add_PermissionRequested([In] IWebView2PermissionRequestedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_PermissionRequested([In] EventRegistrationToken token);

        void add_ProcessFailed([In] IWebView2ProcessFailedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_ProcessFailed([In] EventRegistrationToken token);

        void AddScriptToExecuteOnDocumentCreated([In, MarshalAs(UnmanagedType.LPWStr)] string javaScript, IWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler);

        void RemoveScriptToExecuteOnDocumentCreated([In, MarshalAs(UnmanagedType.LPWStr)] string id);

        void ExecuteScript([In, MarshalAs(UnmanagedType.LPWStr)] string javaScript, IWebView2ExecuteScriptCompletedHandler handler);

        void CapturePreview(WEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream, IWebView2CapturePreviewCompletedHandler handler);

        void Reload();

        [DispId(1610678306)]
        tagRECT Bounds { get; set; }

        [DispId(1610678308)]
        double ZoomFactor { get; set; }

        [DispId(1610678310)]
        bool IsVisible
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
            [param: MarshalAs(UnmanagedType.Bool)]
            set;
        }

        void PostWebMessageAsJson([In, MarshalAs(UnmanagedType.LPWStr)] string webMessageAsJson);

        void PostWebMessageAsString([In, MarshalAs(UnmanagedType.LPWStr)] string webMessageAsString);

        void add_WebMessageReceived([In] IWebView2WebMessageReceivedEventHandler handler, out EventRegistrationToken token);

        void remove_WebMessageReceived([In] EventRegistrationToken token);
    
        void Close();

        void CallDevToolsProtocolMethod([In, MarshalAs(UnmanagedType.LPWStr)] string methodName, [In, MarshalAs(UnmanagedType.LPWStr)] string parametersAsJson, IWebView2CallDevToolsProtocolMethodCompletedHandler handler);

        void add_DevToolsProtocolEventReceived([In, MarshalAs(UnmanagedType.LPWStr)] string eventName, IWebView2DevToolsProtocolEventReceivedEventHandler handler, out EventRegistrationToken token);

        void remove_DevToolsProtocolEventReceived([In, MarshalAs(UnmanagedType.LPWStr)]string eventName, EventRegistrationToken token);

        [DispId(1610678320)]
        uint BrowserProcessId { get; }

        [DispId(1610678321)]
        bool CanGoBack
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
        }
        [DispId(1610678322)]
        bool CanGoForward
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
        }

        void GoBack();

        void GoForward();

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
        void add_NewWindowRequested([In] IWebView2NewWindowRequestedEventHandler eventHandler, out EventRegistrationToken token);

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
        void add_DocumentTitleChanged([In] IWebView2DocumentTitleChangedEventHandler eventHandler, out EventRegistrationToken token);

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
    }
}