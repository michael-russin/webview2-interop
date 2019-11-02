using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Russinsoft.WebView2.Interop
{
    /// <summary>
    /// Event args for the PermissionRequested event.
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("8D8DA0E4-A071-486F-85AA-31B4B2BADC61")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2PermissionRequestedEventArgs
	{
        /// <summary>
        /// The origin of the web content that requests the permission.
        /// </summary>
        [DispId(1610678272)]
        string Uri
        {
            [return: MarshalAs(UnmanagedType.LPWStr)]
            get;
        }

        /// <summary>
        /// The type of the permission that is requested.
        /// </summary>
		[DispId(1610678273)]
		WEBVIEW2_PERMISSION_TYPE PermissionType
		{
			
			get;
		}

        /// <summary>
        /// True when the permission request was initiated through a user gesture.
        /// Note that being initiated through a user gesture doesn't mean that user
        /// intended to access the associated resource.
        /// </summary>
        [DispId(1610678274)]
        bool IsUserInitiated
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
        }

        /// <summary>
        /// The status of a permission request, i.e. whether the request is granted.
        /// Default value is WEBVIEW2_PERMISSION_STATE_DEFAULT.
        /// </summary>
        [DispId(1610678275)]
		WEBVIEW2_PERMISSION_STATE State
		{
			
			get;
			
			set;
		}

        /// <summary>
        /// GetDeferral can be called to return an IWebView2Deferral object.
        /// Developer can use the deferral object to make the permission decision
        /// at a later time.
        /// </summary>
        /// <returns></returns>
        IWebView2Deferral GetDeferral();
	}
}