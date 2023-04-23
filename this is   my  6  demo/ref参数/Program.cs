using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref参数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //使用方法交换两个类型的变量
            int n1 = 10;
            int n2 = 22;
            Test(ref n1,ref n2);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.ReadKey();
        }
        public static void Test(ref int n1,ref int n2)
        {
            int number = n1;
            n1 = n2;
            n2 = number;
        }
    }
}
