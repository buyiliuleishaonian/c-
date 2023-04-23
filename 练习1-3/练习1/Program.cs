using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //用户输入自己的分数，然后判断优秀，良，及格，不及格
            Console.WriteLine("请输入自己的成绩");
            string number = Console.ReadLine();
            string sum=Sum(number);
            Console.WriteLine("你的成绩等级是{0}",sum);
            Console.ReadKey(true);
        }
        public static string Sum(string number)
        {
            while (true)
            {
                try
                {
                    int sum = Convert.ToInt32(number);
                    string sum1 = null;
                    if (sum < 100 && sum >= 90)
                    {
                        sum1 = "优秀";
                    }
                    else if (sum >= 80)
                    {
                        sum1 = "良好";
                    }
                    else if (sum >= 70)
                    {
                        sum1 = "合格";
                    }
                    else
                    {
                        sum1 = "不合格";
                    }
                    return sum1;
                }
                catch
                {
                    Console.WriteLine("请输入正确的成绩");
                    number = Console.ReadLine();
                }
            }
        }
    }
}
