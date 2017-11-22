using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BankApp
{
    class BrowserDialog: IJsDialogHandler
    {
        public void OnDialogClosed(CefSharp.IWebBrowser browserControl, CefSharp.IBrowser browser)
        {

        }

        public bool OnJSBeforeUnload(CefSharp.IWebBrowser browserControl, CefSharp.IBrowser browser, string message,
 bool isReload, CefSharp.IJsDialogCallback callback)
        {
            return true;
        }

        public bool OnJSDialog(CefSharp.IWebBrowser browserControl, CefSharp.IBrowser browser,
string originUrl, CefSharp.CefJsDialogType dialogType, string messageText, string defaultPromptText,
 CefSharp.IJsDialogCallback callback, ref bool suppressMessage)
        {
            switch (dialogType)
            {
                case CefSharp.CefJsDialogType.Alert:
                    MessageBox.Show(messageText, "JavaScript", MessageBoxButton.OK, MessageBoxImage.None, MessageBoxResult.OK, MessageBoxOptions.DefaultDesktopOnly);
                    suppressMessage = true;
                    return false;
                case CefSharp.CefJsDialogType.Confirm:
                    var dr = MessageBox.Show(messageText, "JavaScript");
                    if (dr == MessageBoxResult.Yes)
                    {
                        callback.Continue(true, string.Empty);
                        suppressMessage = false;
                        return true;
                    }
                    else
                    {
                        callback.Continue(false, string.Empty);
                        suppressMessage = false;
                        return true;
                    }
                case CefSharp.CefJsDialogType.Prompt:
                    MessageBox.Show("系统不支持prompt形式的提示框", "JavaScript");
                    break;
                default:
                    break;
            }
            return false;
        }

        public void OnResetDialogState(CefSharp.IWebBrowser browserControl, CefSharp.IBrowser browser)
        {

        }
    }
}
