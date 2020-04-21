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
    [Guid("696ED8C1-4657-4769-928F-10EF8040ED25")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICoreWebView2ContentLoadingEventArgs
    {
        bool IsErrorPage
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
        }

        long NavigationId
        {
            [return: MarshalAs(UnmanagedType.I8)]
            get;
        }
    }
}
