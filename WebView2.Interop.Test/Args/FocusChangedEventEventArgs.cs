using MtrDev.WebView2.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop.Test.Args
{
    internal class FocusChangedEventEventArgs
    {
        private object _args;

        public FocusChangedEventEventArgs(object args)
        {
            _args = args;
        }

        public override string ToString()
        {
            return string.Format("Args={0}", _args);
        }
    }
}
