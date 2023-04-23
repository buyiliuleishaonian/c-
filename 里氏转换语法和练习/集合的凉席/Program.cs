using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集合的凉席
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //创建一个集合，添加一些数字，然后就平均值求和
            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //int number,number1=0;
            //for (int x=0;x<list.Count;x++)
            //{
            //    if (list[x] is int)
            //    {
            //        number = (int)list[x];
            //        number1 += number;
            //    }
            //}
            //Console.WriteLine("这个集合的平均数是{0}，总和是{1}",number1/3,number1);
            //Console.ReadKey(true);

            //写一个长度为10的集合，要求在里面随机生成（0~9）的数
            //不可以重复出现
            ArrayList list = new ArrayList();
            Random number = new Random();
            //循环体：每次都对集合赋值，并且判断赋的值是否相同
            //循环条件：集合的长度小于10
            while (list.Count < 10)
            {
                int number1 = number.Next(0,10);
                if (!list.Contains(number1))//直接调用包含方法，就可以判断是否有重复的值。
                {
                    list.Add(number1);                   
                }
                else
                {
                    continue;
                }
            }
            for (int y = 0; y < list.Count; y++)
            {
                Console.WriteLine(list[y]);
            }
            Console.ReadKey(true);
        }
    }
}
