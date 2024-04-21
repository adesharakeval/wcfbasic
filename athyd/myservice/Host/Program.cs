using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using myservice;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost obj = new ServiceHost(typeof(myservice.Service1));
            obj.Open();
            Console.WriteLine("Server alive");
            Console.ReadKey();
            obj.Close();
        }
    }
}
