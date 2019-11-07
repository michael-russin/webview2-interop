using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrDev.WebView2.Interop.Test.Args
{
    internal class AddScriptToExecuteOnDocumentCreatedCompletedEventArgs
    {
        private int _errorCode;

        public AddScriptToExecuteOnDocumentCreatedCompletedEventArgs(int errorCode, string id)
        {
            Id = id;
            _errorCode = errorCode;
        }

        public string Id { get; private set; }

        public override string ToString()
        {
            return string.Format("Id={0}, ErrorCode={1}", Id, _errorCode);
        }
    }
}
