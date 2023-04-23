using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类的练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //非静态
            Student jiang = new Student("蒋国文",18,'男',100,100,100);
            Student wen = new Student("文憔悴",22,100);
            //jiang.Naem = "蒋国文";
            //jiang.Age = 22;
            //jiang.Gender = '男';
            //jiang.Chinese = 100;
            //jiang.Chinese = 100;
            //jiang.Chinese = 100;
            jiang.Test();
            //jiang.Sum = jiang.Chinese + jiang.English + jiang.Math;
            //jiang.Test1();
            Console.ReadKey(true);

            //静态，将这些写为静态类
            Test2.Naem = "蒋国文";
            Test2.Age = 22;
            Test2.Gender = '男';
            Test2.Test();
            Console.ReadKey();
            Test2.Naem = "文憔悴";
            Test2.Age = 22;
            Test2.Gender = '男';
            Test2.Test();
            Console.ReadKey();
        }
    }
}
