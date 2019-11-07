using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// 
    /// </summary>
    [ComVisible(true)]
    [ComImport]
	[Guid("E0618CDD-4947-4F58-802C-FC1F20BD4274")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2CreateWebViewCompletedHandler
	{
		
		void Invoke(int result, IWebView2WebView3 webview);
	}
}