#region License
// Copyright (c) 2019 Michael T. Russin
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion
using System;
using MtrDev.WebView2.Interop;

namespace MtrDev.WebView2.Wrapper
{
    public class NewWindowRequestedEventArgs : EventArgs, ICoreWebView2NewWindowRequestedEventArgs
    {
        private ICoreWebView2NewWindowRequestedEventArgs _args;
        private bool _windowSet;

        internal NewWindowRequestedEventArgs(ICoreWebView2NewWindowRequestedEventArgs args)
        {
            _args = args;
            _windowSet = false;
        }

        public bool Handled { get => _args.Handled; set => _args.Handled = value; }

        public bool IsUserInitiated => _args.IsUserInitiated;


        public ICoreWebView2 NewWindow
        {
            get
            {
                // this seems to crash if NewWindow wasn't set already. 
                if (!_windowSet)
                    return null;
                return _args.NewWindow;
            }
            set
            {
                _windowSet = true;
                _args.NewWindow = value;
            }
        }

        public string Uri => _args.Uri;

        public ICoreWebView2Deferral GetDeferral()
        {
            return new WebView2Deferral(_args.GetDeferral());
        }

        public override string ToString()
        {
            return string.Format("Handled={0}, IsUserInitiated={1}", Handled, IsUserInitiated);
        }
    }
}
