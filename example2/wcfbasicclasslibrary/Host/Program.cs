using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using wcfbasicclasslibrary;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost h = new ServiceHost(typeof(wcfbasicclasslibrary.Class1));
            h.Open();
            Console.WriteLine("I am alive");
            Console.ReadLine();
            h.Close();
        }
    }
}
