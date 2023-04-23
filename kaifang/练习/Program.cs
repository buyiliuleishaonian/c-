using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace 练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入一个数，求出是第几周，多少天
            //int monder = int.Parse(Console.ReadLine());
            //int x = monder / 7;
            //int y = monder % 7;
            //Console.WriteLine("这是第{0}周，第{1}天", x, y);
            //Console.ReadKey();

            int monder = int.Parse(Console.ReadLine());
            int x = monder / 7;
            int y = monder % 7;
            Console.WriteLine("这是第{0}周，第{1}天",x,y);
            Console.ReadKey();

            //string monder_2 = Console.ReadLine();
            //string q = monder / 7;   无法将字符串转化为数值类型

            //实现107653秒是几天几小时几分钟几秒
            //60×24×60
            int monder_1 = int.Parse(Console.ReadLine());
            int day = monder_1 / (60 * 24 * 60);
            int yushu = monder_1 % (60 * 60 * 24);
            int hour = yushu / (60 * 60);
            int yushu1 = yushu % (60 * 60);
            int minute = yushu1 / (60);
            int seconds = yushu1 % 60;
            Console.WriteLine("这是第{0}天，第{1}小时，第{2}分钟，第{3}秒", day, hour, minute, seconds);
            Console.ReadKey();

            int monder_2 = int.Parse(Console.ReadLine());
            int day_1 = monder_2 / (60 * 60 * 24);
            int hour_1, minute_1, seconds_1;
            hour_1 = (monder_2 % (60 * 60 * 24)) / (60 * 60);
            minute_1 = ((monder_2 % (60 * 60 * 24) % (60 * 60)) / 60);
            seconds_1 = ((monder_2 % (60 * 60 * 24) % (60 * 60)) % 60);
            Console.WriteLine("这是第{0}天，第{1}小时，第{2}分钟，第{3}秒", day_1, hour_1, minute_1, seconds_1);
            Console.ReadKey();


            //输入三个数 输出最大值  也可以用convert toint（字符串），也可以通过convert 来将字符串类型改变为int double类型
            //Console.WriteLine("请输入三个数b");
            //int a = int.Parse(Console.ReadLine());//输入整数用int.Parse（Console.Readline（））；
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            ////string a = Console.ReadLine();字符串，无法比较大小
            ////string b = Console.ReadLine();
            ////string c = Console.ReadLine();
            //if (a > b && a > c)
            //{
            //    Console.WriteLine(a);
            //}
            //if (b > a && b > c)
            //{
            //    Console.WriteLine(b);
            //}
            //if (c > a && c > b)
            //{
            //    Console.WriteLine(c);
            //}


            //string name = "布衣流泪少年";
            //char gender = '男';
            //int age = 22;
            //string iphone = "18827455237";
            //string address = "高基庙村十五组";
            //string xingming = "布衣";
            //Console.WriteLine("我的名字叫{0}，我今年{1}岁，我是{2}，我的电话是{3}",name,age,gender,iphone);
            //Console.ReadKey();
            //Console.WriteLine("我的地址是{0}，今年{1}岁，我的姓名是{2}", address, age, xingming);


            //string name = "卡卡西";
            //int age = 18;
            //string email = "2424215016@qq.com";
            //string address = "湖北荆州石首高基庙";
            //decimal salary = 7500.00m;
            //Console.WriteLine("我叫{0}，我今年{1}，我的邮箱{2}，我的住址{3}，我一个月的工资是{4}", name, age, email, address, salary);


            //Console.ReadKey();
            //    int age = 18;
            //    age = 81;
            //    Console.WriteLine("原来你的都"+age+"岁");
            //    Console.ReadKey();
            //    decimal money_1 = 1m;
            //    double x = 11.11;
            //
        }
    }
}
