using System;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// Enum for resourceContextFilter of WebResourceRequested event
    /// </summary>
	public enum WEBVIEW2_WEB_RESOURCE_CONTEXT
	{
        /// <summary>
        /// Filter all resource types
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_ALL = 0 ,
        /// <summary>
        /// Filter document requests
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_DOCUMENT = 1,
        /// <summary>
        /// Filter CSS resources
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_STYLESHEET = 2,
        /// <summary>
        /// Filter image resources
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_IMAGE = 3,
        /// <summary>
        /// Filter other media types such as videos
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_MEDIA = 4,
        /// <summary>
        /// Filter fonts
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_FONT = 5,
        /// <summary>
        /// Filter scripts
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_SCRIPT = 6,
        /// <summary>
        /// Filter XML HTTP requests
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_XML_HTTP_REQUEST = 7,
        /// <summary>
        /// Filter fetch requests
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_FETCH = 8
    }
}