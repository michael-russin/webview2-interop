using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Russinsoft.WebView2.Interop
{
    /// <summary>
    /// HTTP response headers. Used to construct a WebResourceResponse for the
    /// WebResourceRequested event.
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("6D1A13A6-C677-41AA-852F-827B53F35301")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2HttpResponseHeaders
	{
        /// <summary>
        /// Appends header line with name and value.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        void AppendHeader([In, MarshalAs(UnmanagedType.LPWStr)] string name, [In, MarshalAs(UnmanagedType.LPWStr)] string value);

        /// <summary>
        /// Checks whether the headers contain entries matching the header name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        int Contains([In, MarshalAs(UnmanagedType.LPWStr)] string name);

        /// <summary>
        /// Gets the header values matching the name.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="iterator"></param>
        void GetHeaders([In, MarshalAs(UnmanagedType.LPWStr)] string name, out IWebView2HttpHeadersCollectionIterator iterator);

        /// <summary>
        /// Gets an iterator over the collection of entire response headers.
        /// </summary>
        /// <param name="iterator"></param>
        void GetIterator(out IWebView2HttpHeadersCollectionIterator iterator);
	}
}