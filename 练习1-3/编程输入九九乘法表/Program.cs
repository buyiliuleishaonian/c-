using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 编程输入九九乘法表
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 9; i >=0; i--) 
            {
                for (int x = 1; x<=i; x++)
                {
                    Console.Write("{0}*{1}={2}\t",i,x,i*x);
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}
