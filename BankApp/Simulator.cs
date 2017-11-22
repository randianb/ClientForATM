using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

    class Simulator
    {
        public delegate void Error(string err);
        public Error err;//需要退出的错误

        public static void IDCardStartUp()
        {
            Thread.Sleep(300);
            //err("startup error");
        }

        public static void IDCardOpen()
        {
            Thread.Sleep(300);
        }

        public void startUp2()
        {
            Thread.Sleep(300);
            Log.log("in startup 2");
        }

        public void startUp3()
        {
            Thread.Sleep(300);
        }
    }
}
