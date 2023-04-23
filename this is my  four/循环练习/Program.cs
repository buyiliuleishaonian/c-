using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace 循环练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //请依次输入五个人的数据
            //如果有大于100或者小于为负数的，就跳出循环
            //int number = 0, z = 0;
            //bool y = true;
            //for (int x = 0; x < 5; x++)
            //{
            //    Console.WriteLine("请输入{0}数字", x);
            //    y = int.TryParse(Console.ReadLine(), out number);//这里也可以使用try catch来异常捕获
            //    if (number < 100 && number > 0 && y)
            //    {
            //        z = number + z;
            //    }
            //    else
            //    {
            //        Console.WriteLine("输入数据出现错误，程序终止");
            //        break;//x = 5;使用break 跳出循环，也可以在 switch 判断里面跳出判断，
            //    }
            //}
            //if (y == true)
            //{
            //    Console.WriteLine("刚刚输入五个数字的平均数是{0}", z / 5);
            //}
            //Console.ReadKey();



            //在while中用break实现要求用户一直输入用户名密码，
            //要求不是admin  和88888 就一直重新输入
            //循环条件：用户名和密码不正确
            //循环体：就是要求一直输入，输出，验证
            //string userName = "", passWord = "";
            //while (userName != "admin" && passWord != "88888")
            //{
            //    Console.WriteLine("请输入用户名");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    passWord = Console.ReadLine();
            //}
            //Console.WriteLine("输入正确");
            //Console.ReadKey();
            //string userName = "", passWord = "";
            //while (true)
            //{
            //    Console.WriteLine("请输入用户名");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    passWord = Console.ReadLine();
            //    if (userName == "admin" && passWord == "88888")
            //    {
            //        Console.WriteLine("输入成功");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("用户名或者密码输入错误，请重新输入");
            //    }
            //}
            //Console.ReadKey();



            //1~100之间的整数相加，得到累加值大于20的当前数（比如1+2+3+4+5+6=21结果 6 sum>=20）
            int sum = 0;
            for (int x = 0; x <= 100; x++)
            {
                sum += x;
                if (sum > 20)
                {
                    Console.WriteLine(x);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
