using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace BankApp
{
    static class Log
    {
        public static string prefix = "E:\\github\\ClientForATM";
        //public static string prefix = ".";
        private static FileStream fs;
        private static StreamWriter s;
        public static void open()
        {
            string path = prefix + "\\Log\\" +
                DateTime.Now.ToString("yyyyMMdd") +
                ".txt";
            fs = new FileStream(path, FileMode.Append);
            s = new StreamWriter(fs);
        }

        public static void log(string con)
        {
            lock(s)
            {
                con = "[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") +
                    "] " + con;
                s.WriteLine(con);
            }
        }

        public static void close()
        {
            s.Close();
            fs.Close();
        }
    }
}
