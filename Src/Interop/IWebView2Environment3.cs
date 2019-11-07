using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
#pragma warning disable CS0108

    /// <summary>
    /// Checked
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("D82C6A26-370F-4084-8149-C08FF1598C9B")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWebView2Environment3 : IWebView2Environment2
    {
        new void CreateWebView([In] IntPtr parentWindow, [In]IWebView2CreateWebViewCompletedHandler handler);

        new void CreateWebResourceResponse(IStream Content, int StatusCode, [In, MarshalAs(UnmanagedType.LPWStr)] string ReasonPhrase, [In, MarshalAs(UnmanagedType.LPWStr)] string Headers, ref IWebView2WebResourceResponse Response);

        /// <summary>
        /// The browser version info of the current IWebView2Environment,
        /// including channel name if it is not the stable channel.
        /// This matches the format of the GetWebView2BrowserVersionInfo API.
        /// Channel names are 'beta', 'dev', and 'canary'.
        /// </summary>
        [DispId(1610743808)]
        new string BrowserVersionInfo
        {
            [return: MarshalAs(UnmanagedType.LPWStr)]
            get;
        }

        /// <summary>
        /// The NewVersionAvailable event fires when a newer version of the
        /// Edge browser is installed and available to use via WebView2.
        /// To use the newer version of the browser you must create a new
        /// IWebView2Environment and IWebView2WebView.
        /// </summary>
        /// <param name="eventHandler"></param>
        /// <param name="token"></param>
        void add_NewVersionAvailable([In] IWebView2NewVersionAvailableEventHandler eventHandler, out EventRegistrationToken token);


        void remove_NewVersionAvailable([In] EventRegistrationToken token);
    }
}