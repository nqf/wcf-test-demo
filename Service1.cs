using System;
using System.Collections.Generic;
using System.Text;

namespace WCFHelloWorld
{
    class WCFService: IWCFService
    {
        #region IWCFService 成员

        public void SayHello()
        {
            Console.WriteLine("server Hello ,You!");
        }

        #endregion
    }
}