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
	[Guid("EE07AA7F-5DAF-4C00-9C0B-5F736213C92D")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler
	{
		
		void Invoke([In] int errorCode, [In, MarshalAs(UnmanagedType.LPWStr)] string id);
	}
}