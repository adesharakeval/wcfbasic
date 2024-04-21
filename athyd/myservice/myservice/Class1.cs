using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace myservice
{
    [ServiceContract]
    interface Iservice1
    {
        [OperationContract]
        string Hello(string x);
    }

    public class Service1 :Iservice1
    {

        public string Hello(string x)
        {
            return ("Hello" + x);
        }

         
    }
}
