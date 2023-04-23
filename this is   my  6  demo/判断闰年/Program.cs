using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判断闰年
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //写一个方法判断闰年。
            Console.WriteLine("请输入一个年份判断是不是闰年");
            try
            {
                int year = Convert.ToInt32(Console.ReadLine());
                bool b=IsRunYear(year);//需要用一个值来接应使用方法之后的值
                if (b)
                {
                    Console.WriteLine("是闰年");
                }
                else
                {
                    Console.WriteLine("不是闰年");
                }
            }
            catch
            {
                Console.WriteLine("输入错误程序结束");
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 判断是否是闰年
        /// </summary>
        /// <param name="year">年份</param>
        /// <returns>输出bool类型</returns>
        public static bool IsRunYear(int year )
        {
            bool b = (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0));
            return b;
        }
    }
}
