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
    [Guid("A1A2EC1C-B5C3-4EB2-9BCB-9166AFAA0E85")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2CapturePreviewCompletedHandler
	{
		
		void Invoke([In] int result);
	}
}