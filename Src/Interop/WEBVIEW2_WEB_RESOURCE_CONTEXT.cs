using System;

namespace Russinsoft.WebView2.Interop
{
    /// <summary>
    /// Enum for resourceContextFilter of WebResourceRequested event
    /// </summary>
	public enum WEBVIEW2_WEB_RESOURCE_CONTEXT
	{
        /// <summary>
        /// Filter all resource types
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_ALL,
        /// <summary>
        /// Filter document requests
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_DOCUMENT,
        /// <summary>
        /// Filter CSS resources
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_STYLESHEET,
        /// <summary>
        /// Filter image resources
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_IMAGE,
        /// <summary>
        /// Filter other media types such as videos
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_MEDIA,
        /// <summary>
        /// Filter fonts
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_FONT,
        /// <summary>
        /// Filter scripts
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_SCRIPT,
        /// <summary>
        /// Filter XML HTTP requests
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_XML_HTTP_REQUEST,
        /// <summary>
        /// Filter fetch requests
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_FETCH
    }
}