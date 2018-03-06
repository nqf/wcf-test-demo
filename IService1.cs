using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace WCFHelloWorld
{
    [ServiceContract]
    interface IWCFService
    {
        [OperationContract]
        void SayHello();
    }
}