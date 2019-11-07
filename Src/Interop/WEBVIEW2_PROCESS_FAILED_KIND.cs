using System;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// Kind of process failure used in the IWebView2ProcessFailedEventHandler interface.
    /// </summary>
	public enum WEBVIEW2_PROCESS_FAILED_KIND
	{
        /// <summary>
        /// Indicates the browser process terminated unexpectedly.
        /// The WebView automatically goes into the Closed state.
        /// The app has to recreate a new WebView to recover from this failure.
        /// </summary>
        WEBVIEW2_PROCESS_FAILED_KIND_BROWSER_PROCESS_EXITED,

        /// <summary>
        /// Indicates the render process terminated unexpectedly.
        /// A new render process will be created automatically and navigated to an
        /// error page.
        /// The app can use Reload to try to recover from this failure.
        /// </summary>

        WEBVIEW2_PROCESS_FAILED_KIND_RENDER_PROCESS_EXITED,

        /// <summary>
        /// Indicates the render process becomes unresponsive.
        /// The app can try to navigate away from the page to recover from the
        /// failure.
        /// Note that this does not seem to work right now.
        /// Does not fire for simple long running script case, the only related test
        /// SitePerProcessBrowserTest::NoCommitTimeoutForInvisibleWebContents is
        /// disabled.
        /// </summary>
        WEBVIEW2_PROCESS_FAILED_KIND_RENDER_PROCESS_UNRESPONSIVE
    }
}