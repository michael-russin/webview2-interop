using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop
{
    internal class CallDevToolsProtocolMethodCompletedEventArgs
    {
        int _errorCode;
        string _returnObjectAsJson;

        public CallDevToolsProtocolMethodCompletedEventArgs(int errorCode, string returnObjectAsJson)
        {
            _errorCode = errorCode;
            _returnObjectAsJson = returnObjectAsJson;
        }

        public int ErrorCode => _errorCode;

        public string ReturnObjectAsJson => _returnObjectAsJson;
    }
}
