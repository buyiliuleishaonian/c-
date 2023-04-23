using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace continue联系
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //用while continue实现计算1到00之间除了被7整除之外所有整数的和
            //int x=0,sum=0;
            //while (x<100)
            //{
            //    x++;  
            //    if (x % 7 == 0)//先判断是否满足整除7
            //    {
            //        continue;
            //    }
            //    sum += x;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();


            //int x = 0, sum = 0;
            //while (x <= 100)
            //{
            //    x++;
            //    if (x % 7 == 0)
            //    {
            //        continue;
            //    }
            //    sum += x;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();


            //找出100以内的所有素数//让用户输入一个数
            //让本身的数，7 7%1 7%2 7%3 7%4 7%5 7%6
            //bool z = true;  当等于4时，把z=false，之后，z没有复位
            for (int x=2;x<=100;x++)
            {
                bool z = true;//每次开始循环的时候，使之等于1，确保每次可以判断输出。
                //bool z = true;//为什么要放在里面，
                for (int y = 2; y < x ; y++)
                {
                    
                    if (x % y == 0)//可以整除，不是质数,跳出循环
                    {
                        z = false;
                        break;
                    }
                }
                if (z)
                {
                    Console.Write(x);
                    //Console.WriteLine(x);
                }
            }
            Console.ReadKey();
        }
    }
}
