using System;

namespace MtrDev.WebView2.Wrapper
{
    public class CapturePreviewCompletedArgs : EventArgs
    {
        internal CapturePreviewCompletedArgs(int result)
        {
            Result = result;
        }

        public int Result { get; private set; }

        public override string ToString()
        {
            return string.Format("Result={0}", Result);
        }
    }
}
