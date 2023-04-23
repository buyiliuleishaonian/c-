using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace do_while__练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //不断要求用户输入学生姓名，输入q结束
            //string name;
            //do
            //{
            //    Console.WriteLine("请输入学生姓名");
            //    name = Console.ReadLine();
            //}
            //while (name!="q");
            //Console.WriteLine("结束输入，程序退出");
            //Console.ReadLine();

            //不断要求用户输入一个数字（假定用户输入的都是正整数）
            //当用户输入end的时候显示刚刚输入的数字中的最大值
            //循环体:每次都要输入一个数字，每次输入的数字要和之前的最大数作比较，大就留下，小就舍去
            //循环条件：不等于end
            //先设立，最大值，还有要输入的数字的变量

            double max = 0, number = 0 ;
            string input = "";
            while (input!="end")
            {
                Console.WriteLine("请输入一个数字");
                input = Console.ReadLine();
                if (input != "end")
                {
                    try
                    {
                        number = Convert.ToDouble(input);
                        if (number >= max)//让用户的最大值和我的假定的最大值作比较，就将当前的数字给最大值。
                        {
                            max = number;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("输入的不是数字，情重新输入");
                    }
                }
                else if (input == "end")
                {
                    Console.WriteLine("输出刚刚输入数字中的最大值{0}", max);
                }
               
            }
            Console.ReadKey();




            //int max = 0, number = 0;
            //string jieshu = "";
            //try//因为将字符串转化成数字量的时候，字母会报错
            //{
            //    do
            //    {
            //        Console.WriteLine("请输入一个数字");
            //        jieshu = Console.ReadLine();
            //        number = Convert.ToInt32(jieshu);
            //        if (number > max)
            //        {
            //            max = number;
            //        }
            //    }
            //    while (jieshu != "end");
            //}
            //catch
            //{
            //    Console.WriteLine("刚刚输入的数字当中最大的是{0}", max);
            //}
            //Console.ReadKey();


            //不断要求用户输入一个数字，然后打印这个数字的二倍，
            //当用输入q的时候程序退出
            //循环体：输入一个数字，判断,输出数字的两倍
            //循环条件：输入不等于q
            //int number;
            //string shuzi;
            //do
            //{
            //    Console.WriteLine("请输入一个数字");
            //    shuzi = Console.ReadLine();
            //    if (shuzi != "q")
            //    {
            //        try
            //        {
            //            number = Convert.ToInt32(shuzi);
            //            Console.WriteLine(number * 2);
            //        }
            //        catch
            //        {
            //            Console.WriteLine("输入错误，程序结束");
            //        }
            //    }
            //}
            //while (shuzi != "g");
            //Console.WriteLine("程序结束");
            //Console.ReadKey();
        }
    }
}
