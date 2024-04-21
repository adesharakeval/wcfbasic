using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clientforwcfbasic
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Iservice1Client obj = new ServiceReference1.Iservice1Client();
            string x = obj.hello("krunal");
            Console.WriteLine(x);
            Console.ReadKey();

        }
    }
}
