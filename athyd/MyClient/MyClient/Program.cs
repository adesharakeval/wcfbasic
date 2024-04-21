using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Iservice1Client obj = new ServiceReference1.Iservice1Client();
            string x= obj.Hello("Krunal");
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
