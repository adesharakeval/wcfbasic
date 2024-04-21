using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using ClassLibrary1;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost h = new ServiceHost(typeof(ClassLibrary1.Class1));
            h.Open();
            Console.WriteLine("I am alive");
            Console.ReadKey();
            h.Close();
        }
    }
}
