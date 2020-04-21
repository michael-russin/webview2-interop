# Functionality Implementation
There were a *lot* of interface changes with the WebView2 0.9.430 release.  Although there are now 2 main interfaces for 
the webview I've left them both implemented in WebView2WebView. 
Below are tables of what functionality is currently supported in the interop code

### ICoreWebView2 interface

|ICoreWebView2 Native| WebView2WebView class | Notes|
|---|---|---|
|get_Settings | Settings {get;}   | Working  |
|get_Source | Source  {get;}| Working  |
|Navigate(LPWSTR url) | Navigate(string url)  | Working  |
|NavigateToString(LPCWSTR htmlContent)| NavigateToString(string htmlContent)  | Working  |
|add_NavigationStarting| RegisterNavigationStarting(Action<NavigationStartingEventArgs> callback)  | Working |
|remove_NavigationStarting| UnregisterNavigationStarting(long)  | Working |
|add_ContentLoading| long RegisterContentLoading(Action<ContentLoadingEventArgs> callback) event | Working |
|remove_ContentLoading| void UnregisterDocumentStateChanged(long token) | Working |
|add_SourceChanged| long RegisterSourceChanged(Action<SourceChangedEventArgs> callback) event | Working |
|remove_ContentLoading| void UnregisterSourceChanged(long token) | Working |
|add_HistoryChanged| long RegisterHistoryChanged(Action<HistoryChangedEventArgs> callback) event | Working |
|remove_HistoryChanged| void UnregisterHistoryChanged(long token) | Working |
|add_NavigationCompleted| RegisterNavigationCompleted(Action<NavigationCompletedEventArgs> callback) | Working |
|remove_NavigationCompleted| UnregisterNavigationCompleted(long token) | Working |
|add_FrameNavigationStarting| RegisterFrameNavigationStarting(Action<NavigationStartingEventArgs> callback)  | Working |
|remove_FrameNavigationStarting| UnregisterFrameNavigationStarting(long token)  | Working |
|add_ScriptDialogOpening| RegisterScriptDialogOpening(Action<ScriptDialogOpeningEventArgs> callback)   | Working |
|remove_ScriptDialogOpening| UnregisterScriptDialogOpening(long token)   | Working |
|add_PermissionRequested| RegisterPermissionRequested(Action<PermissionRequestedEventArgs> callback) | Working |
|remove_PermissionRequested| UnregisterPermissionRequested(long token) | Working |
|add_ProcessFailed| RegisterProcessFailed(Action<ProcessFailedEventArgs> callback) | Working |
|remove_ProcessFailed| UnregisterProcessFailed(long token) | Working |
|AddScriptToExecuteOnDocumentCreated | AddScriptToExecuteOnDocumentCreated(string javaScript, Action<AddScriptToExecuteOnDocumentCreatedCompletedEventArgs> callback)  | Working |
|RemoveScriptToExecuteOnDocumentCreated| RemoveScriptToExecuteOnDocumentCreated(string id)  | Working |
|ExecuteScript | ExecuteScript(string javaScript, Action<ExecuteScriptCompletedEventArgs> callback) | Working |
|CapturePreview| CapturePreview(imageFormat, Stream imageStream, Action<CapturePreviewCompletedArgs> callback)  | Working |
|Reload | Reload()  | Working  |
|PostWebMessageAsJson | PostWebMessageAsJson(string webMessageAsJson) | Working |
|PostWebMessageAsString | PostWebMessageAsString(string webMessageAsString)  | Working |
|add_WebMessageReceived | RegisterWebMessageReceived(Action<WebMessageReceivedEventArgs> callback) | Working |
|remove_WebMessageReceived | UnregisterWebMessageReceived(long token) | Working  |
|CallDevToolsProtocolMethod | CallDevToolsProtocolMethod(string methodName, string parametersAsJson) | Working |
|get_BrowserProcessId | BrowserProcessId {get;}  | Working |
|get_CanGoBack| CanGoBack {get;} | Working |
|get_CanGoForward| CanGoForward {get;}  | Working |
|GoBack| GoBack()  | Working |
|GoForward| GoForward() | Working |
|GetDevToolsProtocolEventReceiver | GetDevToolsProtocolEventReceiver(string eventName) | Working |
|Stop | Stop() | |
|add_NewWindowRequested| RegisterNewWindowRequested(Action<NewWindowRequestedEventArgs> callback) | Working |
|remove_NewWindowRequested| UnregisterNewWindowRequested(long token) | Working |
|add_DocumentTitleChanged| RegisterDocumentTitledChanged(Action<DocumentTitleChangedEventArgs> callback) | Working |
|remove_DocumentTitleChanged| UnregisterDocumentTitledChanged(long token) | Working |
|get_DocumentTitle| DocumentTitle {get;} | Working |
|AddRemoteObject| AddRemoteObject(string name, ref object remoteObject) | Working |
|RemoveRemoteObject| RemoveRemoteObject(string name) | Working |
|OpenDevToolsWindow| OpenDevToolsWindow()  | Working |
|add_ContainsFullScreenElementChanged| RegisterContainsFullScreenElementChanged(Action<ContainsFullScreenElementChangedEventArgs> callback) | Working |
|remove_ContainsFullScreenElementChanged| UnRegisterContainsFullScreenElementChanged(long token)  | Working |
|get_ContainsFullScreenElement| ContainsFullScreenElement {get;} | Working |
|add_WebResourceRequested| RegisterWebResourceRequested(Action<WebResourceRequestedEventArgs> callback)  | Working |
|remove_WebResourceRequested| UnregisterWebResourceRequested(long token) | Working |
|AddWebResourceRequestedFilter| AddWebResourceRequestedFilter(string uri, WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContext)  | Working |
|RemoveWebResourceRequestedFilter| RemoveWebResourceRequestedFilter(string uri, WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContext)  | Working |
|add_WindowCloseRequested|  RegisterWindowCloseRequested(Action<WindowCloseRequestedEventArgs> callback) | Working |
|remove_NewWindowRequested| UnRegisterWindowCloseRequested(long token) | Working |

### ICoreWebView2Host

|ICoreWebView2Host Native|WebView2WebView class| Notes |
|---|---|---|
|get_IsVisible| IsVisible {get;}  | Working |
|put_IsVisible| IsVisible {set;} | Working |
|get_Bounds| Bounds {get;} | Working |
|put_Bounds| Bounds {set;} | Working |
|get_ZoomFactor| ZoomFactor {get;}  | Working |
|put_ZoomFactor|  ZoomFactor {set;} | Working |
|add_ZoomFactorChanged| RegisterZoomFactorChanged(Action<ZoomFactorCompletedEventArgs> callback)  | Working |
|remove_ZoomFactorChanged| UnregisterZoomFactorChanged(long token)  | Working |
|SetBoundsAndZoomFactor |  | |
|MoveFocus(WEBVIEW2_MOVE_FOCUS_REASON reason)| MoveFocus(WEBVIEW2_MOVE_FOCUS_REASON reason)  | Working |
|add_MoveFocusRequested| RegisterMoveFocusRequested(Action<MoveFocusRequestedEventArgs> callback) | Working |
|remove_MoveFocusRequested| UnregisterMoveFocusRequested(long token) | Working |
|add_GotFocus| RegisterGotFocus(Action<FocusChangedEventEventArgs> callback) | Working |
|remove_GotFocus| UnregisterGotFocus(long token) | Working |
|add_LostFocus| RegisterLostFocus(Action<FocusChangedEventEventArgs> callback)  | Working |
|remove_LostFocus| UnregisterLostFocus(long token)  | Working |
|add_AcceleratorKeyPressed| RegisterAcceleratorKeyPressed(Action<AcceleratorKeyPressedEventArgs> callback)  | Working |
|remove_AcceleratorKeyPressed| UnregisterAcceleratorKeyPressed(long token)  | Working |
|get_ParentWindow | ParentWindow {get;}| Working |
|put_ParentWindow | ParentWindow {Set;}| ? |
|NotifyParentWindowPositionChanged | NotifyParentWindowPositionChanged() | ? |
|Close | Close() | Working |
|get_CoreWebVIew2 | Not exposed |  |
