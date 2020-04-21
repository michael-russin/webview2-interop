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
    [Guid("5A86C3E7-511B-4F99-BC20-8A8ED5449C12")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICoreWebView2NewBrowserVersionAvailableEventArgs
    {
        [DispId(1610678272)]
        string NewVersion
        {
            [return: MarshalAs(UnmanagedType.LPWStr)]
            get;
        }
    }
}
