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
    [Guid("7EF09904-8B46-4FE1-87FF-5A28EFAF7723")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2DevToolsProtocolEventReceivedEventArgs
	{
		[DispId(1610678272)]
		string ParameterObjectAsJson
		{
            [return: MarshalAs(UnmanagedType.LPWStr)]
            get;
		}
	}
}