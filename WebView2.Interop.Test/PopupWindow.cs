using MtrDev.WebView2.Interop.Test.Args;
using MtrDev.WebView2.Interop.Test.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MtrDev.WebView2.Interop.Test
{
    public partial class PopupWindow : Form
    {
        public PopupWindow()
        {
            InitializeComponent();
        }

        public PopupWindow(IWebView2Environment2 environment, NewWindowRequestedEventArgs args)
        {
            Args = args;
            Environment = environment;
            InitializeComponent();
        }

        public IWebView2Environment2 Environment { get; set; }
        public IWebView2WebView4 WebView { get; private set; }
        public IWebView2Deferral Deferral { get; set; }

        internal NewWindowRequestedEventArgs Args { get; set; }

        private void PopupWindow_Load(object sender, EventArgs e)
        {
            CreateWebViewCompletedHandler viewCompleteHandler = new CreateWebViewCompletedHandler((viewArgs) =>
            {
                WebView = (IWebView2WebView4)viewArgs.WebView;

                WebView.Bounds = new tagRECT()
                {
                    top = 0,
                    left = 0,
                    right = Bounds.Width,
                    bottom = Bounds.Height
                };
                IWebView2WebView wv;
                Args.get_NewWindow(out wv);
                wv = (IWebView2WebView)WebView;
                Args.put_NewWindow(wv);
                Args.Handled = true;
                Deferral.Complete();
            });


            Environment.CreateWebView(Handle, viewCompleteHandler);
        }
    }
}
