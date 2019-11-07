using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// Event args for the IWebView2WebView::add_ScriptDialogOpening event.
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("ABB0484E-8D4F-4BEA-9058-B0287221A976")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2ScriptDialogOpeningEventArgs
	{
        /// <summary>
        /// The URI of the page that requested the dialog box.
        /// </summary>
        [DispId(1610678272)]
        string Uri
        {
            [return: MarshalAs(UnmanagedType.LPWStr)]
            get;
        }

        /// <summary>
        /// The kind of JavaScript dialog box.
        /// </summary>
        [DispId(1610678273)]
		WEBVIEW2_SCRIPT_DIALOG_KIND Kind
		{
			
			get;
		}

        /// <summary>
        /// The message of the dialog box. From JavaScript this is the first parameter
        /// passed to alert, confirm, and prompt.
        /// </summary>
        [DispId(1610678274)]
		string Message
		{
            [return: MarshalAs(UnmanagedType.LPWStr)]
            get;
		}

        /// <summary>
        /// The host may call this to respond with OK to confirm and prompt
        /// dialogs or not call this method to indicate cancel. From JavaScript this
        /// means that the confirm function returns true if Accept is called. And
        /// for the prompt function it returns the value of ResultText if Accept is
        /// called and returns false otherwise.
        /// </summary>
        void Accept();

        /// <summary>
        /// The second parameter passed to the JavaScript prompt dialog. This is the
        /// the default value to use for the result of the prompt JavaScript function.
        /// </summary>
        [DispId(1610678276)]
        string DefaultText
        {
            [return: MarshalAs(UnmanagedType.LPWStr)]
            get;
        }

        /// <summary>
        /// The return value from the JavaScript prompt function if Accept is called.
        /// This is ignored for dialog kinds other than prompt. If Accept is not
        /// called this value is ignored and false is returned from prompt.
        /// </summary>
        [DispId(1610678277)]
		string ResultText
		{
            [return: MarshalAs(UnmanagedType.LPWStr)]
            get;
            [param: MarshalAs(UnmanagedType.LPWStr)]
            set;
		}

        /// <summary>
        /// GetDeferral can be called to return an IWebView2Deferral object.
        /// You can use this to complete the event at a later time.
        /// </summary>
        /// <returns></returns>
        IWebView2Deferral GetDeferral();
	}
}