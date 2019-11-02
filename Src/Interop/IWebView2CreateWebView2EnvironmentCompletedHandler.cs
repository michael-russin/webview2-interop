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
    [Guid("A8346945-51C2-4CE6-8B4C-6F3C4391828B")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2CreateWebView2EnvironmentCompletedHandler
	{
		
		void Invoke(int result, IWebView2Environment webViewEnvironment);
	}
}