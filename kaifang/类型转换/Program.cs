using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类型转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            double m = 10;
            double d = m / n;//右边的数 称为操作数，改变任何一个操作数变为double，则整个表达式升为double
            Console.WriteLine("{0:0.00}",d);//输出 3 只不过类型为 double，保证小数点后面留两位
            Console.ReadKey();
        }
    }
}
