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
    [Guid("B0F8A736-CC49-4414-BB9C-FDBC02599622")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2HttpHeadersCollectionIterator
	{
		
		void GetCurrentHeader([MarshalAs(UnmanagedType.LPWStr)] out string name, [MarshalAs(UnmanagedType.LPWStr)] out string value);


        [DispId(1610678273)]
        bool HasCurrentHeader
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
        }

        void MoveNext(out int has_next);
	}
}