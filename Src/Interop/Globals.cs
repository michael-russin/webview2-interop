using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Russinsoft.WebView2.Interop
{
    public class Globals
    {
        private Globals()
        {
        }

        /// <summary>
        /// DLL export to create a WebView2 environment with a custom version of Edge,
        /// user data directory and/or additional browser switches.
        /// </summary>
        /// <param name="browserExecutableFolder">the relative path to the folder that contains the embedded Edge</param>
        /// <param name="userDataFolder">specified to change the default user data folder location for
        /// WebView2. The path can be an absolute file path or a relative file path
        /// that is interpreted as relative to the current process's executable</param>
        /// <param name="additionalBrowserArguments"></param>
        /// <param name="environment_created_handler"></param>
        /// <returns></returns>
        [DllImport(ExternDll.WebView2Loader, SetLastError = true)]
        public static extern int CreateWebView2EnvironmentWithDetails(
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string browserExecutableFolder,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string userDataFolder,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string additionalBrowserArguments,
            [In] IWebView2CreateWebView2EnvironmentCompletedHandler environment_created_handler);

        /// <summary>
        /// Creates an evergreen WebView2 Environment using the installed Edge version.
        /// This is equivalent to calling CreateWebView2EnvironmentWithDetails with
        /// nullptr for browserExecutableFolder, userDataFolder, additionalBrowserArguments.
        ///  See CreateWebView2EnvironmentWithDetails for more details
        /// </summary>
        /// <param name="environment_created_handler"></param>
        /// <returns></returns>
        [DllImport(ExternDll.WebView2Loader, SetLastError = true)]
        public static extern int CreateWebView2Environment(
            [In] IWebView2CreateWebView2EnvironmentCompletedHandler environment_created_handler);

        /// <summary>
        /// Get the browser version info including channel name if it is not the stable channel
        /// or the Embedded Edge.
        /// Channel names are beta, dev, and canary.
        /// If an override exists for the browserExecutableFolder or the channel preference,
        /// the override will be used.
        /// If there isn't an override, then the parameter passed to GetWebView2BrowserVersionInfo is used.
        /// </summary>
        /// <param name="browserExecutableFolder"></param>
        /// <param name="versionInfo"></param>
        /// <returns></returns>
        [DllImport(ExternDll.WebView2Loader, SetLastError = true)]
        public static extern int GetWebView2BrowserVersionInfo(            [In, MarshalAs(UnmanagedType.LPWStr)]
            string browserExecutableFolder,
            [MarshalAs(UnmanagedType.LPWStr)]
            string versionInfo);
    }
}
