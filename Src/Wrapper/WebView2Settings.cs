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

namespace MtrDev.WebView2.Wrapper
{
    /// <summary>
    /// Defines properties that enable, disable, or modify WebView
    /// features. Setting changes made after NavigationStarting event will not
    /// apply until the next top level navigation.
    /// </summary>
    public class WebView2Settings: ICoreWebView2Settings
    {
        private ICoreWebView2Settings _settings;

        internal WebView2Settings(ICoreWebView2Settings settings)
        {
            _settings = (ICoreWebView2Settings)settings;
        }

        #region IWebView2Settings
        /// <summary>
        /// AreDefaultScriptDialogsEnabled is used when loading a new
        /// HTML document. If set to false, then WebView won't render the default
        /// javascript dialog box (Specifically those shown by the javascript alert,
        /// confirm, and prompt functions). Instead, if an event handler is set by
        /// SetScriptDialogOpeningEventHandler, WebView will send an event that will
        /// contain all of the information for the dialog and allow the host app to
        /// show its own custom UI.
        /// </summary>
        public bool AreDefaultScriptDialogsEnabled
        {
            get => _settings.AreDefaultScriptDialogsEnabled;
            set => _settings.AreDefaultScriptDialogsEnabled = value;
        }

        /// <summary>
        /// AreDevToolsEnabled controls whether the user is able to use the context
        /// menu or keyboard shortcuts to open the DevTools window.
        /// It is true by default.
        /// </summary>
        public bool AreDevToolsEnabled
        {
            get => _settings.AreDevToolsEnabled;
            set => _settings.AreDevToolsEnabled = value;
        }

        /// <summary>
        /// This setting is deprecated and will always return false. That means
        /// elements in the WebView will only fill the WebView bounds. This property
        /// will then be completely removed. Please listen to the
        /// ContainsFullScreenElementChanged event instead.
        /// </summary>
        public bool IsFullscreenAllowed_deprecated
        {
            get { return false; }
            set { }
        }

        /// <summary>
        /// Controls if JavaScript execution is enabled in all future
        /// navigations in the WebView.  This only affects scripts in the document;
        /// scripts injected with ExecuteScript will run even if script is disabled.
        /// It is true by default.
        /// </summary>
        public bool IsScriptEnabled
        {
            get => _settings.IsScriptEnabled;
            set => _settings.IsScriptEnabled = value;
        }

        /// <summary>
        /// IsStatusBarEnabled controls whether the status bar will be displayed. The
        /// status bar is usually displayed in the lower left of the WebView and shows
        /// things such as the URI of a link when the user hovers over it and other
        /// information. It is true by default.
        /// </summary>

        public bool IsStatusBarEnabled
        {
            get => _settings.IsStatusBarEnabled;
            set => _settings.IsStatusBarEnabled = value;
        }

        /// <summary>
        /// The IsWebMessageEnabled property is used when loading a new
        /// HTML document. If set to true, communication from the host to the
        /// webview's top level HTML document is allowed via PostWebMessageAsJson,
        /// PostWebMessageAsString, and window.chrome.webview's message event
        /// (see PostWebMessageAsJson documentation for details).
        /// Communication from the webview's top level HTML document
        /// to the host is allowed via window.chrome.webview's postMessage function
        /// and the SetWebMessageReceivedEventHandler method (see the
        /// SetWebMessageReceivedEventHandler documentation for details).
        /// If set to false, then communication is disallowed.
        /// PostWebMessageAsJson and PostWebMessageAsString will
        /// fail with E_ACCESSDENIED and window.chrome.webview.postMessage will fail
        /// by throwing an instance of an Error object.
        /// It is true by default.
        /// </summary>
        public bool IsWebMessageEnabled
        {
            get => _settings.IsWebMessageEnabled;
            set => _settings.IsWebMessageEnabled = value;
        }
        #endregion

        #region IWebView2Settings2

        /// <summary>
        /// used to prevent
        /// default context menus from being shown to user in webview. Defaults to TRUE.
        /// </summary>
        public bool AreDefaultContextMenusEnabled
        {
            get => _settings.AreDefaultContextMenusEnabled;
            set => _settings.AreDefaultContextMenusEnabled = value;
        }

        /// <summary>
        /// The AreRemoteObjectsAllowed property is used to control whether
        /// remote objects are accessible from the page in webview. Defaults to TRUE.
        /// </summary>
        public bool AreRemoteObjectsAllowed 
        { 
            get => _settings.AreRemoteObjectsAllowed; 
            set => _settings.AreRemoteObjectsAllowed = value; 
        }

        /// <summary>
        /// The IsZoomControlEnabled property is used to prevent the user from
        /// impacting the zoom of the WebView. Defaults to TRUE.
        /// When disabled, user will not be able to zoom using ctrl+/- or
        /// ctrl+mouse wheel, but the zoom can be set via put_ZoomFactor API.
        /// </summary>
        public bool IsZoomControlEnabled 
        { 
            get => _settings.IsZoomControlEnabled; 
            set => _settings.IsZoomControlEnabled = value; 
        }

        #endregion
    }
}
