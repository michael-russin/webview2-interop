using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Russinsoft.WebView2.Interop
{
    /// <summary>
    /// Checked
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("F5AC0E3B-8B92-45E5-ABEF-DB8518EFFF27")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2ExecuteScriptCompletedHandler
	{
		
		void Invoke([In] int errorCode, [In, MarshalAs(UnmanagedType.LPWStr)] string resultObjectAsJson);
	}
}