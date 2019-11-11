using MtrDev.WebView2.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MtrDev.WebView2.Interop.Test;
using System.Reflection;
using System.IO;
using Newtonsoft.Json.Linq;
using MtrDev.WebView2.Wrapper;
using MtrDev.WebView2.Wrapper.Handlers;

namespace WebView2.Interop.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private WebView2WebView _webView;
        private string _browserVersion;
        private WebView2Environment _environment;

        private void Form1_Load(object sender, EventArgs e)
        {
            Action<CreateWebViewCompletedEventArgs> viewCompleteHandler = new Action<CreateWebViewCompletedEventArgs>((viewArgs) =>
            {
                _webView = viewArgs.WebView;

                BrowserCreated();

                _webView.Bounds = new Rectangle(new Point(0, 0), new Size(panelBrowser.Bounds.Width, panelBrowser.Bounds.Height));

                _webView.Navigate(textBoxUrl.Text);
            });


            EnvironmentCompletedHandler envHandler = new EnvironmentCompletedHandler((envArgs) =>
            {
                _environment = envArgs.WebViewEnvironment;
                _browserVersion = _environment.BrowserVersionInfo;

                _environment.CreateWebView(this.panelBrowser.Handle, viewCompleteHandler);
            });

            //string canary = @"C:\Users\u0041266\AppData\Local\Microsoft\Edge SXS\Application\80.0.320.0";
            string canary = string.Empty;
            Globals.CreateWebView2EnvironmentWithDetails(canary, string.Empty, string.Empty, envHandler);
        }

        private bool _isVisible = false;
        private void BrowserCreated()
        {
            _isVisible = true;
            buttonVisible.Enabled = true;
            buttonReload.Enabled = true;
            buttonGo.Enabled = true;
            buttonZoom.Enabled = true;

            AddNavigationHandlers();
            AddZoomHandler();
            AddFocusHandler();
            AddPermissionHandler();
            AddTitleChangedHandler();
            AddProcessFailedHandler();
            //AddResourceRequestedHandler();
            AddScriptDialogHandler();
            AddNewWindowHandler();
            AddWebMessageHandler();
            AddAcceleratorKeyHandler();

            // Enable listening for security events to update secure icon
            _webView.CallDevToolsProtocolMethod("Security.enable", "{}", null);

            AddDevToolsProtocolMethodHandler("Security.securityStateChanged");

            UpdateUi();
        }

        private void UpdateUi()
        {
            textBoxProcessId.Text = _webView.BrowserProcessId.ToString();
            textBoxZoomFactor.Text = _webView.ZoomFactor.ToString();
            textBoxVersion.Text = _browserVersion;
            labelSource.Text = _webView.Source;
            buttonGoForward.Enabled = _webView.CanGoForward;
            buttonGoBack.Enabled = _webView.CanGoBack;
        }

        long _startingToken;
        long _navCompletedToken;
        long _documentStateChangedToken;
        long _frameNavigationStartingToken;

        private void AddNavigationHandlers()
        {
            if (_startingToken <= 0)
            {
                _startingToken = _webView.RegisterNavigationStarting(OnNavigationStarting);
            }
            if (_documentStateChangedToken <= 0)
            {
                _documentStateChangedToken = _webView.RegisterDocumentStateChanged(OnDocumentStateChanged);
            }
            if (_navCompletedToken <= 0)
            {
                _navCompletedToken = _webView.RegisterNavigationCompleted(OnNavigationCompleted);
            }

            if (_frameNavigationStartingToken <=0 )
            {
                _frameNavigationStartingToken = _webView.RegisterFrameNavigationStarting(OnFrameNavigationStarting);
            }
        }

        private void RemoveNavigationHandlers()
        {
            if (_startingToken > 0)
            {
                _webView.UnregisterNavigationStarting(_startingToken);
                _startingToken = 0;
            }

            if (_documentStateChangedToken> 0)
            {
                _webView.UnregisterDocumentStateChanged(_documentStateChangedToken);
                _documentStateChangedToken = 0;
            }

            if (_navCompletedToken > 0)
            {
                _webView.UnregisterNavigationCompleted(_navCompletedToken);
                _navCompletedToken = 0;
            }

            if (_frameNavigationStartingToken > 0)
            {
                _webView.UnregisterFrameNavigationStarting(_frameNavigationStartingToken);
                _frameNavigationStartingToken = 0;
            }
        }

        private long _zoomChangedToken;

        private void AddZoomHandler()
        {
            if (_zoomChangedToken <= 0)
            {
                _zoomChangedToken = _webView.RegisterZoomFactorChanged(OnZoomChanged);
            }
        }

        private void RemoveZoomHandlers()
        {
            if (_zoomChangedToken > 0)
            {
                _webView.UnregisterZoomFactorChanged(_zoomChangedToken);
                _zoomChangedToken = 0;
            }
        }

        private long _moveFocusRequestedToken;
        private long _lostFocusToken;
        private long _gotFocusToken;


        private void AddFocusHandler()
        {
            if (_moveFocusRequestedToken <= 0)
            {
                _moveFocusRequestedToken = _webView.RegisterMoveFocusRequested(OnMoveFocusRequested);
            }

            if (_lostFocusToken <= 0)
            {
                _lostFocusToken = _webView.RegisterLostFocus(OnLostFocus);
            }

            if (_gotFocusToken <= 0)
            {
                _gotFocusToken = _webView.RegisterGotFocus(OnGotFocus);
            }
        }

        private void RemoveFocusHandler()
        {
            if (_moveFocusRequestedToken > 0)
            {
                _webView.UnregisterMoveFocusRequested(_moveFocusRequestedToken);
                _moveFocusRequestedToken = 0;
            }

            if (_lostFocusToken > 0)
            {
                _webView.UnregisterLostFocus(_lostFocusToken);
                _lostFocusToken = 0;
            }

            if (_gotFocusToken > 0)
            {
                _webView.UnregisterGotFocus(_gotFocusToken);
                _gotFocusToken = 0;
            }
        }

        private long _permissionRequestedToken;

        private void AddPermissionHandler()
        {
            if (_permissionRequestedToken <= 0)
            {
                _permissionRequestedToken = _webView.RegisterPermissionRequested(OnPermissionRequested);
            }
        }

        private void RemovePermissionHandler()
        {
            if (_permissionRequestedToken > 0)
            {
                _webView.UnregisterPermissionRequested(_permissionRequestedToken);
                _permissionRequestedToken = 0;
            }
        }

        private long _devToolsProtocol;

        private void AddDevToolsProtocolMethodHandler(string eventName)
        {
            if (_devToolsProtocol <= 0)
            {
                _devToolsProtocol = _webView.RegisterDevToolsProtocolEventReceived(eventName, OnDevToolsProtocolEventReceived);
            }
        }

        private void RemoveDevToolsProtocolMethodHandler(string eventName)
        {
            if (_devToolsProtocol > 0)
            {
                _webView.UnregisterDevToolsProtocolEventReceived(_devToolsProtocol);
                _devToolsProtocol = 0;
            }
        }


        private long _titleChangedToken;

        private void AddTitleChangedHandler()
        {
            if (_titleChangedToken <= 0)
            {
                _titleChangedToken = _webView.RegisterDocumentTitledChanged(OnDocumentTitleChanged);
            }
        }

        private void RemoveTitleChangedHandler()
        {
            if (_titleChangedToken > 0)
            {
                _webView.UnregisterDocumentTitledChanged(_titleChangedToken);
                _titleChangedToken = 0;
            }
        }

        private long _processFailedToken;

        private void AddProcessFailedHandler()
        {
            if (_processFailedToken <= 0)
            {
                _processFailedToken = _webView.RegisterProcessFailed(OnProcessFailed);
            }
        }

        private void RemoveProcessFailedHandler()
        {
            if (_processFailedToken > 0)
            {
                _webView.UnregisterProcessFailed(_processFailedToken);
                _processFailedToken = 0;
            }
        }

        private long _resourceRequestedToken;

        private void AddResourceRequestedHandler()
        {
            if (_resourceRequestedToken <= 0)
            {
                WebResourceRequestedEventHandler handler = new WebResourceRequestedEventHandler(OnResourceRequested);
                string[] filter = new string[1];
                filter[0] = "*";
                WEBVIEW2_WEB_RESOURCE_CONTEXT[] context = new WEBVIEW2_WEB_RESOURCE_CONTEXT[1] {
                    WEBVIEW2_WEB_RESOURCE_CONTEXT.WEBVIEW2_WEB_RESOURCE_CONTEXT_ALL
                };
                _resourceRequestedToken = _webView.RegisterWebResourceRequested(ref filter[0], ref context[0], OnResourceRequested);
            }
        }

        private void RemoveResourceRequestedHandler()
        {
            if (_resourceRequestedToken > 0)
            {
                _webView.UnregisterWebResourceRequested(_resourceRequestedToken);
                _resourceRequestedToken = 0;
            }
        }

        private long _scriptDialogToken;

        private void AddScriptDialogHandler()
        {
            if (_scriptDialogToken <= 0)
            {
                _scriptDialogToken = _webView.RegisterScriptDialogOpening(OnScriptDialogOpeningEvent);
            }
        }
        private void RemoveScriptDialogHandler()
        {
            if (_scriptDialogToken > 0)
            {
                _webView.UnregisterScriptDialogOpening(_scriptDialogToken);
                _scriptDialogToken = 0;
            }
        }

        private long _newWindowToken;

        private void AddNewWindowHandler()
        {
            if (_newWindowToken <= 0)
            {
                _newWindowToken = _webView.RegisterNewWindowRequested(OnNewWindowRequested);
            }
        }

        private void RemoveNewWindow()
        {
            if (_newWindowToken > 0)
            {
                _webView.UnregisterNewWindowRequested(_newWindowToken);
                _newWindowToken = 0;
            }
        }

        private long _webMessageToken;

        private void AddWebMessageHandler()
        {
            if (_webMessageToken <= 0)
            {
                _webMessageToken = _webView.RegisterWebMessageReceived(OnWebMessageRecieved);
            }
        }

        private void RemoveWebMessageHandler()
        {
            if (_webMessageToken > 0)
            {
                _webView.UnregisterWebMessageReceived(_webMessageToken);
                _webMessageToken = 0;
            }
        }

        private long _acceleratorKeyToken;
        private void AddAcceleratorKeyHandler()
        {
            if (_acceleratorKeyToken <= 0)
            {
                _acceleratorKeyToken = _webView.RegisterAcceleratorKeyPressed(OnAcceleratorKeyPressed);
            }
        }

        private void RemoveAcceleratorKeyHandler()
        {
            if (_acceleratorKeyToken > 0)
            {
                _webView.UnregisterAcceleratorKeyPressed(_acceleratorKeyToken);
                _acceleratorKeyToken = 0;
            }
        }


        private void OnScriptDialogOpeningEvent(ScriptDialogOpeningEventArgs args)
        {
            AddMessage("ScriptDialogOpeningEventArgs : " + args);
            if (MessageBox.Show(this, args.Message, "Alert", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                args.Accept();
            }
        }

        private void OnAcceleratorKeyPressed(AcceleratorKeyPressedEventArgs args)
        {
            AddMessage("AcceleratorKeyPressedEventArgs : " + args);
        }


        private void OnNewWindowRequested(NewWindowRequestedEventArgs args)
        {
            AddMessage("NewWindowRequestedEventArgs : " + args);

            PopupWindow popup = new PopupWindow(_environment, args);
            popup.Owner = this;
            popup.Show();
        }

        private void OnWebMessageRecieved(WebMessageReceivedEventArgs args)
        {
            AddMessage("WebMessageReceivedEventArgs : " + args);
        }


        private void OnDevToolsProtocolEventReceived(DevToolsProtocolEventReceivedEventArgs args)
        {
            AddMessage("DevToolsProtocolEventReceivedEventArgs : " + args);
        }


        private void OnResourceRequested(WebResourceRequestedEventArgs args)
        {
            AddMessage("ProcessFailedEventArgs : " + args);
        }


        private void OnProcessFailed(ProcessFailedEventArgs args)
        {
            AddMessage("ProcessFailedEventArgs : " + args);
        }


        private void OnDocumentTitleChanged(DocumentTitleChangedEventArgs args)
        {
            AddMessage("DocumentTitleChangedEventArgs : " + args);
            string title = args.Title;
            textBoxTitle.Text = title;
        }

        private void OnPermissionRequested(PermissionRequestedEventArgs args)
        {
            AddMessage("PermissionRequestedEventArgs : " + args);
        }


        private void OnGotFocus(FocusChangedEventEventArgs args)
        {
            AddMessage("OnGotFocus FocusChangedEventEventArgs : " + args);
        }

        private void OnLostFocus(FocusChangedEventEventArgs args)
        {
            AddMessage("OnLostFocus FocusChangedEventEventArgs : " + args);
        }

        private void OnMoveFocusRequested(MoveFocusRequestedEventArgs args)
        {
            AddMessage("MoveFocusRequestedEventArgs : " + args);
        }


        private void OnZoomChanged(ZoomFactorCompletedEventArgs args)
        {
            AddMessage("ZoomFactorCompletedEventArgs : " + args);
            UpdateUi();
        }

        private void OnFrameNavigationStarting(NavigationStartingEventArgs args)
        {
            AddMessage("OnFrameNavigationStarting : " + args);
        }

        private void OnDocumentStateChanged(DocumentStateChangedEventArgs args)
        {
            AddMessage("DocumentStateChangedEventArgs : " + args);
        }

        private void OnNavigationStarting(NavigationStartingEventArgs args)
        {
            AddMessage("NavigationStartingEventArgs : " + args);
        }

        private void OnNavigationCompleted(NavigationCompletedEventArgs args)
        {
            AddMessage("NavigationCompletedEventArgs : " + args);
            UpdateUi();
        }

        private void buttonVisible_Click(object sender, EventArgs e)
        {
            _isVisible = !_isVisible;
            _webView.IsVisible = _isVisible;
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            _webView.GoBack();
        }

        private void buttonGoForward_Click(object sender, EventArgs e)
        {
            _webView.GoForward();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            _webView.Reload();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            _webView.Navigate(textBoxUrl.Text);
        }

        private void buttonAddNavHandlers_Click(object sender, EventArgs e)
        {
            AddNavigationHandlers();
        }

        private void buttonRemoveNAvHandlers_Click(object sender, EventArgs e)
        {
            RemoveNavigationHandlers();
        }

        private void buttonZoom_Click(object sender, EventArgs e)
        {
            _webView.ZoomFactor = .75;
        }

        private void buttonAddFocusHandler_Click(object sender, EventArgs e)
        {
            AddFocusHandler();
        }

        private void buttonDeletFocusHandlers_Click(object sender, EventArgs e)
        {
            RemoveFocusHandler();
        }

        private void AddMessage(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
            listBoxMessages.Items.Add(message);
            listBoxMessages.SelectedIndex = listBoxMessages.Items.Count-1;
        }

        private void buttonAddPermissionHandler_Click(object sender, EventArgs e)
        {
            AddPermissionHandler();
        }

        private void buttonDelPermissionHandler_Click(object sender, EventArgs e)
        {
            RemovePermissionHandler();
        }

        private void buttonPermissionTest_Click(object sender, EventArgs e)
        {
            textBoxUrl.Text = "https://acme.com/webapis/geolocation.html";
            _webView.Navigate(textBoxUrl.Text);
        }

        private void buttonAddTitleChanged_Click(object sender, EventArgs e)
        {
            AddTitleChangedHandler();
        }

        private void buttonDelTitleHandler_Click(object sender, EventArgs e)
        {
            RemoveTitleChangedHandler();
        }

        private void buttonKill_Click(object sender, EventArgs e)
        {
            uint processId = _webView.BrowserProcessId;
            Process process = Process.GetProcessById((int)processId);
            if (process != null)
            {
                process.Kill();
            }
        }

        private void buttonAddProcessFailed_Click(object sender, EventArgs e)
        {
            AddProcessFailedHandler();
        }

        private void buttonRemoveProcessFailed_Click(object sender, EventArgs e)
        {
            RemoveProcessFailedHandler();
        }

        private void buttonAlert_Click(object sender, EventArgs e)
        {
            _webView.Settings.AreDefaultScriptDialogsEnabled = false;
            textBoxUrl.Text = "https://www.w3schools.com/js/tryit.asp?filename=tryjs_alert";
            _webView.Navigate(textBoxUrl.Text);
        }

        private void button1AddScriptDialog_Click(object sender, EventArgs e)
        {
            AddScriptDialogHandler();
            _webView.Settings.AreDefaultScriptDialogsEnabled = false;
        }

        private void buttonDelScriptDialog_Click(object sender, EventArgs e)
        {
            _webView.Settings.AreDefaultScriptDialogsEnabled = true;
            RemoveScriptDialogHandler();
        }

        string _scriptId = string.Empty;
        private void buttonAddStartScript_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_scriptId))
            {
                _webView.AddScriptToExecuteOnDocumentCreated("console.log('the page was loaded')", OnAddScriptToExecute);
            }
        }

        private void buttonDeleteStartScript_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_scriptId))
            {
                _webView.RemoveScriptToExecuteOnDocumentCreated(_scriptId);
            }
        }

        private void OnAddScriptToExecute(AddScriptToExecuteOnDocumentCreatedCompletedEventArgs obj)
        {
            _scriptId = obj.Id;
        }

        private void buttonExecScript_Click(object sender, EventArgs e)
        {
            _webView.ExecuteScript("console.log('testing execute script')", OnScriptExecuted);
        }

        private void OnScriptExecuted(ExecuteScriptCompletedEventArgs args)
        {
            AddMessage("ExecuteScriptCompletedEventArgs : " + args);
        }

        private void buttonAddNewWindow_Click(object sender, EventArgs e)
        {
            AddNewWindowHandler();
        }

        private void buttonDelNewWindow_Click(object sender, EventArgs e)
        {
            RemoveNewWindow();
        }

        private void buttonNavigateHtml_Click(object sender, EventArgs e)
        {
            string page = "<!DOCTYPE html><html><head><meta charset = 'UTF-8'><title>Loaded from a string</title></head>" +
                "<body><p>Hi I'm a dot net string</p></body></html>";
            _webView.NavigateToString(page);
        }

        private void buttonSetFocus_Click(object sender, EventArgs e)
        {
            _webView.MoveFocus(WEBVIEW2_MOVE_FOCUS_REASON.WEBVIEW2_MOVE_FOCUS_REASON_PROGRAMMATIC);
        }

        private void buttonClearCache_Click(object sender, EventArgs e)
        {
            _webView.CallDevToolsProtocolMethod("Network.clearBrowserCache", "{}", OnDevToolProtocolComplete);
            _webView.CallDevToolsProtocolMethod("Network.clearBrowserCookies", "{}", OnDevToolProtocolComplete);
        }

        private void OnDevToolProtocolComplete(CallDevToolsProtocolMethodCompletedEventArgs args)
        {
            AddMessage("CallDevToolsProtocolMethodCompletedEventArgs : " + args);
        }

        private void buttonAddDevProtocol_Click(object sender, EventArgs e)
        {
            AddDevToolsProtocolMethodHandler("Security.securityStateChanged");
        }

        private void buttonRemoveDevProtocol_Click(object sender, EventArgs e)
        {
            RemoveDevToolsProtocolMethodHandler("Security.securityStateChanged");
        }

        string GetFullPathFor(string relativePath)
        {
            var location = new Uri(Assembly.GetEntryAssembly().GetName().CodeBase);
            string fulllName = new FileInfo(location.AbsolutePath).Directory.FullName;

            return Path.Combine(fulllName, relativePath);
        }

        private void buttonMessageTest_Click(object sender, EventArgs e)
        {
            string controlsPath = GetFullPathFor("Content\\MessageTest.html");
            _webView.Navigate(controlsPath);
        }

        private void buttonPostJSON_Click(object sender, EventArgs e)
        {
            JObject jObject = new JObject();
            jObject.Add("message", JToken.FromObject(100));
            jObject.Add("args", JToken.FromObject("{}"));

            string json = jObject.ToString();

            _webView.PostWebMessageAsJson(json);
        }

        private void buttonPostString_Click(object sender, EventArgs e)
        {
            _webView.PostWebMessageAsString("I'm a string");
        }

        private void buttonAddWebMessage_Click(object sender, EventArgs e)
        {
            AddWebMessageHandler();
        }

        private void buttonRemoveWebMessage_Click(object sender, EventArgs e)
        {
            RemoveWebMessageHandler();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            _webView.Close();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            _webView.Stop();
        }

        private void buttonDevTools_Click(object sender, EventArgs e)
        {
            _webView.OpenDevToolsWindow();
        }
    }
}
