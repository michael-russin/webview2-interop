using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
#pragma warning disable CS0108

    [Guid("0000000C-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface __IStream : __ISequentialStream
	{
		
		void Clone(out __IStream ppstm);

		
		void Commit([In] uint grfCommitFlags);

		
		void LockRegion([In] _ULARGE_INTEGER libOffset, [In] _ULARGE_INTEGER cb, [In] uint dwLockType);

		
		void RemoteCopyTo([In] __IStream pstm, [In] _ULARGE_INTEGER cb, out _ULARGE_INTEGER pcbRead, out _ULARGE_INTEGER pcbWritten);

		
		void RemoteRead(out byte pv, [In] uint cb, out uint pcbRead);

		
		void RemoteSeek([In] _LARGE_INTEGER dlibMove, [In] uint dwOrigin, out _ULARGE_INTEGER plibNewPosition);

		
		void RemoteWrite([In] ref byte pv, [In] uint cb, out uint pcbWritten);

		
		void Revert();

		
		void SetSize([In] _ULARGE_INTEGER libNewSize);

		
		void Stat(out tagSTATSTG pstatstg, [In] uint grfStatFlag);

		
		void UnlockRegion([In] _ULARGE_INTEGER libOffset, [In] _ULARGE_INTEGER cb, [In] uint dwLockType);
	}
}