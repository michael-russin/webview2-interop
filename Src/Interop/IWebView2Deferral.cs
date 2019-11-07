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
    [Guid("BD478C19-4706-4B1D-88B6-76DD39ACB7B1")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2Deferral
	{
        /// <summary>
        /// Completes the associated deferred event. Complete should only be
        /// called once for each deferral taken.
        /// </summary>
        void Complete();
	}
}