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
    [Guid("D8B1DD71-B9AD-4EEB-ABE3-87E7EFC5D37F")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2WebResourceRequestedEventArgs
	{
		[DispId(1610678272)]
		IWebView2WebResourceRequest Request
		{
			
			get;
		}

		[DispId(1610678273)]
		IWebView2WebResourceResponse Response
		{
			
			get;
			
			set;
		}

		
		IWebView2Deferral GetDeferral();
	}
}