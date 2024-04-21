using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ClassLibrary1
{
    [ServiceContract]
    interface Iservice1
    {
        [OperationContract]
        string hello(string x);
    }

    public class Class1 : Iservice1
    {
         

        public string hello(string x)
        {
            return (x + "hello");
        }

       
    }
}
