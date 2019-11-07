using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop.Test.Args
{
    internal class PermissionRequestedEventArgs : IWebView2PermissionRequestedEventArgs
    {
        private IWebView2PermissionRequestedEventArgs _args;

        public PermissionRequestedEventArgs(IWebView2PermissionRequestedEventArgs args)
        {
            _args = args;
        }

        public string Uri => _args.Uri;

        public WEBVIEW2_PERMISSION_TYPE PermissionType => _args.PermissionType;

        public bool IsUserInitiated => _args.IsUserInitiated;

        public WEBVIEW2_PERMISSION_STATE State { get => _args.State; set => _args.State = value; }

        public IWebView2Deferral GetDeferral()
        {
            return _args.GetDeferral();
        }

        public override string ToString()
        {
            return string.Format("Uri={0}, PermissionType={1}, IsUserInitiated={2}, State={3},",
                Uri, PermissionType, IsUserInitiated, State);
        }
    }
}
