using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 逻辑运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //请输入两个数值，分别为两个的年纪
            //判断以下输入是否正确，正确输出true 错误输出false
            Console.WriteLine("请输入两个数值，作为老孙的语文和数学成绩");
            double chinese = Convert.ToDouble(Console.ReadLine());
            double math= Convert.ToDouble(Console.ReadLine());//这里显示的是，输入的两个int，string，来进行转换
            //double chinese = double.Parse(Console.ReadLine());//这里输入的是两个double类型的变量
            //double math = double.Parse(Console.ReadLine());
            //int  chinese=int.parse(console.readline());//也可以是输入int类型
            //double m = double.Parse(Console.ReadLine());
            bool x = chinese > 90 && math > 90;
            bool y = chinese > 90 || math > 90;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
