using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using System.Security.Cryptography;

namespace BankApp
{
    /// <summary>
    /// PreLoad.xaml 的交互逻辑
    /// </summary>
    public partial class PreLoad : Window
    {
        MainWindow mw;

        private ArrayList openDevice = new ArrayList();
        private ArrayList closeDevice = new ArrayList();

        public static Simulator Device=new Simulator();
        public static int zoomL;
        public delegate void GoMain();
        public GoMain goMain;

        public PreLoad()
        {
            InitializeComponent();
            Device.err += Exit;
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
                xd.Load(Log.prefix+"\\config\\AppConfig.xml");
                XmlNodeList opendev = xd.SelectNodes("/config/device/open");
                foreach (XmlNode xn in opendev)
                {
                    openDevice.Add(xn.InnerText.Trim());
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
                DevExit(e.Message.ToString());
            }
        }

        private void LoadDev()
        {
            try
            {
                foreach (string name in openDevice)
                {
                    switch (name)
                    {
                        case "FingerPrint":
                            //界面显示
                            Dispatcher.Invoke(() =>
                            {
                                pg.Value = 100 * openDevice.IndexOf(name) / openDevice.Count;
                                label1.Content = "正在启动指纹仪";
                            });

                            //打开wosa
                            Device.FingerPrintStartUp();
                            Device.FingerPrintOpen();
                            Device.FingerPrintRegister();

                            //添加到关闭设备列表
                            closeDevice.Add(name);

                            break;
                        case "IDCardReader":
                            //界面显示
                            Dispatcher.Invoke(() =>
                            {
                                pg.Value = 100 * openDevice.IndexOf(name) / openDevice.Count;
                                label1.Content = "正在启动身份证阅读器";
                            });

                            //打开wosa
                            Device.IDCardStartUp();
                            Device.IDCardOpen();
                            Device.IDCardRegister();

                            //添加到关闭设备列表
                            closeDevice.Add(name);

                            break;
                        case "CashDeposit":
                            //界面显示
                            Dispatcher.Invoke(() =>
                            {
                                pg.Value = 100 * openDevice.IndexOf(name) / openDevice.Count;
                                label1.Content = "正在启动现金存储模块";
                            });

                            //打开wosa
                            Device.CashDepositStartUp();
                            Device.CashDepositOpen();
                            Device.CashDepositRegister();

                            //添加到关闭设备列表
                            closeDevice.Add(name);

                            break;
                        default:
                            throw new Exception("未知的启动项");
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
            catch (Exception e)
            {
                DevExit(e.Message.ToString());
            }
        }

        private void UnLoadDev()
        {
            Show();
            Task t = new Task(() => {
                UnLoadDevice();
            });
            t.Start();
        }

        private void UnLoadDevice()
        {
            try
            {
                foreach (string name in closeDevice)
                {
                    switch (name)
                    {
                        case "FingerPrint":
                            Dispatcher.Invoke(() => {
                                pg.Value = 100 * openDevice.IndexOf(name) / openDevice.Count;
                                label1.Content = "正在关闭指纹仪···";
                            });
                            Device.FingerPrintDeregister();
                            Device.FingerPrintClose();
                            Device.FingerPrintCleanup();
                            break;
                        case "IDCardReader":
                            //界面显示
                            Dispatcher.Invoke(() =>
                            {
                                pg.Value = 100 * openDevice.IndexOf(name) / openDevice.Count;
                                label1.Content = "正在关闭身份证读卡器···";
                            });

                            //关闭wosa
                            Device.IDCardDeregister();
                            Device.IDCardClose();
                            Device.IDCardCleanup();
                            break;
                        case "CashDeposit":
                            //界面显示
                            Dispatcher.Invoke(() =>
                            {
                                pg.Value = 100 * openDevice.IndexOf(name) / openDevice.Count;
                                label1.Content = "正在关闭现金存储模块";
                            });

                            //打开wosa
                            Device.CashDepositDeregister();
                            Device.CashDepositClose();
                            Device.CashDepositCleanup();
                            break;
                        default:
                            throw new Exception("未知的停止项");
                    }
                }
                Exit("");
            }
            catch(Exception e)
            {
                DevExit(e.ToString());
            }
        }

        private void DevExit(string err)
        {
            if (MessageBoxResult.OK == MessageBox.Show(err, "", MessageBoxButton.OK, MessageBoxImage.None, MessageBoxResult.OK, MessageBoxOptions.ServiceNotification))
            {
                Exit(err);
            }
        }

        private void Exit(string err)
        {
            Log.log("系统退出 " + err);
            Log.close();
            Dispatcher.Invoke(()=> {
                Application.Current.Shutdown();
            });
        }

        private static string EncryptDES(string encryptString, string encryptKey)
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
