using System.Threading;

namespace BankApp
{
    class simulation
    {
        public delegate void Error(string err);
        public Error err;

        public void startUp1()
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
