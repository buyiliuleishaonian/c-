using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while循环结构
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //向控制台打印1000遍下次考试要细心
            //循环结构
            //循环体：console.writeline("下次考试一定要细心");
            //循环条件：打印一百遍,所以要设置一个变量小于100；
            //需要定义一个变量，每次循环就加1
            //int number = 0;
            //while (number<=100)
            //{
            //    Console.WriteLine("下次考试一定要细心\t{0}",number);
            //    number++;
            //}
            //Console.ReadKey();

            //求0到100的整数之和
            //循环体：0加到100,累加的过程
            //循环条件:一个变量小于等于100
            //int x = 0, y = 0;//一个变量累加，一个变量存储累加的值
            //while (y < 100)
            //{
            //    y++;
            //    x = y + x;
            //    if (y == 100)
            //    {
            //        Console.WriteLine("0到100之间的和是{0}",x);
            //    }
            //}
            //Console.ReadKey();

            //求1~100之间偶数的和
            //循环体:偶数累加的过程,还需要判断累加的数是否为偶数
            //循环条件：x<100
            int x = 0, y = 0;
            while (x < 100)
            {
                x++;
                if (x % 2 != 0)
                { 
                    y += x; 
                }
            }
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
