using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 复习;

namespace 命名空间
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person zhangsan = new Person("张三",18,'男');
            zhangsan.SayHello();
            Console.WriteLine();
        }
    }
}
