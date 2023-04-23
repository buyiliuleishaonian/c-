using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 关系运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //大象的重量是（1500）>老鼠的重量（1）
            //关系表达式的结果用bool类型输出
            //bool s = 1500 > 1;
            //Console.WriteLine(s);
            //Console.ReadKey();

            //兔子的寿命（3）>乌龟的寿命（1000）
            bool age = 3 > 1000;
            Console.WriteLine(age);
            Console.ReadKey();

            //39<18,我的年龄20==你的年龄20
            //bool number = 39 < 18;
            bool number = 20 == 20;
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
