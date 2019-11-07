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
    [Guid("0256DA7B-2BF7-4B12-8ECA-EFFCB28C2CD8")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWebView2NewVersionAvailableEventArgs
    {
        [DispId(1610678272)]
        string NewVersion
        {
            [return: MarshalAs(UnmanagedType.LPWStr)]
            get;
        }
    }
}
