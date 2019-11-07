using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop.Test.Args
{
    internal class ZoomFactorCompletedEventArgs
    {
        public object Args;

        public ZoomFactorCompletedEventArgs(object args)
        {
            Args = args;
        }
    }
}
