using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Russinsoft.WebView2.Interop
{
    /// <summary>
    /// HTTP request headers. Used to inspect or modify the HTTP request on
    /// WebResourceRequested event and NavigationStarting event.
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("982BE490-0252-44F3-9F33-376C04885A6D")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2HttpRequestHeaders
	{
        /// <summary>
        /// Gets the header value matching the name.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        void GetHeader([In, MarshalAs(UnmanagedType.LPWStr)] string name, [MarshalAs(UnmanagedType.LPWStr)] out string value);

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
        void GetIterator(out IWebView2HttpHeadersCollectionIterator iterator);
	}
}