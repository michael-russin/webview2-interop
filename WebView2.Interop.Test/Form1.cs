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
using MtrDev.WebView2.Interop.Test.Args;
using MtrDev.WebView2.Interop.Test.Handlers;
using System.Diagnostics;
using MtrDev.WebView2.Interop.Test;

namespace WebView2.Interop.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IWebView2WebView3 _webView;
        private IWebView2Environment2 _environment2;
        private string _browserVersion;

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateWebViewCompletedHandler viewCompleteHandler = new CreateWebViewCompletedHandler((viewArgs) =>
            {
                _webView = viewArgs.WebView;

                IWebView2WebView wv = (IWebView2WebView)_webView;

                BrowserCreated();


                _webView.Bounds = new tagRECT()
                {
                    top = 0,
                    left = 0,
                    right = panelBrowser.Bounds.Width,
                    bottom = panelBrowser.Bounds.Height
                };

                _webView.Navigate(textBoxUrl.Text);
            });


            EnvironmentCompletedHandler envHandler = new EnvironmentCompletedHandler((envArgs) =>
            {
                IWebView2Environment environment = envArgs.WebViewEnvironment;
                IWebView2Environment2 environment2 = (IWebView2Environment2)environment;
                _browserVersion = environment2.BrowserVersionInfo;
                _environment2 = environment2;

                environment.CreateWebView(this.panelBrowser.Handle, viewCompleteHandler);
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
            AddResourceRequestedHandler();
            AddScriptDialogHandler();
            AddNewWindowHandler();

            UpdateUi();
        }

        private void UpdateUi()
        {
            textBoxProcessId.Text = _webView.BrowserProcessId.ToString();
            textBoxZoomFactor.Text = _webView.ZoomFactor.ToString();
            textBoxVersion.Text = _browserVersion;
            buttonGoForward.Enabled = _webView.CanGoForward;
            buttonGoBack.Enabled = _webView.CanGoBack;
        }

        EventRegistrationToken _startingToken;
        EventRegistrationToken _navCompletedToken;
        EventRegistrationToken _documentStateChangedToken;
        EventRegistrationToken _frameNavigationStartingToken;

        private void AddNavigationHandlers()
        {
            if (_startingToken.value <= 0)
            {
                NavigationStartingEventHandler startingHandler = new NavigationStartingEventHandler(OnNavigationStarting);
                _webView.add_NavigationStarting(startingHandler, out _startingToken);
            }
            if (_documentStateChangedToken.value <= 0)
            {
                DocumentStateChangedEventHandler stateHandler = new DocumentStateChangedEventHandler(OnDocumentStateChanged);
                _webView.add_DocumentStateChanged(stateHandler, out _documentStateChangedToken);
            }
            if (_navCompletedToken.value <= 0)
            {
                WebView2NavigationCompletedEventHandler completeHandler = new WebView2NavigationCompletedEventHandler(OnNavigationCompleted);
                _webView.add_NavigationCompleted(completeHandler, out _navCompletedToken);
            }

            if (_frameNavigationStartingToken.value <=0 )
            {
                NavigationStartingEventHandler startingHandler = new NavigationStartingEventHandler(OnFrameNavigationStarting);
                _webView.add_FrameNavigationStarting(startingHandler, out _frameNavigationStartingToken);
            }
        }

        private void RemoveNavigationHandlers()
        {
            if (_startingToken.value > 0)
            {
                _webView.remove_NavigationStarting(_startingToken);
                _startingToken.value = 0;
            }

            if (_documentStateChangedToken.value > 0)
            {
                _webView.remove_DocumentStateChanged(_documentStateChangedToken);
                _documentStateChangedToken.value = 0;
            }

            if (_navCompletedToken.value > 0)
            {
                _webView.remove_NavigationCompleted(_navCompletedToken);
                _navCompletedToken.value = 0;
            }

            if (_frameNavigationStartingToken.value > 0)
            {
                _webView.remove_FrameNavigationStarting(_frameNavigationStartingToken);
                _frameNavigationStartingToken.value = 0;
            }
        }

        private EventRegistrationToken _zoomChangedToken;

        private void AddZoomHandler()
        {
            if (_zoomChangedToken.value <= 0)
            {
                ZoomFactorChangedEventHandler zoomHandler = new ZoomFactorChangedEventHandler(OnZoomChanged);
                _webView.add_ZoomFactorChanged(zoomHandler, out _zoomChangedToken);
            }
        }

        private void RemoveZoomHandlers()
        {
            if (_zoomChangedToken.value > 0)
            {
                _webView.remove_ZoomFactorChanged(_zoomChangedToken);
                _zoomChangedToken.value = 0;
            }
        }

        private EventRegistrationToken _moveFocusRequestedToken;
        private EventRegistrationToken _lostFocusToken;
        private EventRegistrationToken _gotFocusToken;


        private void AddFocusHandler()
        {
            if (_moveFocusRequestedToken.value <= 0)
            {
                MoveFocusRequestedEventHandler moveHandler = new MoveFocusRequestedEventHandler(OnMoveFocusRequested);
                _webView.add_MoveFocusRequested(moveHandler, out _moveFocusRequestedToken);
            }

            if (_lostFocusToken.value <= 0)
            {
                FocusChangedEventHandler focusLostHandler = new FocusChangedEventHandler(OnLostFocus);
                _webView.add_LostFocus(focusLostHandler, out _lostFocusToken);
            }

            if (_gotFocusToken.value <= 0)
            {
                FocusChangedEventHandler focusGotHandler = new FocusChangedEventHandler(OnGotFocus);
                _webView.add_GotFocus(focusGotHandler, out _gotFocusToken);
            }
        }

        private void RemoveFocusHandler()
        {
            if (_moveFocusRequestedToken.value > 0)
            {
                _webView.remove_MoveFocusRequested(_moveFocusRequestedToken);
                _moveFocusRequestedToken.value = 0;
            }

            if (_lostFocusToken.value > 0)
            {
                _webView.remove_LostFocus(_lostFocusToken);
                _lostFocusToken.value = 0;
            }

            if (_gotFocusToken.value > 0)
            {
                _webView.remove_GotFocus(_gotFocusToken);
                _gotFocusToken.value = 0;
            }
        }

        private EventRegistrationToken _permissionRequestedToken;

        private void AddPermissionHandler()
        {
            if (_permissionRequestedToken.value <= 0)
            {
                PermissionRequestedEventHandler permissionHandler = new PermissionRequestedEventHandler(OnPermissionRequested);
                _webView.add_PermissionRequested(permissionHandler, out _permissionRequestedToken);
            }
        }

        private void RemovePermissionHandler()
        {
            if (_permissionRequestedToken.value > 0)
            {
                _webView.remove_PermissionRequested(_permissionRequestedToken);
                _permissionRequestedToken.value = 0;
            }
        }

        private EventRegistrationToken _titleChangedToken;

        private void AddTitleChangedHandler()
        {
            if (_titleChangedToken.value <= 0)
            {
                DocumentTitleChangedEventHandler handler = new DocumentTitleChangedEventHandler(OnDocumentTitleChanged);
                _webView.add_DocumentTitleChanged(handler, out _titleChangedToken);
            }
        }

        private void RemoveTitleChangedHandler()
        {
            if (_titleChangedToken.value > 0)
            {
                _webView.remove_DocumentTitleChanged(_titleChangedToken);
                _titleChangedToken.value = 0;
            }
        }

        private EventRegistrationToken _processFailedToken;

        private void AddProcessFailedHandler()
        {
            if (_processFailedToken.value <= 0)
            {
                ProcessFailedEventHandler handler = new ProcessFailedEventHandler(OnProcessFailed);
                _webView.add_ProcessFailed(handler, out _processFailedToken);
            }
        }

        private void RemoveProcessFailedHandler()
        {
            if (_processFailedToken.value > 0)
            {
                _webView.remove_ProcessFailed(_processFailedToken);
                _processFailedToken.value = 0;
            }
        }

        private EventRegistrationToken _resourceRequestedToken;

        private void AddResourceRequestedHandler()
        {
            if (_resourceRequestedToken.value <= 0)
            {
                WebResourceRequestedEventHandler handler = new WebResourceRequestedEventHandler(OnResourceRequested);
                string[] filter = new string[1];
                filter[0] = "*";
                int [] context = new int[1] {
                    (int)WEBVIEW2_WEB_RESOURCE_CONTEXT.WEBVIEW2_WEB_RESOURCE_CONTEXT_ALL
                };
                _webView.add_WebResourceRequested(filter, context, (ulong)filter.Length, handler, out _resourceRequestedToken);
            }
        }

        private void RemoveResourceRequestedHandler()
        {
            if (_resourceRequestedToken.value > 0)
            {
                _webView.remove_WebResourceRequested(_resourceRequestedToken);
                _resourceRequestedToken.value = 0;
            }
        }

        private EventRegistrationToken _scriptDialogToken;

        private void AddScriptDialogHandler()
        {
            if (_scriptDialogToken.value <= 0)
            {
                ScriptDialogOpeningEventHandler handler = new ScriptDialogOpeningEventHandler(OnScriptDialogOpeningEvent);

                _webView.add_ScriptDialogOpening(handler, out _scriptDialogToken);
            }
        }
        private void RemoveScriptDialogHandler()
        {
            if (_scriptDialogToken.value > 0)
            {
                _webView.remove_ScriptDialogOpening(_scriptDialogToken);
                _scriptDialogToken.value = 0;
            }
        }

        private EventRegistrationToken _newWindowToken;

        private void AddNewWindowHandler()
        {
            if (_newWindowToken.value <= 0)
            {
                NewWindowRequestedEventHandler handler = new NewWindowRequestedEventHandler(OnNewWindowRequested);
                _webView.add_NewWindowRequested(handler, out _newWindowToken);
            }
        }

        private void RemoveNewWindow()
        {
            if (_newWindowToken.value > 0)
            {
                _webView.remove_NewWindowRequested(_newWindowToken);
                _newWindowToken.value = 0;
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

        private void OnNewWindowRequested(NewWindowRequestedEventArgs args)
        {
            AddMessage("NewWindowRequestedEventArgs : " + args);

            PopupWindow popup = new PopupWindow(_environment2, args);
            popup.Owner = this;
            popup.Show();
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
            string title;
            _webView.DocumentTitle(out title);
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


        private void OnZoomChanged(ZoomFactorCompletedEventArgs obj)
        {
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
                AddScriptToExecuteOnDocumentCreatedCompletedHandler handler = new AddScriptToExecuteOnDocumentCreatedCompletedHandler(OnAddScriptToExecute);
                _webView.AddScriptToExecuteOnDocumentCreated("console.log('the page was loaded')", handler);
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
            ExecuteScriptCompletedHandler handler = new ExecuteScriptCompletedHandler(OnScriptExecuted);
            _webView.ExecuteScript("console.log('testing execute script')", handler);
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
    }
}
