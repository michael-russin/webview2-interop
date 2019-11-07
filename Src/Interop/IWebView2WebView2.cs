using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// Checked
    /// </summary>
    [ComVisible(true),
     ComImport,
     Guid("BB2DA827-0632-4ED6-8EDA-3F9E561767CA"),
	 InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2WebView2
	{
        /// <summary>
        /// Stop all navigations and pending resource fetches
        /// </summary>
		void Stop();
	}
}