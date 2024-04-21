using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace wcfbasicclasslibrary
{
    [ServiceContract]
    interface Iservice1
    {
        [OperationContract]
        string Hello(string x);
    }

    public class Class1 :Iservice1
    {
        

        public string Hello(string x)
        {
            return ("hello :" + x);
        }

        
    }
}
