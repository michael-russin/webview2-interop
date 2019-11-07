using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// An HTTP request used with the WebResourceRequested event.
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("1B3F4122-34A0-4F5D-9089-AF63C3AFE375")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2WebResourceRequest
	{
        /// <summary>
        /// The request URI.
        /// </summary>
        [DispId(1610678272)]
        string Uri
        {
            [return: MarshalAs(UnmanagedType.LPWStr)]
            get;
            [param: MarshalAs(UnmanagedType.LPWStr)]
            set;
        }

        /// <summary>
        /// The HTTP request method.
        /// </summary>
        [DispId(1610678274)]
        string Method
        {
            [return: MarshalAs(UnmanagedType.LPWStr)]
            get;
            [param: MarshalAs(UnmanagedType.LPWStr)]
            set;
        }

        /// <summary>
        /// The HTTP request message body as stream. POST data would be here.
        /// If a stream is set, which will override the message body, the stream must
        /// have all the content data available by the time this
        /// response's WebResourceRequested event deferral is completed. Stream
        /// should be agile or be created from a background STA to prevent performance
        /// impact to the UI thread. Null means no content data. IStream semantics
        /// apply (return S_OK to Read calls until all data is exhausted)
        /// </summary>
        [DispId(1610678276)]
		IStream Content
		{
			[return:MarshalAs(UnmanagedType.Interface)]
			get;

            [param: MarshalAs(UnmanagedType.Interface)]
            set;
		}

        /// <summary>
        /// The mutable HTTP request headers
        /// </summary>
		[DispId(1610678278)]
		IWebView2HttpRequestHeaders Headers
		{
            [return: MarshalAs(UnmanagedType.Interface)]
            get;
		}
	}
}