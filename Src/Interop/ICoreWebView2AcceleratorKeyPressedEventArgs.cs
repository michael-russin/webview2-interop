using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop
{
    [ComVisible(true)]
    [ComImport]
    [Guid("AF1587DD-E2FF-4BFF-8C1A-699D6D34C683")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICoreWebView2AcceleratorKeyPressedEventArgs
    {
        [DispId(1610678272)]
        WEBVIEW2_KEY_EVENT_TYPE KeyEventType
        {
            get;
        }

        [DispId(1610678273)]
        uint VirtualKey
        {
            get;
        }


        [DispId(1610678274)]
        int KeyEventLParam
        {
            get;
        }


        [DispId(1610678275)]
        WEBVIEW2_PHYSICAL_KEY_STATUS PhysicalKeyStatus
        {
            get;
        }


        void Handle([In] int handled);
    }
}
