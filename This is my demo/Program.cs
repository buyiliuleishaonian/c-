using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_my_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("This  is  my  demo ");*/
            //将“ ”输出
            Console.WriteLine("hello word ");
            Console.ReadKey();//暂停，任意键后继续
            Console.WriteLine("文憔悴最帅");
            Console.ReadKey();
            Console.WriteLine("布衣流泪少年");
            Console.ReadKey();
            Console.WriteLine("孤高自傲少年郎");

            #region  这些代码是没有用的，但是不想删的
            //Console.WriteLine("hello word ");
            //Console.ReadKey();//暂停，任意键后继续
            //Console.WriteLine("文憔悴最帅");
            //Console.ReadKey();
            //Console.WriteLine("布衣流泪少年");
            //Console.ReadKey();
            //Console.WriteLine("孤高自傲少年郎");
            #endregion
        }



        /// <summary>
        /// 方法是比较两个整数之间比较大的数字
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <returns>返回比较大的那个数字</returns>
        public static int Getmax(int n1, int n2)//表明两个整数谁大，输出谁
        {
            return n1 > n2 ? n1 : n2;
        }
        /// <summary>
        /// 这个类用描述一个人的信息，从姓名 年龄 性别
        /// </summary>
        public class person//新的一个类
        {
            public string Name
            {
                get;
                set;
            }
            public int Age
            {
                get;
                set;
            }
            public char Gender//年龄
            {
                get;
                set;
            }
        }
    }
}
