using System;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    [ComVisible(true)]
    [ComImport]
    [Guid("13FC668D-1F6D-4955-A4F4-D1EE7DEB5B74")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICoreWebView2DevToolsProtocolEventReceiver
    {
        void add_DevToolsProtocolEventReceived([In] ICoreWebView2DevToolsProtocolEventReceivedEventHandler eventHandler, out EventRegistrationToken token);

        void remove_DevToolsProtocolEventReceived([In] EventRegistrationToken token);
    }
}
