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
    [Guid("B7627F5F-8723-4ED3-AC20-F93104CDEA51")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2CallDevToolsProtocolMethodCompletedHandler
	{
		
		void Invoke([In] int errorCode, [In, MarshalAs(UnmanagedType.LPWStr)] string returnObjectAsJson);
	}
}