using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if语句练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入三个数值，输出最大值
            Console.WriteLine("输入三个数值");
            double number_1 = Convert.ToDouble(Console.ReadLine());
            double number_2 = Convert.ToDouble(Console.ReadLine());
            double number_3 = Convert.ToDouble(Console.ReadLine());
            #region  三用if语句
            //第一个数值大于第二个和第三个数值
            if (number_1 > number_2 && number_1 > number_2)
            {
                Console.WriteLine(number_1);
            }
            if (number_2 > number_1 && number_2 > number_3)//可以用else if  第二个数值大于第一个和第三个数值
            {
                Console.WriteLine(number_2);
            }
            if (number_3 > number_1 && number_3 > number_2)//用else  可以输出，第三个数值大于第一个和第二个数值
            {
                Console.WriteLine(number_3);
            }
            Console.ReadKey();
            #endregion
            #region   设置一个变量来存储最大值
            //设置一个变量来存储最大值
            //double max =number_1;
            //if (max > number_2)//第一个数值大于第二个数值
            //{
            //    if (max > number_3)//在比较第三个数值
            //    {
            //        Console.WriteLine(max);
            //    }
            //    else
            //    {
            //        console.writeline(max);  
            //    }
            //}
            //else
            //{
            //    max = number_2;
            //    if (max > number_3)
            //    {
            //        Console.WriteLine(max);
            //    }
            //    else
            //    {
            //        max = number_3;
            //        Console.WriteLine(max);
            //    }
            //}
            //Console.ReadKey();
            #endregion

            #region     用户输入密码
            //提示用户输出输入密码，如果密码88888，则提示密码正确，否则，要求再输入一次，输入88888
            //则显示密码正确，反之就是错误，程序结束
            Console.WriteLine("请输入密码");
            string password = Console.ReadLine();
            //bool display = password = ="88888";
            if (password == "88888")
            {
                Console.WriteLine("正确");
            }
            else
            {
                Console.WriteLine("密码错误，再次输入密码");
                 password = Console.ReadLine();//可以重复的变量来接受
                if (password== "88888")
                {
                    Console.WriteLine("正确");
                }
                else
                {
                    Console.WriteLine("密码输入错误，程序结束");
                }
            }
            Console.ReadKey();
            #endregion

            //用if语句，来判断用户名和密码
            #region
            //Console.WriteLine("请输入用户名");
            //string userName = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //string password = Console.ReadLine();
            //if (userName == "admin" && password == "88888")
            //{
            //    Console.WriteLine("正确");
            //}
            //else if (userName != "admin")
            //{
            //    Console.WriteLine("用户名不存在");
            //}
            //else if (userName == "admin" && password != "88888")
            //{
            //    Console.WriteLine("密码错误");
            //}
            //Console.ReadKey();
            #endregion


            #region
            //输入用户年龄，判断年龄之后确认是否观看
            Console.WriteLine("请输入您的年龄");
            double age = Convert.ToDouble(Console.ReadLine()) ;
            if (age >=18)
            {
                Console.WriteLine("可以查看");
            }
            else if (age >= 10)
            {
                Console.WriteLine("请输入是否选择查看");
                string x = Console.ReadLine();
                if (x == "yes")
                {
                    Console.WriteLine("继续查看");
                }
                else
                {
                    Console.WriteLine("不继续查看");
                }
            }
            else
            {
                Console.WriteLine("不能查看");
            }
            Console.ReadKey();
            #endregion
        }
    }
}
