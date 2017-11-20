using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace BankApp
{
    static class Log
    {
        private static FileStream fs;
        private static StreamWriter s;
        public static void open()
        {
            string path = "E:\\github\\ClientForATM\\Log\\" +
                DateTime.Now.ToString("yyyyMMdd") +
                ".txt";
            fs = new FileStream(path, FileMode.Append);
            s = new StreamWriter(fs);
        }

        public static void log(string con)
        {
            lock(s)
            {
                con = "[" + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") +
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
