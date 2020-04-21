using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// Checked
    /// </summary>
    [ComVisible(true),
     ComImport,
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
     Guid("6ddf7138-a19b-4e55-8994-8a198b07f492")]
    public interface ICoreWebView2Host
    {
        [DispId(1610678272)]
        bool IsVisible
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
            [param: MarshalAs(UnmanagedType.Bool)]
            set;
        }

        [DispId(1610678274)]
        tagRECT Bounds { get; set; }

        [DispId(1610678276)]
        double ZoomFactor { get; set; }

        void add_ZoomFactorChanged([In] ICoreWebView2ZoomFactorChangedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_ZoomFactorChanged([In] EventRegistrationToken token);

        void SetBoundsAndZoomFactor([In] tagRECT token, [In] double zoom);

        void MoveFocus([In] WEBVIEW2_MOVE_FOCUS_REASON reason);

        void add_MoveFocusRequested([In] ICoreWebView2MoveFocusRequestedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_MoveFocusRequested([In] EventRegistrationToken token);

        void add_GotFocus([In] ICoreWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_GotFocus([In] EventRegistrationToken token);

        void add_LostFocus([In] ICoreWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_LostFocus([In] EventRegistrationToken token);

        void add_AcceleratorKeyPressed([In] ICoreWebView2AcceleratorKeyPressedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_AcceleratorKeyPressed([In] EventRegistrationToken token);

        [DispId(1610678290)]
        IntPtr ParentWindow
        {
            get;
            set;
        }

        /// <summary>
        /// This is a notification separate from put_Bounds that tells WebView its
        /// parent (or any ancestor) HWND moved. This is needed for accessibility and
        /// certain dialogs in WebView to work correctly.
        /// \snippet AppWindow.cpp NotifyParentWindowPositionChanged
        /// </summary>
        void NotifyParentWindowPositionChanged();

        void Close();

        [DispId(1610678294)]
        ICoreWebView2 CoreWebView2
        {
            get;
        }
        //void CoreWebView2([MarshalAs(UnmanagedType.Interface)] out ICoreWebView2 coreWebView2);
    }

    //[ComVisible(true),
    //ComImport,
    //InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    //Guid("6ddf7138-a19b-4e55-8994-8a198b07f492")]
    //public interface ICoreWebView2Host2
    //{
    //    void get_IsVisible([Out, MarshalAs(UnmanagedType.Bool)]  out bool isVisible);
    //    void put_IsVisible([In, MarshalAs(UnmanagedType.Bool)] bool isVisible);
    //    //[DispId(1610678272)]
    //    //bool IsVisible
    //    //{
    //    //    [return: MarshalAs(UnmanagedType.Bool)]
    //    //    get;
    //    //    [param: MarshalAs(UnmanagedType.Bool)]
    //    //    set;
    //    //}

    //    void get_Bounds([Out] out tagRECT bounds);
    //    void put_Bounds([In] tagRECT bounds);
    //    //[DispId(1610678274)]
    //    //tagRECT Bounds { get; set; }

    //    void get_ZoomFactor([Out] out double zoomFactor);
    //    void put_ZoomFactor([In] double zoomFactor);
    //    //[DispId(1610678276)]
    //    //double ZoomFactor { get; set; }

    //    void add_ZoomFactorChanged([In] ICoreWebView2ZoomFactorChangedEventHandler eventHandler, [Out] out EventRegistrationToken token);

    //    void remove_ZoomFactorChanged([In] EventRegistrationToken token);

    //    void SetBoundsAndZoomFactor([In] tagRECT bounds, [In] double zoomFactor);

    //    void MoveFocus([In] WEBVIEW2_MOVE_FOCUS_REASON reason);

    //    void add_MoveFocusRequested([In] ICoreWebView2MoveFocusRequestedEventHandler eventHandler, [Out] out EventRegistrationToken token);

    //    void remove_MoveFocusRequested([In] EventRegistrationToken token);

    //    void add_GotFocus([In] ICoreWebView2FocusChangedEventHandler eventHandler, [Out]out EventRegistrationToken token);

    //    void remove_GotFocus([In] EventRegistrationToken token);

    //    void add_LostFocus([In] ICoreWebView2FocusChangedEventHandler eventHandler, [Out]out EventRegistrationToken token);

    //    void remove_LostFocus([In] EventRegistrationToken token);

    //    void add_AcceleratorKeyPressed([In] ICoreWebView2AcceleratorKeyPressedEventHandler eventHandler, [Out] out EventRegistrationToken token);

    //    void remove_AcceleratorKeyPressed([In] EventRegistrationToken token);

    //    void get_ParentWindow([Out] IntPtr topLevelWindow);
    //    void put_ParentWindow([In] IntPtr topLevelWindow);
    //    //[DispId(1610678290)]
    //    //IntPtr ParentWindow
    //    //{
    //    //    get;
    //    //    set;
    //    //}

    //    ///// <summary>
    //    ///// This is a notification separate from put_Bounds that tells WebView its
    //    ///// parent (or any ancestor) HWND moved. This is needed for accessibility and
    //    ///// certain dialogs in WebView to work correctly.
    //    ///// \snippet AppWindow.cpp NotifyParentWindowPositionChanged
    //    ///// </summary>
    //    void NotifyParentWindowPositionChanged();

    //    void Close();

    //    ////        [DispId(1610678294)]
    //    ////        ICoreWebView2 CoreWebView2
    //    ////        {
    //    ////            get;
    //    ////        }
    //    //void CoreWebView2([MarshalAs(UnmanagedType.Interface)] out ICoreWebView2 coreWebView2);
    //    void CoreWebView2([MarshalAs(UnmanagedType.Interface)] out object coreWebView2);
    //}
}
