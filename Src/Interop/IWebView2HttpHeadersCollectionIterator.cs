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
    [Guid("66A215E4-CA41-490B-884A-411FFB17CD1C")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2HttpHeadersCollectionIterator
	{
		
		void GetCurrentHeader([MarshalAs(UnmanagedType.LPWStr)] out string name, [MarshalAs(UnmanagedType.LPWStr)] out string value);

		
		void MoveNext(out int has_next);
	}
}