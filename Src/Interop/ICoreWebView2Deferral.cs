using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// This interface is used to complete deferrals on event args that
    /// support getting deferrals via their GetDeferral method.
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("C1000D7C-4817-40EB-A2AE-3B929D5A8EE3")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2Deferral
	{
        /// <summary>
        /// Completes the associated deferred event. Complete should only be
        /// called once for each deferral taken.
        /// </summary>
        void Complete();
	}
}