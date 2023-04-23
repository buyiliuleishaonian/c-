using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 交换变量
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //需要创建第三方变量
            //int numder_1 = 1;
            //int numder_2 = 2;
            //int numder_3;
            //numder_3 = numder_1;
            //numder_1 = numder_2;
            //numder_2 = numder_3;
            //Console.WriteLine(numder_2);
            //Console.ReadKey();


            //交换变量，不适用第三方变量
            //可以利用加减，来达到目的
            // 这里交换的int，数字类型，可以用加减，但是字符，字符串就不行。
            int n1 = 10;
            int n2 = 20;
            n1 = n1 - n2;//n1=-10
            n2 = n1 + n2;//n2=10
            n1 = n2 - n1;//n1=20
            Console.WriteLine("交换后的n1={0}，n2={1}",n1,n2);
            Console.ReadKey();
        }
    }
}
