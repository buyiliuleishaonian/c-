using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert类型转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入一个数值，并且向控制台打印用户输入的数字的两倍
            Console.WriteLine("请输入一个数值");
            //string numder = Console.ReadLine();
            /*double numder_1 = Convert.ToDouble(numder);*///因为控制台接收用户的输入是console.readline();
            double numder = Convert.ToDouble(Console.ReadLine());//就可以直接用console.readline()来代替
            /*numder_1 = numder_1 * 2*/;
            numder = numder * 2;
            Console.WriteLine(numder);
            Console.ReadKey();
        }
    }
}
