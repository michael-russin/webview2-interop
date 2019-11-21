# Functionality Implementation
Below are tables of what functionality is currently supported in the interop code

### IWebView2WebView interface

|WebView2 Native| WebView2WebView class | Notes|
|---|---|---|
|get_Settings | Settings {get;}   | Working  |
|get_Source | Source  {get;}| Working  |
|Navigate(LPWSTR url) | Navigate(string url)  | Working  |
|MoveFocus(WEBVIEW2_MOVE_FOCUS_REASON reason)| MoveFocus(WEBVIEW2_MOVE_FOCUS_REASON reason)  | Working |
|NavigateToString(LPCWSTR htmlContent)| NavigateToString(string htmlContent)  | Working  |
|add_NavigationStarting| RegisterNavigationStarting(Action<NavigationStartingEventArgs> callback)  | Working |
|remove_NavigationStarting| UnregisterNavigationStarting(long)  | Working |
|add_DocumentStateChanged| long RegisterDocumentStateChanged(Action<DocumentStateChangedEventArgs> callback) event | Working |
|remove_DocumentStateChanged| void UnregisterDocumentStateChanged(long token) | Working |
|add_NavigationCompleted| RegisterNavigationCompleted(Action<NavigationCompletedEventArgs> callback) | Working |
|remove_NavigationCompleted| UnregisterNavigationCompleted(long token) | Working |
|add_FrameNavigationStarting| RegisterFrameNavigationStarting(Action<NavigationStartingEventArgs> callback)  | Working |
|remove_FrameNavigationStarting| UnregisterFrameNavigationStarting(long token)  | Working |
|add_MoveFocusRequested| RegisterMoveFocusRequested(Action<MoveFocusRequestedEventArgs> callback) | Working |
|remove_MoveFocusRequested| UnregisterMoveFocusRequested(long token) | Working |
|add_GotFocus| RegisterGotFocus(Action<FocusChangedEventEventArgs> callback) | Working |
|remove_GotFocus| UnregisterGotFocus(long token) | Working |
|add_LostFocus| RegisterLostFocus(Action<FocusChangedEventEventArgs> callback)  | Working |
|remove_LostFocus| UnregisterLostFocus(long token)  | Working |
|add_WebResourceRequested|  | Not working currently  |
|remove_WebResourceRequested|  | Not working currently |
|add_ScriptDialogOpening| RegisterScriptDialogOpening(Action<ScriptDialogOpeningEventArgs> callback)   | Working |
|remove_ScriptDialogOpening| UnregisterScriptDialogOpening(long token)   | Working |
|add_ZoomFactorChanged| RegisterZoomFactorChanged(Action<ZoomFactorCompletedEventArgs> callback)  | Working |
|remove_ZoomFactorChanged| UnregisterZoomFactorChanged(long token)  | Working |
|add_PermissionRequested| RegisterPermissionRequested(Action<PermissionRequestedEventArgs> callback) | Working |
|remove_PermissionRequested| UnregisterPermissionRequested(long token) | Working |
|add_ProcessFailed| RegisterProcessFailed(Action<ProcessFailedEventArgs> callback) | Working |
|remove_ProcessFailed| UnregisterProcessFailed(long token) | Working |
|AddScriptToExecuteOnDocumentCreated | AddScriptToExecuteOnDocumentCreated(string javaScript, Action<AddScriptToExecuteOnDocumentCreatedCompletedEventArgs> callback)  | Working |
|RemoveScriptToExecuteOnDocumentCreated| RemoveScriptToExecuteOnDocumentCreated(string id)  | Working |
|ExecuteScript | ExecuteScript(string javaScript, Action<ExecuteScriptCompletedEventArgs> callback) | Working |
|CapturePreview|   | Not implemented yet |
|Reload | Reload()  | Working  |
|get_Bounds| Bounds {get;} | Working |
|put_Bounds| Bounds {set;} | Working |
|get_ZoomFactor| ZoomFactor {get;}  | Working |
|put_ZoomFactor|  ZoomFactor {set;} | Working |
|get_IsVisible| IsVisible {get;}  | Working |
|put_IsVisible| IsVisible {set;} | Working |
|PostWebMessageAsJson | PostWebMessageAsJson(string webMessageAsJson) | Working |
|PostWebMessageAsString | PostWebMessageAsString(string webMessageAsString)  | Working |
|add_WebMessageReceived | RegisterWebMessageReceived(Action<WebMessageReceivedEventArgs> callback) | Working |
|remove_WebMessageReceived | UnregisterWebMessageReceived(long token) | Working  |
|Close | Close() | Working |
|CallDevToolsProtocolMethod | CallDevToolsProtocolMethod(string methodName, string parametersAsJson) | Working |
|add_DevToolsProtocolEventReceived | RegisterDevToolsProtocolEventReceived(string eventName, Action<DevToolsProtocolEventReceivedEventArgs> callback) | Working |
|remove_DevToolsProtocolEventReceived| UnregisterDevToolsProtocolEventReceived(long token) | Working |
|get_BrowserProcessId | BrowserProcessId {get;}  | Working |
|get_CanGoBack| CanGoBack {get;} | Working |
|get_CanGoForward| CanGoForward {get;}  | Working |
|GoBack| GoBack()  | Working |
|GoForward| GoForward() | Working |

### IWebView2WebView3

|IWebView2WebView3 Native|WebView2WebView class| Notes |
|---|---|---|
|Stop | Stop() | |
|add_NewWindowRequested| RegisterNewWindowRequested(Action<NewWindowRequestedEventArgs> callback) | Working |
|remove_NewWindowRequested| UnregisterNewWindowRequested(long token) | Working |
|add_DocumentTitleChanged| RegisterDocumentTitledChanged(Action<DocumentTitleChangedEventArgs> callback) | Working |
|remove_DocumentTitleChanged| UnregisterDocumentTitledChanged(long token) | Working |
|get_DocumentTitle| DocumentTitle {get;} | Working |


### IWebView2WebView4

|IWebView2WebView4 Native|WebVeiw2Control|Tested|
|---|---|---|
|AddRemoteObject|  | Not implemented yet |
|RemoveRemoteObject|  | Not implemented yet |
|OpenDevToolsWindow| OpenDevToolsWindow()  | Working |
|add_AcceleratorKeyPressed| RegisterAcceleratorKeyPressed(Action<AcceleratorKeyPressedEventArgs> callback)  | Working |
|remove_AcceleratorKeyPressed| UnregisterAcceleratorKeyPressed(long token)  | Working |
