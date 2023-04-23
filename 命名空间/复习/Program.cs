using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 复习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person people1 = new Person("蒋国文",22,'男');
            people1.SayHello();
            Console.ReadKey(true);
        }
    }
}
