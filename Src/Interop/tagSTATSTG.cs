using System;
using System.Runtime.InteropServices;

namespace Russinsoft.WebView2.Interop
{
	public struct tagSTATSTG
	{
		public string pwcsName;

		public uint type;

		public _ULARGE_INTEGER cbSize;

		public _FILETIME mtime;

		public _FILETIME ctime;

		public _FILETIME atime;

		public uint grfMode;

		public uint grfLocksSupported;

		[ComAliasName("Russinsoft.WebView2.Interop.GUID")]
		public GUID clsid;

		public uint grfStateBits;

		public uint reserved;
	}
}