using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if语法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //编程实现，如果跪键盘的时间大于60分钟，那么媳妇就奖励我晚饭不用做了
            Console.WriteLine("请输入你跪键盘的时间");
            double minute = Convert.ToDouble(Console.ReadLine());
            //再if 语法上 ==true 可以省略
            //当（）里面要表达 false的时候执行，则不可以省略==false
            if (minute>60==true)
            {
                Console.WriteLine("你可以不用做晚饭");
                Console.ReadKey();
            }
        }
    }
}
