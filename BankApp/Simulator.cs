using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace BankApp
{
    //StartUp（启动，将应用程序连接到XFS管理器，包括版本协商）
    //    Open（打开，在应用程序和服务提供程序间建立会话）
    //      Register（注册，指定应用程序应该从服务提供程序收到的消息）
    //        Lock（锁定，通过应用程序获得对服务的唯一访问）
    //            多个Execute（执行）函数，传递一个或多个具体命令：
    //            Print_Form（打印表格）
    //            等等
    //        UnLock（解锁，通过应用程序获得对服务的唯一访问）
    //      Deregister（注销，指定应用程序不再从服务提供程序收到消息）
    //    Close（关闭，结束应用程序和服务提供程序间的会话）
    //CleanUp（清除，断开应用程序和XFS管理器的连接）

    public class Simulator
    {
        public delegate void Error(string err);
        public Error err;//需要退出的错误

        #region ID card reader block

        public void IDCardStartUp()
        {
            Thread.Sleep(300);
            Log.log("启动身份证阅读器");
        }

        public void IDCardOpen()
        {
            Thread.Sleep(300);
            Log.log("打开身份证阅读器");
        }

        public void IDCardRegister()
        {
            Thread.Sleep(300);
            Log.log("注册身份证阅读器");
        }

        public void IDCardLock()
        {
            Thread.Sleep(300);
            Log.log("锁定身份证阅读器");
        }

        public string IDCardExec()
        {
            Thread.Sleep(1300);
            Log.log("读取身份证阅读器");
            return "{idCard:{idCode:131313,gender:'male'},errCode:1,msg:'kk'}";
        }

        public void IDCardUnlock()
        {
            Thread.Sleep(300);
            Log.log("解锁身份证阅读器");
        }

        public void IDCardDeregister()
        {
            Thread.Sleep(300);
            Log.log("注销身份证阅读器");
        }

        public void IDCardClose()
        {
            Thread.Sleep(300);
            Log.log("关闭身份证阅读器");
        }

        public void IDCardCleanup()
        {
            Thread.Sleep(300);
            Log.log("清除身份证阅读器");
        }

        #endregion

        #region finger prints reader block

        [DllImport("TesoLive.dll")]
        public static extern int TcCreateHDL(int port = 0, int protocol = 0, int index = 3, int speed = 0);
        [DllImport("TesoLive.dll")]
        public static extern int TcDoTemplate(int port, StringBuilder buf, ref int len, StringBuilder err);
        [DllImport("TesoLive.dll")]
        public static extern int TcDoFeature(int handle,ref StringBuilder o);
        [DllImport("TesoLive.dll")]
        public static extern int TcDeleteHDL(int handle);


        public void FingerPrintStartUp()
        {
            Thread.Sleep(300);
            Log.log("启动指纹仪");
        }

        public void FingerPrintOpen()
        {
            Thread.Sleep(300);
            Log.log("打开指纹仪");
        }

        public void FingerPrintRegister()
        {
            Thread.Sleep(300);
            Log.log("注册指纹仪");
        }

        public void FingerPrintLock()
        {
            Thread.Sleep(300);
            Log.log("锁定指纹仪");
        }

        public string FingerPrintExec()
        {
            Thread.Sleep(2300);
            Log.log("读取指纹仪");
            StringBuilder buf = new StringBuilder("");
            StringBuilder err = new StringBuilder("");
            int handle = TcCreateHDL();
            StringBuilder b = new StringBuilder("");
            int ret = TcDoFeature(handle,ref b);
            TcDeleteHDL(handle);
            Console.WriteLine(ret);
            return "{fingerPrints:{pic:'FIOWU3273RYHUIFDJ384272HJIWE3'},errCode:-1,msg:'error fp'}";
        }

        public void FingerPrintUnlock()
        {
            Thread.Sleep(300);
            Log.log("解锁指纹仪");
        }

        public void FingerPrintDeregister()
        {
            Thread.Sleep(300);
            Log.log("注销指纹仪");
        }

        public void FingerPrintClose()
        {
            Thread.Sleep(300);
            Log.log("关闭指纹仪");
        }

        public void FingerPrintCleanup()
        {
            Thread.Sleep(300);
            Log.log("清除指纹仪");
        }

        #endregion

        #region cash deposit block

        public void CashDepositStartUp()
        {
            Thread.Sleep(300);
            Log.log("启动现金存储模块");
        }

        public void CashDepositOpen()
        {
            Thread.Sleep(300);
            Log.log("打开现金存储模块");
        }

        public void CashDepositRegister()
        {
            Thread.Sleep(300);
            Log.log("注册现金存储模块");
        }

        public void CashDepositLock()
        {
            Thread.Sleep(300);
            Log.log("锁定现金存储模块");
        }

        public string CashDepositExec()
        {
            Thread.Sleep(300);
            Log.log("读取现金存储模块");
            return "{cash:{amount:10000},errCode:0}";
        }

        public void CashDepositUnlock()
        {
            Thread.Sleep(300);
            Log.log("解锁现金存储模块");
        }

        public void CashDepositDeregister()
        {
            Thread.Sleep(300);
            Log.log("注销现金存储模块");
        }

        public void CashDepositClose()
        {
            Thread.Sleep(300);
            Log.log("关闭现金存储模块");
        }

        public void CashDepositCleanup()
        {
            Thread.Sleep(300);
            Log.log("清除现金存储模块");
        }

        #endregion
    }
}