#region License
// Copyright (c) 2019 Michael T. Russin
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion
using MtrDev.WebView2.Interop;
using MtrDev.WebView2.Wrapper.Handlers;
using System;

namespace MtrDev.WebView2.Wrapper
{
    /// <summary>
    /// Exposes global methods from WebView2Loader.dll
    /// </summary>
    public class WebView2Loader
    {
        private WebView2Loader() { }

        /// <summary>
        /// Create a WebView2 environment with a custom version of Edge, user data directory and/or additional browser switches.
        /// </summary>
        /// <param name="browserExecutableFolder">relative path to the folder that contains the embedded Edge</param>
        /// <param name="userDataFolder">specified to change the default user data folder location for WebView2</param>
        /// <param name="additionalBrowserArguments">Specified to change the behavior of the WebView. These will be passed to the browser process as part of the command line.</param>
        /// <param name="callback">Callback when complete</param>
        /// <returns></returns>
        public static int CreateEnvironmentWithDetails(
            string browserExecutableFolder,
            string userDataFolder,
            string additionalBrowserArguments,
            Action<EnvironmentCreatedEventArgs> callback)
        {
            EnvironmentCompletedHandler handler = new EnvironmentCompletedHandler(callback);
            int hr = Globals.CreateCoreWebView2EnvironmentWithDetails(browserExecutableFolder,
                userDataFolder,
                additionalBrowserArguments,
                handler);

            if(hr != 0 && callback !=null)
            {
                EnvironmentCreatedEventArgs args = new EnvironmentCreatedEventArgs(hr, null);
                callback.Invoke(args);
            }
            return hr;
        }

        /// <summary>
        /// Creates an evergreen WebView2 Environment using the installed Edge version.
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        public static int CreateEnvironment(Action<EnvironmentCreatedEventArgs> callback)
        {
            EnvironmentCompletedHandler handler = new EnvironmentCompletedHandler(callback);
            int hr = Globals.CreateCoreWebView2Environment(handler);
            if (hr != 0 && callback != null)
            {
                EnvironmentCreatedEventArgs args = new EnvironmentCreatedEventArgs(hr, null);
                callback.Invoke(args);
            }
            return hr;
        }

        /// <summary>
        /// Get the browser version info including channel name if it is not the stable channel or the Embedded Edge.
        /// </summary>
        /// <param name="browserExecutableFolder"></param>
        /// <param name="versionInfo"></param>
        /// <returns></returns>
        public static int GetWebView2BrowserVersionInfo(string browserExecutableFolder, out string versionInfo)
        {
            int hr = Globals.GetCoreWebView2BrowserVersionInfo(browserExecutableFolder, out versionInfo);
            return hr;
        }

        public static int CompareBrowserVersions(string version1, string version2)
        {
            int result = 0;
            int hr = Globals.CompareBrowserVersions(version1, version2, out result);
            return result;
        }
    }
}
