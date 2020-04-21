using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace MtrDev.WebView2.Interop
{
#pragma warning disable CS0108

    /// <summary>
    /// Checked
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("7DC2EC84-56CB-4FCC-B4C6-A9F85C7B2894")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICoreWebView2Environment
    {
        void CreateCoreWebView2Host([In] IntPtr parentWindow, [In]ICoreWebView2CreateCoreWebView2HostCompletedHandler handler);

        void CreateWebResourceResponse(IStream Content, 
                                           int StatusCode, 
                                           [In, MarshalAs(UnmanagedType.LPWStr)] string reasonPhrase, 
                                           [In, MarshalAs(UnmanagedType.LPWStr)] string headers, 
                                           ref ICoreWebView2WebResourceResponse response);

        /// <summary>
        /// The browser version info of the current IWebView2Environment,
        /// including channel name if it is not the stable channel.
        /// This matches the format of the GetWebView2BrowserVersionInfo API.
        /// Channel names are 'beta', 'dev', and 'canary'.
        /// </summary>
        [DispId(1610678274)]
        string BrowserVersionInfo
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
        void add_NewVersionAvailable([In] ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler, out EventRegistrationToken token);


        void remove_NewVersionAvailable([In] EventRegistrationToken token);
    }
}