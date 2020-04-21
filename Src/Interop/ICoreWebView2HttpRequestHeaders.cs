using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// HTTP request headers. Used to inspect or modify the HTTP request on
    /// WebResourceRequested event and NavigationStarting event.
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("160B895B-D0AF-4A42-A14F-5571CFA68B03")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2HttpRequestHeaders
	{
        /// <summary>
        /// Gets the header value matching the name.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        void GetHeader([In, MarshalAs(UnmanagedType.LPWStr)] string name, [MarshalAs(UnmanagedType.LPWStr)] out string value);

        void GetHeader([In, MarshalAs(UnmanagedType.LPWStr)] string name,  out ICoreWebView2HttpHeadersCollectionIterator iterator);

        /// <summary>
        /// Checks whether the headers contain an entry matching the header name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        int Contains([In, MarshalAs(UnmanagedType.LPWStr)] string name);

        /// <summary>
        /// Adds or updates header that matches the name.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        void SetHeader([In, MarshalAs(UnmanagedType.LPWStr)] string name, [In, MarshalAs(UnmanagedType.LPWStr)] string value);

        /// <summary>
        /// Removes header that matches the name.
        /// </summary>
        /// <param name="name"></param>
        void RemoveHeader([In, MarshalAs(UnmanagedType.LPWStr)] string name);

        /// <summary>
        /// Gets an iterator over the collection of request headers.
        /// </summary>
        /// <param name="iterator"></param>
        void GetIterator(out ICoreWebView2HttpHeadersCollectionIterator iterator);
	}
}