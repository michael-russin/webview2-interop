using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// Event args for the NewWindowRequested event. The event is fired when content
    /// inside webview requested to a open a new window (through window.open() etc.)
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("1F6E4074-BC3D-4381-BA8A-CF65FEAA036A")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2NewWindowRequestedEventArgs
	{
        /// <summary>
        /// The target uri of the NewWindowRequest.
        /// </summary>
        [DispId(1610678272)]
        string Uri
        {
            [return: MarshalAs(UnmanagedType.LPWStr)]
            get;
        }

        /// <summary>
        /// Sets a WebView as a result of the NewWindowRequest. The target
        /// webview should not be navigated. If the NewWindow is set, its top level
        /// window will return as the opened WindowProxy.
        /// </summary>
        //[DispId(1610678273)]
        //IWebView2WebView NewWindow
        //{
        //    //[return:MarshalAs(UnmanagedType.Interface)]
        //    get;
        //    //[param: MarshalAs(UnmanagedType.Interface)]
        //    set;
        //}

        void put_NewWindow([In] IWebView2WebView newWindow);
        /// Gets the new window.
        void get_NewWindow([Out]out IWebView2WebView newWindow);

        /// <summary>
        /// Sets whether the NewWindowRequestedEvent is handled by host. If this is false
        /// and no NewWindow is set, the WebView will open a popup
        /// window and it will be returned as opened WindowProxy.
        /// If set to true and no NewWindow is set for a window.open call, the opened
        /// WindowProxy will be for an dummy window object and no window will load.
        /// Default is false.
        /// </summary>
        [DispId(1610678275)]
		bool Handled
		{
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
            [param: MarshalAs(UnmanagedType.Bool)]
            set;
		}

        /// <summary>
        /// IsUserInitiated is true when the new window request was initiated through a user gesture
        /// such as clicking an anchor tag with target.
        /// </summary>
        [DispId(1610678277)]
		bool IsUserInitiated
		{
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
        }

        /// <summary>
        /// Obtain an IWebView2Deferral object and put the event into a deferred state.
        /// You can use the IWebView2Deferral object to complete the window open
        /// request at a later time.
        /// While this event is deferred the opener window will be returned a WindowProxy
        /// to an unnavigated window, which will navigate when the deferral is complete.
        /// </summary>
        /// <returns></returns>
        IWebView2Deferral GetDeferral();
	}
}