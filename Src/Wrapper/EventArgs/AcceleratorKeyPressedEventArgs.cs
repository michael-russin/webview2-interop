using MtrDev.WebView2.Interop;
using System;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Wrapper
{
    public class AcceleratorKeyPressedEventArgs: EventArgs, ICoreWebView2AcceleratorKeyPressedEventArgs
    {
        private ICoreWebView2AcceleratorKeyPressedEventArgs _args;

        internal AcceleratorKeyPressedEventArgs(ICoreWebView2AcceleratorKeyPressedEventArgs args)
        {
            _args = args;
        }

        public WEBVIEW2_KEY_EVENT_TYPE KeyEventType => _args.KeyEventType;

        public uint VirtualKey => _args.VirtualKey;

        public int KeyEventLParam => _args.KeyEventLParam;

        public WEBVIEW2_PHYSICAL_KEY_STATUS PhysicalKeyStatus => _args.PhysicalKeyStatus;

        public void Handle([In] int handled)
        {
            _args.Handle(handled);
        }

        public override string ToString()
        {
            return string.Format("KeyEventType={0}, VirtualKey={1}, KeyEventLParam={2}, PhysicalKeyStatus={3} ",
                KeyEventType, VirtualKey, KeyEventLParam, PhysicalKeyStatus);
        }
    }
}
