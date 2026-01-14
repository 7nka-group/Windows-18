using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;

namespace Win18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            var web = new WebView2();
            web.Dock = DockStyle.Fill;
            this.Controls.Add(web);

            // مهم جدًا
            await web.EnsureCoreWebView2Async();

            web.Source = new Uri("https://win18.netlify.app");

            // (اختياري) تعطيل أشياء المتصفح
            web.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            web.CoreWebView2.Settings.IsZoomControlEnabled = false;
        }
    }
}
