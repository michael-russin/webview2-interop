using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop.Test.Args
{
    internal class CallDevToolsProtocolMethodCompletedEventArgs
    {
        private int _errorCode;
        private string _returnObjectAsJson;

        public CallDevToolsProtocolMethodCompletedEventArgs(string methodName, int errorCode, string returnObjectAsJson)
        {
            _errorCode = errorCode;
            _returnObjectAsJson = returnObjectAsJson;
            MethodName = methodName;
        }

        public int ErrorCode => _errorCode;

        public string ReturnObjectAsJson => _returnObjectAsJson;

        public string MethodName { get; private set; }

        public override string ToString()
        {
            return string.Format("MethodName={0}, ErrorCode={1}, ReturnObjectAsJson={2}", MethodName, ErrorCode, ReturnObjectAsJson);
        }
    }
}
