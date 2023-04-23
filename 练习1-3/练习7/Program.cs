using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //将int类型，不用第三方变量
            //用方法来封装
            int n1 = 10, n2 = 20;
            Test(ref n1,ref n2);
            Console.WriteLine(n1+"\t");
            Console.WriteLine(n2);
            Console.ReadKey(true);
        }
        /// <summary>
        /// 将两个int类型交换
        /// </summary>
        public static void Test(ref int n1,ref int n2)
        {
            n2 = n2-n1;
            n1 = n2 + n1;
        }
    }
}
