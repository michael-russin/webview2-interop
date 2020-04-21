using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// Event args for the WebMessageReceived event.
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("B21D70E2-942E-44EB-B843-22C156FDE288")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2WebMessageReceivedEventArgs
	{
        /// <summary>
        /// The URI of the document that sent this web message.
        /// </summary>
		[DispId(1610678272)]
		string Source
		{
            [return: MarshalAs(UnmanagedType.LPWStr)]
            get;
		}

        /// <summary>
        /// The message posted from the webview content to the host converted to a
        /// JSON string. Use this to communicate via JavaScript objects.
        ///
        /// For example the following postMessage calls result in the
        /// following WebMessageAsJson values:
        ///
        /// ```
        ///    postMessage({'a': 'b'})      L"{\"a\": \"b\"}"
        ///    postMessage(1.2)             L"1.2"
        ///    postMessage('example')       L"\"example\""
        /// ```
        /// </summary>
        [DispId(1610678273)]
		string WebMessageAsJson
		{
            [return: MarshalAs(UnmanagedType.LPWStr)]
            get;
		}

        /// <summary>
        /// If the message posted from the webview content to the host is a
        /// string type, this method will return the value of that string. If the
        /// message posted is some other kind of JavaScript type this method will fail
        /// with E_INVALIDARG. Use this to communicate via simple strings.
        ///
        /// For example the following postMessage calls result in the
        /// following WebMessageAsString values:
        ///
        /// ```
        ///    postMessage({'a': 'b'})      E_INVALIDARG
        ///    postMessage(1.2)             E_INVALIDARG
        ///    postMessage('example')       L"example"
        /// ```
        /// </summary>
        [DispId(1610678274)]
		string WebMessageAsString
		{
            [return: MarshalAs(UnmanagedType.LPWStr)]
            get;
		}
	}
}