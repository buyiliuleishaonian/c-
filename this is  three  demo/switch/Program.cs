using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入工资评级，A，升500，B，升200，C，不升，D，降两百，E，降500；
            Console.WriteLine("请输入评级等级");
            string level = Console.ReadLine();
            decimal salary = 5000.0m;
            bool x = true;
            #region  if选择
            //if (level == "A")//对于字符串的等于 需要使用 ==
            //{
            //    salary += 500;
            //}
            //else if (level == "B")
            //{
            //    salary += 200;
            //}
            //else if (level == "C")
            //{

            //}
            //else if (level == "D")
            //{
            //    salary -= 200;
            //}
            //else if (level == "E")
            //{
            //    salary -= 500;
            //}
            //else
            //{
            //    Console.WriteLine("程序错误，请重新输入");
            //    x = false;
            //}
            //if (x)
            //{
            //    Console.WriteLine("你的工资为{0}", salary);//当用户输入的不是ABCDE，这行代码就不应该执行
            //}
            #endregion
            switch (level)
            {
                case "A":
                    salary += 500;
                    break;
                case "b":
                    salary += 200;
                    break;
                case "C":
                    salary += 0;
                    break;
                case "D":
                    salary -= 200;
                    break;
                case "E":
                    salary -= 500;
                    break;
                default:
                    Console.WriteLine("程序错误");
                    x = false;
                    break;
            }
            if (x)
            {
                Console.WriteLine("薪水{0}", salary);
            }
            Console.ReadKey();
        }
    }
}
