using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WebView2.Interop.Test.SafeNativeMethods;

namespace WebView2.Interop.Test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SafeNativeMethods.SetProcessDpiAwarenessContext(DpiAwarenessContext.PER_MONITOR_AWARE_V2);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
