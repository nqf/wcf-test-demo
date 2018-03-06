using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace client
{
    public  class myclient
    {
        static void Main(string[] args)
        {
            EndpointAddress edpHttp = new EndpointAddress("http://localhost:8900/");  
            // 创建Binding  
            WSHttpBinding httpBinding = new WSHttpBinding(SecurityMode.None);  
            // 创建通道  
            ChannelFactory<WCFHelloWorld.IWCFService> factory = new ChannelFactory<WCFHelloWorld.IWCFService>(httpBinding);  
            WCFHelloWorld.IWCFService channel = factory.CreateChannel(edpHttp);  
            // 调用  
            channel.SayHello();  
            // 关闭通道  
            ((IClientChannel)channel).Close();  
        }
    }
}