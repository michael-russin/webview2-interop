using System;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// The type of a permission request.
    /// </summary>
	public enum WEBVIEW2_PERMISSION_TYPE
	{
        /// <summary>
        /// Unknown permission.
        /// </summary>
        WEBVIEW2_PERMISSION_TYPE_UNKNOWN_PERMISSION,
        /// <summary>
        /// Permission to capture audio.
        /// </summary>
		WEBVIEW2_PERMISSION_TYPE_MICROPHONE,
        /// <summary>
        /// Permission to capture video.
        /// </summary>
		WEBVIEW2_PERMISSION_TYPE_CAMERA,
        /// <summary>
        /// Permission to access geolocation.
        /// </summary>
		WEBVIEW2_PERMISSION_TYPE_GEOLOCATION,
        /// <summary>
        /// Permission to send web notifications.
        /// </summary>
		WEBVIEW2_PERMISSION_TYPE_NOTIFICATIONS,
        /// <summary>
        /// Permission to access generic sensor.
        /// Generic Sensor covering ambient-light-sensor, accelerometer, gyroscope
        /// and magnetometer.
        /// </summary>
        WEBVIEW2_PERMISSION_TYPE_OTHER_SENSORS,
        /// <summary>
        /// Permission to read system clipboard without a user gesture.
        /// </summary>
		WEBVIEW2_PERMISSION_TYPE_CLIPBOARD_READ
    }
}