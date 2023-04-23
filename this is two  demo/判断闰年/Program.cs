using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判断闰年
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入判断的数值");
            double year = Convert.ToDouble(Console.ReadLine());
            //年份可以被400整除，不可以被（2000）
            //年份能够被4整除，但不能被100整除

            bool x = (year % 400 == 0 )|| (year % 4== 0 && year % 100 != 0);//这里就可以不写（），在用一个表达式当中
            //同时存在 ||，&&，先执行&&，再执行||
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
