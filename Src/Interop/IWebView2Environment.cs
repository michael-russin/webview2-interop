using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Russinsoft.WebView2.Interop
{
    /// <summary>
    /// This represents the WebView2 Environment. WebViews created from an
    /// environment run on the Browser process specified with environment parameters
    /// and objects created from an environment should be used in the same environment.
    /// Using it in different environments are not guaranteed to be compatible and may fail.
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("33D17ECE-82FA-47D9-8978-CD17FF3C3CC6")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWebView2Environment
	{
        /// <summary>
        /// Asynchronously create a new IWebView2WebView.
        ///
        /// parentWindow is the HWND in which the WebView should be displayed and
        /// from which receive input. The WebView will add a child window to the
        /// provided window during WebView creation. Z-order and other things impacted
        /// by sibling window order will be affected accordingly.
        ///
        /// It is recommended that the application set Application User Model ID for
        /// the process or the application window. If none is set, during WebView
        /// creation a generated Application User Model ID is set to root window of
        /// parentWindow.
        /// \snippet AppWindow.cpp CreateWebView
        ///
        /// It is recommended that the application handles restart manager messages
        /// so that it can be restarted gracefully in the case when the app is using
        /// Edge for webview from a certain installation and that installation is being
        /// uninstalled. For example, if a user installs Edge from Dev channel and
        /// opts to use Edge from that channel for testing the app, and then uninstalls
        /// Edge from that channel without closing the app, the app will be restarted
        /// to allow uninstallation of the dev channel to succeed.
        /// \snippet AppWindow.cpp RestartManager
        /// </summary>
        /// <param name="parentWindow"></param>
        /// <param name="handler"></param>
        void CreateWebView([In] IntPtr parentWindow, [In] IWebView2CreateWebViewCompletedHandler handler);

        /// <summary>
        /// Create a new web resource response object. The headers is the
        /// raw response header string delimited by newline. It's also possible to
        /// create this object with empty headers string and then use the
        /// IWebView2HttpResponseHeaders to construct the headers line by line.
        /// For information on other parameters see IWebView2WebResourceResponse.
        /// </summary>
        /// <param name="Content"></param>
        /// <param name="StatusCode"></param>
        /// <param name="ReasonPhrase"></param>
        /// <param name="Headers"></param>
        /// <param name="Response"></param>
        void CreateWebResourceResponse(IStream Content, int StatusCode, [In, MarshalAs(UnmanagedType.LPWStr)] string ReasonPhrase, 
            [In, MarshalAs(UnmanagedType.LPWStr)] string Headers, ref IWebView2WebResourceResponse Response);
    }
}