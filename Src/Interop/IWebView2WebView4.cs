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
     Guid("E8B04ED2-FA61-4CBB-B303-786088177555")]
    public interface IWebView2WebView4 : IWebView2WebView3
    {
        // Properties
        [DispId(1610678272)]
        new IWebView2Settings Settings { get; }

        [DispId(1610678273)]
        new string Source
        {
            [return: MarshalAs(UnmanagedType.LPWStr)]
            get;
        }

        new void Navigate([In, MarshalAs(UnmanagedType.LPWStr)] string uri);

        new void MoveFocus([In] WEBVIEW2_MOVE_FOCUS_REASON reason);

        new void NavigateToString([In, MarshalAs(UnmanagedType.LPWStr)] string htmlContent);

        new void add_NavigationStarting([In] IWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token);

        new void remove_NavigationStarting([In] EventRegistrationToken token);

        new void add_DocumentStateChanged([In] IWebView2DocumentStateChangedEventHandler eventHandler, out EventRegistrationToken token);

        new void remove_DocumentStateChanged([In] EventRegistrationToken token);

        new void add_NavigationCompleted([In] IWebView2NavigationCompletedEventHandler eventHandler, out EventRegistrationToken token);

        new void remove_NavigationCompleted([In] EventRegistrationToken token);

        new void add_FrameNavigationStarting([In] IWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token);

        new void remove_FrameNavigationStarting([In] EventRegistrationToken token);

        new void add_MoveFocusRequested([In] IWebView2MoveFocusRequestedEventHandler eventHandler, out EventRegistrationToken token);

        new void remove_MoveFocusRequested([In] EventRegistrationToken token);

        new void add_GotFocus([In] IWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token);

        new void remove_GotFocus([In] EventRegistrationToken token);

        new void add_LostFocus([In] IWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token);

        new void remove_LostFocus([In] EventRegistrationToken token);

        /// <summary>
        /// This API will be deprecated, please use the new add_WebResourceRequested API.
        /// </summary>
        /// <param name="urlFilter"></param>
        /// <param name="resourceContextFilter"></param>
        /// <param name="filterLength"></param>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        new void add_WebResourceRequested_deprecated([In] ref string urlFilter,
                [In] ref WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContextFilter,
                [In][ComAliasName("WebView2.ULONG_PTR")] ulong filterLength,
                [In] IWebView2WebResourceRequestedEventHandler eventHandler, out EventRegistrationToken token);

        new void remove_WebResourceRequested(EventRegistrationToken token);

        new void add_ScriptDialogOpening([In] IWebView2ScriptDialogOpeningEventHandler eventHandler, out EventRegistrationToken token);

        new void remove_ScriptDialogOpening([In] EventRegistrationToken token);

        new void add_ZoomFactorChanged([In] IWebView2ZoomFactorChangedEventHandler eventHandler, out EventRegistrationToken token);

        new void remove_ZoomFactorChanged([In] EventRegistrationToken token);

        new void add_PermissionRequested([In] IWebView2PermissionRequestedEventHandler eventHandler, out EventRegistrationToken token);

        new void remove_PermissionRequested([In] EventRegistrationToken token);

        new void add_ProcessFailed([In] IWebView2ProcessFailedEventHandler eventHandler, out EventRegistrationToken token);

        new void remove_ProcessFailed([In] EventRegistrationToken token);

        new void AddScriptToExecuteOnDocumentCreated([In, MarshalAs(UnmanagedType.LPWStr)] string javaScript, IWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler);

        new void RemoveScriptToExecuteOnDocumentCreated([In, MarshalAs(UnmanagedType.LPWStr)] string id);

        new void ExecuteScript([In, MarshalAs(UnmanagedType.LPWStr)] string javaScript, IWebView2ExecuteScriptCompletedHandler handler);

        new void CapturePreview(WEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream, IWebView2CapturePreviewCompletedHandler handler);

        new void Reload();

        [DispId(1610678306)]
        new tagRECT Bounds { get; set; }

        [DispId(1610678308)]
        new double ZoomFactor { get; set; }

        [DispId(1610678310)]
        new bool IsVisible
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
            [param: MarshalAs(UnmanagedType.Bool)]
            set;
        }

        new void PostWebMessageAsJson([In, MarshalAs(UnmanagedType.LPWStr)] string webMessageAsJson);

        new void PostWebMessageAsString([In, MarshalAs(UnmanagedType.LPWStr)] string webMessageAsString);

        new void add_WebMessageReceived([In] IWebView2WebMessageReceivedEventHandler handler, out EventRegistrationToken token);

        new void remove_WebMessageReceived([In] EventRegistrationToken token);

        new void Close();

        new void CallDevToolsProtocolMethod([In, MarshalAs(UnmanagedType.LPWStr)] string methodName, [In, MarshalAs(UnmanagedType.LPWStr)] string parametersAsJson, IWebView2CallDevToolsProtocolMethodCompletedHandler handler);

        new void add_DevToolsProtocolEventReceived([In, MarshalAs(UnmanagedType.LPWStr)] string eventName, IWebView2DevToolsProtocolEventReceivedEventHandler handler, out EventRegistrationToken token);

        new void remove_DevToolsProtocolEventReceived([In, MarshalAs(UnmanagedType.LPWStr)]string eventName, EventRegistrationToken token);

        [DispId(1610678320)]
        new uint BrowserProcessId { get; }

        [DispId(1610678321)]
        new bool CanGoBack
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
        }
        [DispId(1610678322)]
        new bool CanGoForward
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
        }

        new void GoBack();

        new void GoForward();

        /// <summary>
        /// Stop all navigations and pending resource fetches
        /// </summary>
        new void Stop();

        /// <summary>
        /// Add an event handler for the NewWindowRequested event.
        /// Fires when content inside the WebView requested to open a new window,
        /// such as through window.open. The app can pass a target
        /// webview that will be considered the opened window.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        new void add_NewWindowRequested([In] IWebView2NewWindowRequestedEventHandler eventHandler, out EventRegistrationToken token);

        /// <summary>
        /// Remove an event handler previously added with add_NewWindowRequested.
        /// </summary>
        /// <param name="token"></param>
        new void remove_NewWindowRequested([In] EventRegistrationToken token);

        /// <summary>
        /// Add an event handler for the DocumentTitleChanged event.
        /// The event fires when the DocumentTitle property of the WebView changes.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        new void add_DocumentTitleChanged([In] IWebView2DocumentTitleChangedEventHandler eventHandler, out EventRegistrationToken token);

        /// <summary>
        /// Remove an event handler previously added with add_DocumentTitleChanged.
        /// </summary>
        /// <param name="token"></param>
        new void remove_DocumentTitleChanged([In] EventRegistrationToken token);

        /// <summary>
        /// The title for the current top level document.
        /// If the document has no explicit title or is otherwise empty, then the URI
        /// of the top level document is used.
        /// </summary>
        /// <param name="title"></param>
        new void DocumentTitle([MarshalAs(UnmanagedType.LPWStr)] out string title);

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

        void add_AcceleratorKeyPressed([In] IWebView2AcceleratorKeyPressedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_AcceleratorKeyPressed([In] EventRegistrationToken token);
    }
}
