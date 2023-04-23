using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 算术运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //+号的运算
            //int chinese = 90;
            //int math = 66;
            //int english = 70;
            //Console.WriteLine("总成绩是{0}，平均成绩是{1}",chinese+math+english,(chinese+math+english)/3);
            //Console.ReadKey();

            //计算半径为5的圆的面积和周长
            //等号两把边的数据类型要一样
            int T_shirt = 35;
            int trousers = 120;
            int money = (3 * T_shirt) + (2 * trousers);
            double shiji = money * 0.88;//int转double 是自动类型转换，隐式类型转换
            Console.WriteLine("实际的为{0}，打8.8折后为{1}", money, shiji);


            double d = 33.2;
            // double -int  强制类型转换   显示类型转换

            int n = (int)d;
            Console.WriteLine(n);



        }
    }
}
