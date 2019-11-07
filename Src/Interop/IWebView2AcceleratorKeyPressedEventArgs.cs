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
    [Guid("64C29E6D-BA57-4EBA-A14F-71697F4F3D86")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWebView2AcceleratorKeyPressedEventArgs
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
