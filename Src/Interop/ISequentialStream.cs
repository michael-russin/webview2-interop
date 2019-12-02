using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
	[Guid("0C733A30-2A1C-11CE-ADE5-00AA0044773D")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface __ISequentialStream
	{
		
		void RemoteRead(out byte pv, [In] uint cb, out uint pcbRead);

		
		void RemoteWrite([In] ref byte pv, [In] uint cb, out uint pcbWritten);
	}
}