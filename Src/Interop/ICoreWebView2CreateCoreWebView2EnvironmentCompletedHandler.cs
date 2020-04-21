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
    [Guid("7ED79562-90E1-47CD-A4E0-01D9211D7E3D")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler
    {
		
		void Invoke(int result, ICoreWebView2Environment webViewEnvironment);
	}
}