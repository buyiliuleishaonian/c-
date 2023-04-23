using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 三元表达式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //比较两个数字的大小
            //Console.WriteLine("请输入两个数字");
            //try
            //{
            //    int number_1 = Convert.ToInt32(Console.ReadLine());
            //    int number_2 = Convert.ToInt32(Console.ReadLine());
            //    if (number_1 > number_2)
            //    {
            //        Console.WriteLine("最大值是{0}",number_1);
            //    }
            //    else
            //    {
            //        Console.WriteLine("最大值是{0}",number_2);
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("程序输入错误，终止进行");
            //}
            //Console.ReadKey();

            //int number_1 = 0, number_2 = 0;
            //Console.WriteLine("请输入两个数值");
            //bool x = int.TryParse(Console.ReadLine(),out number_1);
            //bool y = int.TryParse(Console.ReadLine(),out number_2);
            //if (x && y)
            //{
            //    if (number_1 > number_2)
            //    {
            //        Console.WriteLine("最大值是{0}", number_1);
            //    }
            //    else
            //    {
            //        Console.WriteLine("最大值是{0}", number_2);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("程序输入错误，结束程序");
            //}
            //Console.ReadKey();


            //使用三元表达式
            //语法：表达式1？表达式2：表达式3；
            //Console.WriteLine("请输入两个数值");
            //int number_1 = Convert.ToInt32(Console.ReadLine());
            //int number_2 = Convert.ToInt32(Console.ReadLine());
            ////number_1 > number_2 ? Console.WriteLine("最大值是{0}", number_1) : Console.WriteLine("最大值是{0}",number_2);
            //int max = number_1 > number_2 ? number_1 : number_2;
            //Console.WriteLine("最大值是{0}",max);
            //Console.ReadKey();


            //请用户输入一个用户名，不是老赵就都是流氓
            Console.WriteLine("请输入用户名");
            string name = Console.ReadLine();
            string x = name == "老赵" ? "输入正确" : "流氓";
            Console.WriteLine(x);
            Console.ReadKey();
            //if (name == "老赵")
            //{
            //    Console.WriteLine("输入正确");
            //}
            //else
            //{
            //    Console.WriteLine("流氓");
            //}
            //Console.ReadKey();
        }
    }
}
