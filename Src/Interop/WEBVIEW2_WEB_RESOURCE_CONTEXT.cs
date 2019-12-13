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
        WEBVIEW2_WEB_RESOURCE_CONTEXT_FETCH = 8,

        /// <summary>
        /// TextTrack resources
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_TEXT_TRACK = 9,
        /// <summary>
        /// EventSource API communication
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_EVENT_SOURCE = 10,
        /// <summary>
        /// WebSocket API communication
        /// </summary>        
        WEBVIEW2_WEB_RESOURCE_CONTEXT_WEBSOCKET = 11,
        /// <summary>
        /// Web App Manifests
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_MANIFEST = 12,
        /// <summary>
        /// Signed HTTP Exchanges
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_SIGNED_EXCHANGE = 13,
        /// <summary>
        /// Ping requests
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_PING = 14,
        /// <summary>
        /// CSP Violation Reports
        /// </summary>        
        WEBVIEW2_WEB_RESOURCE_CONTEXT_CSP_VIOLATION_REPORT = 15,
        /// <summary>
        /// Other resources
        /// </summary>
        WEBVIEW2_WEB_RESOURCE_CONTEXT_OTHER = 16
    }
}