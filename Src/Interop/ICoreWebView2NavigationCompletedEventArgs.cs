using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// Event args for the NavigationCompleted event.
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("1337EED4-BC5B-48FB-9672-80D18733CFD5")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2NavigationCompletedEventArgs
	{
        /// <summary>
        /// True when the navigation is successful. This
        /// is false for a navigation that ended up in an error page (failures due to
        /// no network, DNS lookup failure, HTTP server responds with 4xx), but could
        /// also be false for additional things such as window.stop() called on
        /// navigated page.
        /// </summary>
        [DispId(1610678272)]
		bool IsSuccess
		{
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
        }

        /// <summary>
        /// The error code if the navigation failed.
        /// </summary>
		[DispId(1610678273)]
		WEBVIEW2_WEB_ERROR_STATUS WebErrorStatus
		{
			get;
		}

        long NavigationId
        {
            get;
        }
	}
}