using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名函数
{
    internal class Program
    {
        public delegate void MyDelegate(string name);
        public delegate string MydelegateString(string name);
        static void Main(string[] args)
        {
            MyDelegate del = delegate (string name) { Console.WriteLine("你好" + name); };
            del("文憔悴");
            //lamda表达式
            MyDelegate del1 = (string name) => { Console.WriteLine("hello wrod"+name); };
            del1("布衣流泪少年");

            MydelegateString delstr = delegate (string name) {  Console.WriteLine( name + "最帅");
                return "jj";
            };
            delstr("孤高自傲少年郎");
            Console.ReadKey();
        }
    }
}
