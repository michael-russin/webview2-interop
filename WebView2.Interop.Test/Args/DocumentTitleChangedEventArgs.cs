using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop.Test.Args
{
    internal class DocumentTitleChangedEventArgs
    {
        private object _args;

        public DocumentTitleChangedEventArgs(object args)
        {
            _args = args;
        }

        public override string ToString()
        {
            return string.Format("Args={0}", _args);
        }
    }
}
