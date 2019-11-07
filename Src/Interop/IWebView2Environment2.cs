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
    [Guid("013124F3-02FD-4DFF-8911-06016AF1E3EE")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWebView2Environment2 : IWebView2Environment
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
        string BrowserVersionInfo
        {
            [return: MarshalAs(UnmanagedType.LPWStr)]
            get;
        }
    }
}