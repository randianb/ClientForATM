using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using cef;
using CefSharp;

namespace BankApp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>

    public partial class MainWindow : Window
    {
        //public delegate void conf();
        //public static conf d;
        start s = new start();
        public static CefSharp.Wpf.ChromiumWebBrowser webView;

        public MainWindow()
        {
            InitializeComponent();
            s.goMain += LoadBrowser;
            LoadStart();
        }

        private void LoadStart()
        {
            MainGrid.Children.Insert(0, s);
        }

        private void LoadBrowser()
        {
            var setting = new CefSharp.CefSettings();
            CefSharp.Cef.Initialize(setting);
            webView = new CefSharp.Wpf.ChromiumWebBrowser()
            {
                BrowserSettings =
                    {
                        DefaultEncoding = "UTF-8"
                    },
                JsDialogHandler = new BrowserDialog()
            };
            Content = webView;
            webView.RegisterJsObject("csharp", new CallbackObjectForJs());
            webView.Address = "file://E:/github/ClientForATM/WebPage/index.html";
            webView.FrameLoadEnd += OnLoadEnd;
        }

        public void OnLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            Dispatcher.Invoke(()=> {
                webView.ZoomLevel = start.zoomL;
            });
        }

        public class CallbackObjectForJs
        {
            public void toVsBus(string xml)
            {
                webView.ShowDevTools();
                //WebPageViewer._view.ShowDevTools();
                resolvejs(xml);
                //while (true) { }
            }

            private void resolvejs(string xml)
            {
                string type = xml;
                Action<bool> t = new Action<bool>(fingerprints);
                if (type == "fingerprints")
                {
                    t = new Action<bool>(fingerprints);
                    t(true);
                }
                t(false);
            }

            public void fingerprints(bool status)
            {
                Thread.Sleep(2000);
                webView.ExecuteScriptAsync("vueDevice('fingerprints')");
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Exit("");
        }

        public static void Exit(string err)
        {
            Log.log("系统退出 " + err);
            Log.close();
            Environment.Exit(0);
        } 
    }
}
