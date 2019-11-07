using System;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// Error status values for web navigations.
    /// </summary>
	public enum WEBVIEW2_WEB_ERROR_STATUS
	{
        /// <summary>
        /// An unknown error occurred.
        /// </summary>
		WEBVIEW2_WEB_ERROR_STATUS_UNKNOWN,
        /// <summary>
        /// The SSL certificate common name does not match the web address.
        /// </summary>
		WEBVIEW2_WEB_ERROR_STATUS_CERTIFICATE_COMMON_NAME_IS_INCORRECT,
        /// <summary>
        /// The SSL certificate has expired.
        /// </summary>
		WEBVIEW2_WEB_ERROR_STATUS_CERTIFICATE_EXPIRED,
        /// <summary>
        /// The SSL client certificate contains errors.
        /// </summary>
		WEBVIEW2_WEB_ERROR_STATUS_CLIENT_CERTIFICATE_CONTAINS_ERRORS,
        /// <summary>
        /// The SSL certificate has been revoked.
        /// </summary>
		WEBVIEW2_WEB_ERROR_STATUS_CERTIFICATE_REVOKED,
        /// <summary>
        /// The SSL certificate is invalid.
        /// </summary>
		WEBVIEW2_WEB_ERROR_STATUS_CERTIFICATE_IS_INVALID,
        /// <summary>
        /// The host is unreachable.
        /// </summary>
		WEBVIEW2_WEB_ERROR_STATUS_SERVER_UNREACHABLE,
        /// <summary>
        /// The connection has timed out.
        /// </summary>
		WEBVIEW2_WEB_ERROR_STATUS_TIMEOUT,
        /// <summary>
        /// The server returned an invalid or unrecognized response.
        /// </summary>
		WEBVIEW2_WEB_ERROR_STATUS_ERROR_HTTP_INVALID_SERVER_RESPONSE,
        /// <summary>
        /// The connection was aborted.
        /// </summary>
		WEBVIEW2_WEB_ERROR_STATUS_CONNECTION_ABORTED,
        /// <summary>
        /// The connection was reset.
        /// </summary>
		WEBVIEW2_WEB_ERROR_STATUS_CONNECTION_RESET,
        /// <summary>
        /// The Internet connection has been lost.
        /// </summary>
		WEBVIEW2_WEB_ERROR_STATUS_DISCONNECTED,
        /// <summary>
        /// Cannot connect to destination.
        /// </summary>
		WEBVIEW2_WEB_ERROR_STATUS_CANNOT_CONNECT,
        /// <summary>
        /// Could not resolve provided host name.
        /// </summary>
		WEBVIEW2_WEB_ERROR_STATUS_HOST_NAME_NOT_RESOLVED,
        /// <summary>
        /// The operation was canceled.
        /// </summary>
		WEBVIEW2_WEB_ERROR_STATUS_OPERATION_CANCELED,
        /// <summary>
        /// The request redirect failed. 
        /// </summary>
		WEBVIEW2_WEB_ERROR_STATUS_REDIRECT_FAILED,
        /// <summary>
        /// An unexpected error occurred.
        /// </summary>
		WEBVIEW2_WEB_ERROR_STATUS_UNEXPECTED_ERROR
    }
}