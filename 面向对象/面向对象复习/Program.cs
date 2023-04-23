using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象复习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person name = new Person();
            name.Name = "蒋国文";
            name.Age = 22;
            name.Gender = '男';
            name.SayHello();
            Console.ReadKey(true);
        }
    }
}
