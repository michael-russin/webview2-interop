using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// An HTTP response used with the WebResourceRequested event.
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("2B842125-E3B4-40A2-8BB8-C31AABF70E0A")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2WebResourceResponse
	{
        /// <summary>
        /// HTTP response content as stream. Stream must have all the
        /// content data available by the time this response's WebResourceRequested
        /// event deferral is completed. Stream should be agile or be created from
        /// a background thread to prevent performance impact to the UI thread.
        /// Null means no content data. IStream semantics
        /// apply (return S_OK to Read calls until all data is exhausted)
        /// </summary>
        [DispId(1610678272)]
		IStream Content
		{
            [return: MarshalAs(UnmanagedType.Interface)]
            get;

            [param: MarshalAs(UnmanagedType.Interface)]
            set;
        }

        /// <summary>
        /// Overridden HTTP response headers.
        /// </summary>
		[DispId(1610678274)]
		ICoreWebView2HttpResponseHeaders Headers
		{
            [return: MarshalAs(UnmanagedType.Interface)]
            get;
		}

        /// <summary>
        /// The HTTP response status code.
        /// </summary>
        [DispId(1610678275)]
        int StatusCode
        {

            get;

            set;
        }

        /// <summary>
        /// The HTTP response reason phrase
        /// </summary>
        [DispId(1610678277)]
		string ReasonPhrase
		{
            [return: MarshalAs(UnmanagedType.LPWStr)]
            get;
            [param: MarshalAs(UnmanagedType.LPWStr)]
            set;
		}


	}
}