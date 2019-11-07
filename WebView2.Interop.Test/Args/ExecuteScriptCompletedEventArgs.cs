using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop.Test.Args
{
    internal class ExecuteScriptCompletedEventArgs
    {
        public ExecuteScriptCompletedEventArgs(int errorCode, string resultObjectAsJson)
        {
            ErrorCode = errorCode;
            ResultObjectAsJson = resultObjectAsJson;
        }

        public int ErrorCode { get; private set; }

        public string ResultObjectAsJson { get; private set; }

        public override string ToString()
        {
            return string.Format("ErrorCode={0}, ResultObjectAsJson={1}", ErrorCode, ResultObjectAsJson);
        }
    }
}
