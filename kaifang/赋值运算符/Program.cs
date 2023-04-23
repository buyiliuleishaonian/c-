using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 赋值运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numder = 1;
            numder = 12;//重新赋值,给一个变量重新赋值，老值就不存在啦
            Console.WriteLine(numder);
            Console.ReadKey();

        }
    }
}
