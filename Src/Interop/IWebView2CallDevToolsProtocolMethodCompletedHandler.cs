using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// Checked
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("6EA28F62-FEC5-48EA-9669-67979B50579E")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2CallDevToolsProtocolMethodCompletedHandler
	{
		
		void Invoke([In] int errorCode, [In, MarshalAs(UnmanagedType.LPWStr)] string returnObjectAsJson);
	}
}