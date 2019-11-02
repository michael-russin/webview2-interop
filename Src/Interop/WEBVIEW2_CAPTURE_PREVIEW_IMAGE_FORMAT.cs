using System;

namespace Russinsoft.WebView2.Interop
{
    /// <summary>
    /// Image format used by the IWebView2WebView::CapturePreview method.
    /// </summary>
	public enum WEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT
	{
        /// <summary>
        /// PNG image format.
        /// </summary>
		WEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT_PNG,
        /// <summary>
        /// JPEG image format.
        /// </summary>
		WEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT_JPEG
    }
}