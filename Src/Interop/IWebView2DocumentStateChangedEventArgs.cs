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
    [Guid("3A38CB7F-EFC1-41B4-87FC-5AFCEE27C8ED")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2DocumentStateChangedEventArgs
	{
		[DispId(1610678273)]
		bool IsErrorPage
		{
			[return: MarshalAs(UnmanagedType.Bool)]
			get;
		}

		[DispId(1610678272)]
		bool IsNewDocument
		{
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
		}
	}
}