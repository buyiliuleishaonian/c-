using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //编写函数，将用户输入的字符串的第一个数组转换成大写，然后然后返回字符串
            Console.WriteLine("请随便输入一串字母");
            string str = Console.ReadLine();
            str = Test(str);
            Console.WriteLine(str);
            Console.ReadKey(true);
        }
        public static string Test(string str)
        {
            string dXie = str.Substring(0, 1);
            if (str.Contains(dXie))
            {
                str = str.Replace(dXie, dXie.ToLower());
            }
            return str;
        }
    }
}
