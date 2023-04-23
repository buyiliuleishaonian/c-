using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //用方法来实现，一个字符串的数组
            //求出其中最长的元素，然后将其输出。
            //string[] str = { "111", "22222222", "2333333", "1122222" };
            //string number=Getlength(str);
            //Console.WriteLine(number);
            //Console.ReadKey();

            //用方法来求解一个整型数组的平均值，保证两位小数
            //int[] number = { 1,2,7};
            //double sum=GetSum(number);
            //string test = sum.ToString("0.00");//先将数字转换成字符串，可以指保留两位
            //sum = Convert.ToDouble(test);
            //Console.WriteLine(sum);
            //Console.ReadKey();


            //写一个方法，判断输入进来的是不是质数，
            //如果不是质数，请重新输入
            while (true)
            {
                Console.WriteLine("请输入一个数字");
                string number = Console.ReadLine();
                int sum = Number(number);
                bool x = ZhiShu(sum);
                Console.WriteLine(x);
                Console.ReadKey();
            }
            


        }
        /// <summary>
        /// 判断一个字符串数组里面，将最长元素输出
        /// </summary>
        /// <param name="x"></param>
        public static string Getlength(string[] x)
        {
            string  a = x[0];
            for (int y=0;y<x.Length;y++)
            {
                if (a .Length< x[y].Length)
                {
                    a = x[y];
                }
            }
            return a;
        }
        /// <summary>
        /// 将一个数组里面，所有元素相加，的平均数，保留两位小数
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static double GetSum(int[] number)
        {
            double  sum = 0;
            for (int x = 0; x < number.Length;x++)
            {
                sum += number[x];
            }
            return sum/number.Length;
        }
        /// <summary>
        /// 输入一个字符串，将其转换成数字，不行就重新输入
        /// </summary>
        /// <param name="number"></param>
        /// <returns>输出转换之后的数字</returns>
        public static int  Number(string number)
        {
            while (true)
            {
                try
                {
                    int x = Convert.ToInt32(number);
                    return x;
                }
                catch
                {
                    Console.WriteLine("输入错误，请重新输入");
                    number = Console.ReadLine();
                }
            }
        }
        /// <summary>
        /// 判断一个数，是否是质数
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool ZhiShu(int number)
        
        {
            if(number < 2)
            { 
            return false;
            }
            else
            {
                for (int x = 2; x < number; x++)
                {
                    if (number % x == 0)//给非质数成立的
                    {
                        return false;
                    }
                }
                return true;//给质数成立的
            }
        }
    }
}
