using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接收用户数据
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请用户输入姓名");
            ////我们还想要接收用户姓名
            ////接收用户在控制台的输入
            //string name = Console.ReadLine();
            //Console.WriteLine("您的姓名是{0}", name);
            //Console.ReadKey();

            //Console.WriteLine("请问你喜欢吃什么水果");
            //string str_1 = Console.ReadLine();//fruit：水果
            //Console.WriteLine("刚刚好，我也喜欢吃{0}",str_1);
            //Console.ReadKey();


            //Console.WriteLine("您好，请你输入姓名，年龄和性别");
            //string name = Console.ReadLine();
            //string age = Console.ReadLine();
            //string gender = Console.ReadLine();
            //Console.WriteLine("您好，{0}您的年龄是{1}岁是个{2}",name,age,gender);
            //Console.ReadKey();


            Console.WriteLine("您好，请输入姓名");
            string name = Console.ReadLine();
            Console.WriteLine("您好，请输入年龄");
            string age = Console.ReadLine();
            Console.WriteLine("您好，请输入性别");
            string gender = Console.ReadLine();
            Console.WriteLine("您好，{0}您的年龄是{1}岁是个{2}生",name,age,gender);
            Console.ReadKey();
        }
    }
}
