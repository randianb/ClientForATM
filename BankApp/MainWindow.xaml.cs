﻿using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using cef;
using CefSharp;
using CefSharp.Wpf;
using System.Xml;

namespace BankApp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>

    public partial class MainWindow : Window
    {
        public delegate void Exit();
        public Exit exit;

        public static CefSharp.Wpf.ChromiumWebBrowser webView;

        public MainWindow()
        {
            InitializeComponent();
            LoadBrowser();
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
                JsDialogHandler = new BrowserDialog(),
            };
            webView.PreviewTextInput += (obj, args) =>
            {
                foreach (var character in args.Text)
                {
                    // 把每个字符向浏览器组件发送一遍
                    webView.GetBrowser().GetHost().SendKeyEvent((int)WM.CHAR, (int)character, 0);
                }

                // 不让cef自己处理
                args.Handled = true;
            };
            webView.PreviewKeyDown += (obj, args) =>
            {
                if (args.Key.ToString() == "F5")
                {
                    webView.Address = "localhost";
                }
                if (args.Key.ToString() == "F12")
                {
                    webView.ShowDevTools();
                }
                if (args.Key.ToString() == "Back")
                {
                    webView.Back();
                }
            };

            webView.RegisterJsObject("csharp", new CallbackObjectForJs());
            webView.Address = "localhost";
            webView.FrameLoadEnd += OnLoadEnd;
            Content = webView;
        }

        public void OnLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            Dispatcher.Invoke(()=> {
                webView.ZoomLevel = PreLoad.zoomL;
            });
        }

        public class CallbackObjectForJs
        {
            public void toVsBus(string xml)
            {
                ResolveJs(xml);
            }

            private void ResolveJs(string xml)
            {
                XmlDocument xd = new XmlDocument();
                xd.LoadXml(xml);
                XmlNode nd = xd.SelectSingleNode("/root/device");
                string type = nd.InnerText;
                Action<string> t = CallBack;
                t("aa");
            }

            public void CallBack(string a)
            {
                Console.WriteLine(a);
                webView.ExecuteScriptAsync("vueDevice.res('fingerprints')");
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            exit();
        }
    }
}
