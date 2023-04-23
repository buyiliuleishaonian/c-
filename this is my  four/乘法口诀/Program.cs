using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 乘法口诀//for嵌套循环
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //乘法口诀
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j <=i; j++)
            //    {
            //        Console.Write("{0}*{1}={2}\t",i,j,i*j);//可以降writeline();改为wrlite（）；
            //        //可以从输出一行转下一行，改变为一直接着输出，直到把行输入不下啦，就转行  
            //    }
            //    Console.WriteLine();//输出之后换行
            //}
            //Console.ReadKey();


            //让用户输入一个数显示下面的内容
            //输入一个值
            //根据这个值可以输出以下加发表
            Console.WriteLine("请输入一个数字");
            int number = 0,y;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                y = number;
                for (int x = 0; x <= y; x++)
                {
                    Console.WriteLine("{0}+{1}={2}", x, number, x + number);
                    number--;
                }
            }
            catch
            {
                Console.WriteLine("输入错误，程序终止");
            }
            Console.ReadKey();
        }
    }
}
