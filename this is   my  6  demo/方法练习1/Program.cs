using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入两个数字，计算这两个数字之间所有的整数和
            //1、用户只能输入数字
            //2、计算两个数字之间的和
            //3、要求第一个数字比第二个数字小就重新输入。
            Console.WriteLine("请输入第一个数字");
            string numberOne = Console.ReadLine();
            int number1 = Test(numberOne);
            Console.WriteLine("请输入第二个数字");
            string numberTwo = Console.ReadLine();
            int number2 = Test(numberTwo);
            //比较两个数
            Test1(ref number1,ref number2);
            //计算两个数之间所有数字的和
            int sum = Sum(number1,number2);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        /// <summary>
        /// 判断一个字符串，是否可以转成数字，不行就重新输入
        /// </summary>
        /// <param name="n1">输入一个字符串</param>
        /// <returns>输出</returns>
        public static int Test(string n1)
        {
            int s1;
            while (true)
            {
                try
                {
                    s1 = Convert.ToInt32(n1);
                    return s1;
                }
                catch
                {
                    Console.WriteLine("输入有误，请重新输入");
                    n1 = Console.ReadLine();
                }
            }
        }
        /// <summary>
        /// 判断两个数，第一个数，比第二个数小，不然重新赋值，比较
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void Test1(ref int x,ref int y)
        {
            while (true)
            {
                if (x <y)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("第一个数必须比第二个数小，请重新输入");
                    string n1 = Console.ReadLine();
                    x = Test(n1);
                    string n2 = Console.ReadLine();
                    y = Test(n2);
                }
            }
        }
        /// <summary>
        /// 将两个数之间的整数，全部相加
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Sum(int x,int y)
        {
            int sum = y;
            for (int n=x;x<y;x++)
            {
                sum += x ;
            }
            return sum;
        }
    }
}
