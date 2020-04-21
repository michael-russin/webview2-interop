using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// HTTP response headers. Used to construct a WebResourceResponse for the
    /// WebResourceRequested event.
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("3E81928E-DDAE-4B3C-BCEF-DB2752BCFA1E")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2HttpResponseHeaders
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
        void GetHeaders([In, MarshalAs(UnmanagedType.LPWStr)] string name, out ICoreWebView2HttpHeadersCollectionIterator iterator);

        /// <summary>
        /// Gets an iterator over the collection of entire response headers.
        /// </summary>
        /// <param name="iterator"></param>
        void GetIterator(out ICoreWebView2HttpHeadersCollectionIterator iterator);
	}
}