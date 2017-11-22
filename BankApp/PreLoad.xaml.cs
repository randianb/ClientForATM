﻿using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace BankApp
{
    /// <summary>
    /// PreLoad.xaml 的交互逻辑
    /// </summary>
    public partial class PreLoad : Window
    {
        Simulator smlt = new Simulator();
        MainWindow mw;
        private ArrayList openDevice = new ArrayList();
        private ArrayList closeDevice = new ArrayList();

        public static int zoomL;
        public delegate void GoMain();
        public GoMain goMain;

        public PreLoad()
        {
            InitializeComponent();
            smlt.err += Exit;
            Task t = new Task(() => {
                //Thread.Sleep(1000);
                ReadConfig();
                LoadDev();
            });
            t.Start();
            Log.open();
            Log.log("欢迎使用金振达自助终端");
        }

        private void ReadConfig()
        {
            XmlDocument xd = new XmlDocument();
            try
            {
                xd.Load(@"E:\github\ClientForATM\config\AppConfig.xml");
                XmlNodeList opendev = xd.SelectNodes("/config/device/startUp/open");
                foreach (XmlNode xn in opendev)
                {
                    openDevice.Add(xn.InnerText.Trim());
                }
                XmlNodeList closedev = xd.SelectNodes("/config/device/shutDown/close");
                foreach (XmlNode xn in opendev)
                {
                    closeDevice.Add(xn.InnerText.Trim());
                }
                zoomL = Convert.ToInt32(xd.SelectSingleNode("/config/UI/zoomLevel").InnerText.Trim());
                //授权校验
                string result = EncryptDES(
                    xd.SelectSingleNode("/config/license/time").InnerText.Trim(),
                    xd.SelectSingleNode("/config/license/keys").InnerText.Trim());
                if (result != xd.SelectSingleNode("/config/license/coded").InnerText.Trim())
                {
                    Exit("软件未授权");
                }
                else
                {
                    DateTime dR = Convert.ToDateTime(xd.SelectSingleNode("/config/license/time").InnerText.Trim());
                    TimeSpan ts = DateTime.Now - dR;
                    if (ts.TotalDays > 0)
                    {
                        Exit("授权已过期");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void LoadDev()
        {
            foreach (string name in openDevice)
            {
                switch (name)
                {
                    case "camera":
                        Dispatcher.Invoke(() => {
                            pg.Value = 100 * openDevice.IndexOf(name) / openDevice.Count;
                            //label1.Content = "正在清理cef···";
                        });
                        smlt.startUp1();
                        break;
                    case "scanner":
                        Dispatcher.Invoke(() => {
                            pg.Value = 100 * openDevice.IndexOf(name) / openDevice.Count;
                            //label1.Content = "正在启动扫码器···";
                        });
                        smlt.startUp1();
                        break;
                    case "printer":
                        Dispatcher.Invoke(() => {
                            pg.Value = 100 * openDevice.IndexOf(name) / openDevice.Count;
                            //label1.Content = "正在加载数据字典···";
                        });
                        smlt.startUp2();
                        //DevExit("end");
                        break;
                    default:
                        Exit("未知的启动项");
                        break;
                }
            }
            Dispatcher.Invoke(() =>
            {
                mw = new MainWindow();
                mw.Show();
                Hide();
                mw.exit += UnLoadDev;
            });
        }

        public void UnLoadDev()
        {
            Show();
            Task t = new Task(() => {
                UnLoadDevice();
            });
            t.Start();
        }

        private void UnLoadDevice()
        {
            foreach (string name in closeDevice)
            {
                switch (name)
                {
                    case "camera":
                        Dispatcher.Invoke(() => {
                            pg.Value = 100 * openDevice.IndexOf(name) / openDevice.Count;
                            //label1.Content = "正在清理cef···";
                        });
                        smlt.startUp1();
                        break;
                    case "scanner":
                        Dispatcher.Invoke(() => {
                            pg.Value = 100 * openDevice.IndexOf(name) / openDevice.Count;
                            //label1.Content = "正在启动扫码器···";
                        });
                        smlt.startUp1();
                        break;
                    case "printer":
                        Dispatcher.Invoke(() => {
                            pg.Value = 100 * openDevice.IndexOf(name) / openDevice.Count;
                            //label1.Content = "正在加载数据字典···";
                        });
                        smlt.startUp2();
                        break;
                    default:
                        DevExit("未知的启动项");
                        break;
                }
            }
            Exit("");
        }

        public void DevExit(string err="")
        {
            if (MessageBoxResult.OK == MessageBox.Show(err, "", MessageBoxButton.OK, MessageBoxImage.None, MessageBoxResult.OK, MessageBoxOptions.ServiceNotification))
            {
                Exit(err);
            }
        }

        public void Exit(string err="")
        {
            Log.log("系统退出 " + err);
            Log.close();
            Dispatcher.Invoke(()=> {
                Application.Current.Shutdown();
            });
       
        }

        public static string EncryptDES(string encryptString, string encryptKey)
        {
            byte[] Keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
                DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray());
            }
            catch
            {
                return encryptString;
            }
        }

    }
}
