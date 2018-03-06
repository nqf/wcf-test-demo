using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace WCFHelloWorld
{
    public  class HostMain
    {
        static void Main(string[] args)
        {
            /** 
            //创建一个Host对象
            ServiceHost host = new ServiceHost(typeof(WCFService), new Uri("http://localhost:8080/HelloToYou"));
            host.AddServiceEndpoint(typeof(IWCFService), new BasicHttpBinding(), "Svc");
            host.Open();
            Console.WriteLine("I'am Here.");
            Console.ReadKey();
            host.Close();
            ***/
            ServiceHost host = new ServiceHost(typeof(WCFService));
            // HTTP方式
            WSHttpBinding httpBinding = new WSHttpBinding(SecurityMode.None);
            host.AddServiceEndpoint(typeof(IWCFService), httpBinding, "http://localhost:8900/");
            // 打开服务
            host.Open();
            Console.WriteLine("server start");
            Console.Read();
            host.Close(); 
        }
    }
}