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
    [Guid("26D4B817-9496-4F67-AEAB-24EB38482037")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICoreWebView2SourceChangedEventArgs
    {
        bool IsNewDocument
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
        }
    }
}
