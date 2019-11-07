using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// Checked
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("6DABCFB8-8C7D-4515-893B-9766766900DA")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2ProcessFailedEventArgs
	{
		[DispId(1610678272)]
		WEBVIEW2_PROCESS_FAILED_KIND ProcessFailedKind
		{
			
			get;
		}
	}
}