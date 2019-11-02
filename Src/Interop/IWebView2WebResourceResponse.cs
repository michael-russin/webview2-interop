using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Russinsoft.WebView2.Interop
{
    /// <summary>
    /// An HTTP response used with the WebResourceRequested event.
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("297886A6-5FDF-472D-A97A-E336ECFE1352")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2WebResourceResponse
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
			
			get;
			
			set;
		}

        /// <summary>
        /// Overridden HTTP response headers.
        /// </summary>
		[DispId(1610678274)]
		IWebView2HttpResponseHeaders Headers
		{
			
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
			
			set;
		}


	}
}