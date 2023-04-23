using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_if语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  if-else if()
            Console.WriteLine("请输入一个数值");
            double socre = Convert.ToDouble(Console.ReadLine());
            if (socre >= 90)
            {
                Console.WriteLine("A");
            }
            else if (socre >= 80)
            {
                Console.WriteLine("B");
            }
            else if (socre >= 70)
            {
                Console.WriteLine("C");
            }
            else if (socre >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("E");
            }
            Console.ReadKey();
#endregion
        }
    }
}
