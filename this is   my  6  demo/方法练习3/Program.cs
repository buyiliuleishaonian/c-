using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace 方法练习3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //接受输入之后，判断其其等级，并且输出来
            //90~100优，80`90良
            //while (true)
            //{
            //    Console.WriteLine("请输入学员的成绩");
            //    string sum = Console.ReadLine();
            //    string x = Sum(sum);
            //    Console.WriteLine("此学员的成绩为{0}", x);
            //    Console.ReadKey();
            //}


            //将字符串中的元素反转
            //{中国，巴西，加拿大，纽约，东京}
            //string[] str = { "中国", "巴西", "加拿大", "纽约", "东京" };
            //Test(str);
            //Console.ReadKey();

            //写一个方法来计算圆的面积和周长
            Console.WriteLine("请输入圆的半径");
            int r = Convert.ToInt32(Console.ReadLine());
            double s, c;
            Test1(r,out s,out c);
            Console.WriteLine("关于半径为{0},面积是{1},周长是{2}",r,s,c);
            Console.ReadKey();
        }
        /// <summary>
        /// 判断输入的数字的等级，错误就重新输入
        /// </summary>
        /// <param name="number">输入的数字</param>
        /// <returns>输出等级</returns>
        public static string Sum(string number)
        {
            string x;
            while (true)
            {
                try
                {
                    int sum = Convert.ToInt32(number);
                    if (sum >= 90 && sum <= 100)
                    {
                        return x = "优";
                    }
                    else if (sum >= 80)
                    {
                        return x = "良";
                    }
                    else
                    {
                        return x = "差";
                    }
                }
                catch
                {
                    Console.WriteLine("输入错误，请重新输入");
                    number = Console.ReadLine();
                }
            }
        }
        /// <summary>
        /// 将一个字符串的数组，反转之后输出
        /// </summary>
        /// <param name="str">输入的字符串</param>
        public static void  Test(string[] str)
        {
            for (int x=0;x<str.Length/2;x++)
            { 
                string s = str[str.Length -1- x];
                str[str.Length - 1-x] = str[x];
                str[x] = s;
            }
            for (int y = 0; y < str.Length; y++)
            {
                Console.WriteLine(str[y]);
            }
        }
        public static void  Test1( int r,out double s,out double c)
        {
            s = r * r * 3.14;
             c= 2 * r * 3.14;
        }
    }
}
