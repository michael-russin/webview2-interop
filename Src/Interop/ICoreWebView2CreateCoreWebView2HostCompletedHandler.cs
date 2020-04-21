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
    [Guid("E09F5D38-91E3-49D1-8182-70A616AA06B9")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICoreWebView2CreateCoreWebView2HostCompletedHandler
    {

       void Invoke([In] int result, [In] ICoreWebView2Host host);
    }
}
