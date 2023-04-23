using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 随机生成一个随机数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //创建一个生成随机数的对象
            //Random number = new Random();
            ////用生成随机数的对象调用一个方法来生成一个随机数
            //int number_1=number.Next(0,10);//.next就是方法，方法是需要参数的，这里的参数就是给定范围，调用方法之后需要一个数据类型
            ////接收结果，而且接收结果类型要和方法中的参数类型一致。
            ////而且给定的范围，是左闭右开区间 ，左边的可以出现，右边的不可以出现。
            //Console.WriteLine("随机生成的一个数{0}",number_1);
            //Console.ReadKey();


            //输入一个名字随机生成上辈子是什么样的人
            //思路
            //1、需要创建生成随机数的对象
            //2、需要使生成随机数的对象调用方法生成一个随机数
            //3、使用switch case每个数字对应一个形容词
            int number_1 = 0;
            Random number = new Random();//创建一个生成随机数的对象
            Console.WriteLine("请输入一个人的姓名");
            while (true)
            {
                string name = Console.ReadLine();
                number_1 = number.Next(1, 11);//生成随机数的对象调用方法生成一个随机数
                switch (number_1)
                {
                    case 1:
                        Console.WriteLine("天下第一屌丝");
                        break;
                    case 2:
                        Console.WriteLine("天下第一神才");
                        break;
                    case 3:
                        Console.WriteLine("天下第一舔狗");
                        break;
                    case 4:
                        Console.WriteLine("天下第一神经病");
                        break;
                    default:
                        Console.WriteLine("天下第一布衣");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
