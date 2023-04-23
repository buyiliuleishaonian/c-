using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //用方法来写一个判断数是否为质数
            Console.WriteLine("随便输入一个数");
            int num = Convert.ToInt32(Console.ReadLine()) ;
             string str=Test(num);
            Console.WriteLine(str);
            int sum = Test1();
            Console.WriteLine(sum);
            Console.ReadKey(true);
        }
        /// <summary>
        /// 判断一个数是否是质数
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string Test(int num)
        {
            string str = null;
            if (num == 2)
            {
                return str = "是";
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                       return str = "不是";

                    }
                }
                return str = "是";
            }
            return str;
        }
        /// <summary>
        /// 将0~100的质素相加
        /// </summary>
        public static int Test1()
        {
            int sum = 0;
            
            for (int i = 2; i <=100; i++)
            {
                bool b = true;
                for (int x = 2; x <i; x++)
                {
                    if (i % x == 0)
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    sum += i;
                }
            }
            return sum ;
        }
    }
}
