using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //声明两个变量 int n1=10,n2=20;
            //不用第三方变量将其交换
            int n1 = 10, n2 = 20;
            n2 = n1;
            n1 = n2 + n1;
            Console.WriteLine("{0},{1}",n1,n2);
            Console.ReadKey(true);
        }
    }
}
