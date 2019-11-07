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
    [Guid("BF0F875F-8EB0-4211-9B80-2892F7276BB9")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2DevToolsProtocolEventReceivedEventArgs
	{
		[DispId(1610678272)]
		string ParameterObjectAsJson
		{
            [return: MarshalAs(UnmanagedType.LPWStr)]
            get;
		}
	}
}