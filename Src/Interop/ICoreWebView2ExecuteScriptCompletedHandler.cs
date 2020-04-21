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
    [Guid("51457AE2-93FD-404E-A957-3D6034EAD733")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2ExecuteScriptCompletedHandler
	{
		
		void Invoke([In] int errorCode, [In, MarshalAs(UnmanagedType.LPWStr)] string resultObjectAsJson);
	}
}