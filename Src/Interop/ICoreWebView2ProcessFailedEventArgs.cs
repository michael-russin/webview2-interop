using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// Checked
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("9E354785-CFA2-480A-84E0-57837ADD8E36")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2ProcessFailedEventArgs
	{
		[DispId(1610678272)]
		WEBVIEW2_PROCESS_FAILED_KIND ProcessFailedKind
		{
			
			get;
		}
	}
}