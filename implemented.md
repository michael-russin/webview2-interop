# Functionality Implementation
Below are tables of what functionality is currently supported in the interop code

### IWebView2WebView interface

|WebView2 Native| WebView2WebView class | Notes|
|---|---|---|
|get_Settings | Settings {get;}   |   |
|get_Source | Source  {get;}|   |
|Navigate(LPWSTR url) | Navigate(string url)  |   |
|MoveFocus(WEBVIEW2_MOVE_FOCUS_REASON reason)| MoveFocus(WEBVIEW2_MOVE_FOCUS_REASON reason)  |  |
|NavigateToString(LPCWSTR htmlContent)| NavigateToString(string htmlContent)  |   |
|add_NavigationStarting| RegisterNavigationStarting(Action<NavigationStartingEventArgs> callback)  |  |
|remove_NavigationStarting| UnregisterNavigationStarting(long)  |  |
|add_DocumentStateChanged| long RegisterDocumentStateChanged(Action<DocumentStateChangedEventArgs> callback) event |  |
|remove_DocumentStateChanged| void UnregisterDocumentStateChanged(long token) |  |
|add_NavigationCompleted| RegisterNavigationCompleted(Action<NavigationCompletedEventArgs> callback) |  |
|remove_NavigationCompleted| UnregisterNavigationCompleted(long token) |  |
|add_FrameNavigationStarting| RegisterFrameNavigationStarting(Action<NavigationStartingEventArgs> callback)  |  |
|remove_FrameNavigationStarting| UnregisterFrameNavigationStarting(long token)  |  |
|add_MoveFocusRequested| RegisterMoveFocusRequested(Action<MoveFocusRequestedEventArgs> callback) |  |
|remove_MoveFocusRequested| UnregisterMoveFocusRequested(long token) |  |
|add_GotFocus| RegisterGotFocus(Action<FocusChangedEventEventArgs> callback) |  |
|remove_GotFocus| UnregisterGotFocus(long token) |  |
|add_LostFocus| RegisterLostFocus(Action<FocusChangedEventEventArgs> callback)  |  |
|remove_LostFocus| UnregisterLostFocus(long token)  |  |
|add_WebResourceRequested|  | Not working currently  |
|remove_WebResourceRequested|  | Not working currently |
|add_ScriptDialogOpening| RegisterScriptDialogOpening(Action<ScriptDialogOpeningEventArgs> callback)   |  |
|remove_ScriptDialogOpening| UnregisterScriptDialogOpening(long token)   |  |
|add_ZoomFactorChanged| RegisterZoomFactorChanged(Action<ZoomFactorCompletedEventArgs> callback)  |  |
|remove_ZoomFactorChanged| UnregisterZoomFactorChanged(long token)  |  |
|add_PermissionRequested| RegisterPermissionRequested(Action<PermissionRequestedEventArgs> callback)|  |
|remove_PermissionRequested| UnregisterPermissionRequested(long token)|  |
|add_ProcessFailed| RegisterProcessFailed(Action<ProcessFailedEventArgs> callback) |  |
|remove_ProcessFailed| UnregisterProcessFailed(long token) |  |
|AddScriptToExecuteOnDocumentCreated | AddScriptToExecuteOnDocumentCreated(string javaScript, Action<AddScriptToExecuteOnDocumentCreatedCompletedEventArgs> callback)  |  |
|RemoveScriptToExecuteOnDocumentCreated| RemoveScriptToExecuteOnDocumentCreated(string id)  |  |
|ExecuteScript | ExecuteScript(string javaScript, Action<ExecuteScriptCompletedEventArgs> callback) |  |
|CapturePreview|   | Not implemented yet |
|Reload | Reload()  |  |
|get_Bounds| Bounds {get;} |  |
|put_Bounds| Bounds {set;} |  |
|get_ZoomFactor| ZoomFactor {get;}  |  |
|put_ZoomFactor|  ZoomFactor {set;} |  |
|get_IsVisible| IsVisible {get;}  |  |
|put_IsVisible| IsVisible {set;} |  |
|PostWebMessageAsJson | PostWebMessageAsJson(string webMessageAsJson) |  |
|PostWebMessageAsString | PostWebMessageAsString(string webMessageAsString)  |  |
|add_WebMessageReceived | RegisterWebMessageReceived(Action<WebMessageReceivedEventArgs> callback) |  |
|remove_WebMessageReceived | UnregisterWebMessageReceived(long token) |  |
|Close | Close() |  |
|CallDevToolsProtocolMethod | CallDevToolsProtocolMethod(string methodName, string parametersAsJson) |  |
|add_DevToolsProtocolEventReceived | RegisterDevToolsProtocolEventReceived(string eventName, Action<DevToolsProtocolEventReceivedEventArgs> callback) |  |
|remove_DevToolsProtocolEventReceived| UnregisterDevToolsProtocolEventReceived(long token) |  |
|get_BrowserProcessId | BrowserProcessId {get;}  |  |
|get_CanGoBack| CanGoBack {get;} |  |
|get_CanGoForward| CanGoForward {get;}  |  |
|GoBack| GoBack()  |  |
|GoForward| GoForward() |  |

### IWebView2WebView3

|IWebView2WebView3 Native|WebView2WebView class| Notes |
|---|---|---|
|Stop | Stop() | |
|add_NewWindowRequested| RegisterNewWindowRequested(Action<NewWindowRequestedEventArgs> callback) | Event fires but crash when setting popup window |
|remove_NewWindowRequested| UnregisterNewWindowRequested(long token) | |
|add_DocumentTitleChanged| RegisterDocumentTitledChanged(Action<DocumentTitleChangedEventArgs> callback) | |
|remove_DocumentTitleChanged| UnregisterDocumentTitledChanged(long token) | |
|get_DocumentTitle| DocumentTitle {get;} | |


### IWebView2WebView4

|IWebView2WebView4 Native|WebVeiw2Control|Tested|
|---|---|---|
|AddRemoteObject|  | Not implemented yet |
|RemoveRemoteObject|  | Not implemented yet |
|OpenDevToolsWindow| OpenDevToolsWindow()  | |
|add_AcceleratorKeyPressed| RegisterAcceleratorKeyPressed(Action<AcceleratorKeyPressedEventArgs> callback)  | |
|remove_AcceleratorKeyPressed| UnregisterAcceleratorKeyPressed(long token)  | |
