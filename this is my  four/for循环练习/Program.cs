using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for循环练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1~100之间的整数和，奇数和，偶数和
            //int sum = 0,x=0,y=0;
            //for (int i = 0; i < 100; i++)
            //{
            //    sum += i;
            //    if (i % 2 == 0)
            //    {
            //        x += i;
            //    }
            //    else
            //    {
            //        y += i;
            //    }
            //}
            //Console.WriteLine("1~100中整数和是{0}，奇数和是{1}，偶数和是{2}",sum,x,y);
            //Console.ReadKey();

            //从100~999中找出水仙花数
            //水仙花数指的这个数字的百位数字，
            //百位的立方+十位的立方+个位的立方==当前这个百位数的立方
            //153   1 + 125 + 27=153

            int Hundreds = 0, decade=0, theUnit=0,x=0;
            for (int i=100;i<1000;i++)
            {
                Hundreds = i / 100;
                decade = (i % 100) / 10;
                theUnit= ((i % 100)%10);
                x = Hundreds *Hundreds*Hundreds+decade*decade*decade+theUnit*theUnit*theUnit;
                if (x==i)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
