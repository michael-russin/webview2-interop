using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// An HTTP request used with the WebResourceRequested event.
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("7471A125-D5E8-45A8-B119-F9E9230D4D0B")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2WebResourceRequest
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
        ICoreWebView2HttpRequestHeaders Headers
		{
            [return: MarshalAs(UnmanagedType.Interface)]
            get;
		}
	}
}