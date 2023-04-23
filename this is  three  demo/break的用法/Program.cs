using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break的用法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 0;
            //while (x<=100)
            //{
            //    Console.WriteLine("hello world");
            //    x++;
            //    break;
            //}
            //Console.ReadKey();

            int x = 0, y = 0;
            while (x<=10)
            {
                while (y <= 10)
                {
                    Console.WriteLine("hello,world");
                    y++;//这个循环还是执行10遍
                    break;//跳出当前的循环
                }
                Console.WriteLine("HELLO,WORLD");
                x++;
            }
            Console.ReadKey();
        }
    }
}
