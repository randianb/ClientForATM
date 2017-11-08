using CefSharp;
using CefSharp.Wpf;
using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BankApp
{
    /// <summary>
    /// WebPageViewer.xaml 的交互逻辑
    /// </summary>
    //public partial class WebPageViewer : UserControl, IRequestHandler
    //{

    //    public static WebView _view;

    //    public WebPageViewer(string url)
    //    {
    //        InitializeComponent();

    //        CEF.Initialize(new Settings { LogSeverity = LogSeverity.Disable, PackLoadingDisabled = true });

    //        BrowserSettings browserSetting = new BrowserSettings { ApplicationCacheDisabled = true,
    //            PageCacheDisabled = true, DeveloperToolsDisabled = false,
    //            PluginsDisabled = true, RemoteFontsDisabled = false, HistoryDisabled = false
    //        };

    //        _view = new WebView(string.Empty, browserSetting)
    //        {
    //            Address = url,
    //            RequestHandler = this,
    //            Background = Brushes.White
    //        };

    //        _view.RegisterJsObject("csharp", new CallbackObjectForJs());

    //        _view.LoadCompleted += _view_LoadCompleted;

          
    //        MainGrid.Children.Insert(0, _view);
            
    //    }

    //    private void _view_LoadCompleted(object sender, LoadCompletedEventArgs url)
    //    {
    //        _view.ZoomLevel = start.zoomL;
    //        Dispatcher.BeginInvoke(new Action(() =>
    //        {
    //            maskLoading.Visibility = Visibility.Collapsed;
    //        }));
    //    }

    //    public void View(string url)
    //    {
    //        if (_view.IsBrowserInitialized)
    //        {
    //            _view.Visibility = Visibility.Hidden;

    //            maskLoading.Visibility = Visibility.Visible;

    //            _view.Load(url);
    //        }
    //    }

    //    #region IRequestHandler
    //    public bool GetAuthCredentials(IWebBrowser browser, bool isProxy, string host, int port, string realm, string scheme, ref string username, ref string password)
    //    {
    //        return false;
    //    }

    //    public bool GetDownloadHandler(IWebBrowser browser, string mimeType, string fileName, long contentLength, ref IDownloadHandler handler)
    //    {
    //        return true;
    //    }

    //    public bool OnBeforeBrowse(IWebBrowser browser, IRequest request, NavigationType naigationvType, bool isRedirect)
    //    {
    //        return false;
    //    }

    //    public bool OnBeforeResourceLoad(IWebBrowser browser, IRequestResponse requestResponse)
    //    {
    //        return false;
    //    }

    //    public void OnResourceResponse(IWebBrowser browser, string url, int status, string statusText, string mimeType, WebHeaderCollection headers)
    //    {

    //    }
    //    #endregion
    //}

    //public class CallbackObjectForJs
    //{
    //    public void toVsBus(string xml)
    //    {
    //        WebPageViewer._view.ShowDevTools();
    //        //WebPageViewer._view.ShowDevTools();
    //        resolvejs(xml);
    //    }

    //    //public static System.Windows.Input.KeyEventHandler event1(object sender)
    //    //{
    //    //    MessageBox.Show("f12");
    //    //    System.Windows.Input.KeyEventHandler k = new System.Windows.Input.KeyEventHandler(sender);
    //    //    return ;
    //    //}
    //    private void resolvejs(string xml)
    //    {
    //        //WebPageViewer._view.Reload();
    //        string type = xml;
    //        Action<bool> t = new Action<bool>(fingerprints);
    //        if (type == "fingerprints")
    //        {
    //            t = new Action<bool>(fingerprints);
    //            t(true);
    //        }
    //        //t(false);
    //        //WebPageViewer._view.ZoomLevel=3;
    //    }

    //    public void fingerprints(bool status)
    //    {
            
    //        WebPageViewer._view.ExecuteScript("vueDevice('fingerprints')");
    //    }
    //}
}
