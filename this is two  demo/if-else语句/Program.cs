using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //大于等于90分，则奖励一百块钱
            //反之就去跪方便面
            //Console.WriteLine("请输入一个数值");
            //double numder = Convert.ToDouble(Console.ReadLine());//score，分数
            //if (numder >= 90)
            //{
            //    Console.WriteLine("奖励一百块钱");
            //}
            //else 
            //{
            //    Console.WriteLine("跪方便面");
            //}
            //Console.ReadKey();

            //对于学员成绩测评
            //成绩>=90:A   90>成绩>80；B 80>成绩>70；C
            //70~60:D  <60  :E
            #region if语句
            Console.WriteLine("请输入学员成绩");
            double socre = Convert.ToDouble(Console.ReadLine());
            if (socre >= 90)
            {
                Console.WriteLine("A");
            }
            if(socre>=80&&socre<90)
            { 
                Console.WriteLine("B");
            }
            if (socre >= 70 && socre < 80)
            {
                Console.WriteLine("C");
            }
            if (socre>=60&&socre<70)
            {
                Console.WriteLine("D");            
            }
            if (socre < 60)
            {
                Console.WriteLine("E");
            }
            Console.ReadKey();
            #endregion


            #region  if-else

            //if (socre >= 90)这里是在IF ELSE里面循环套用IF else
            //{
            //    Console.WriteLine("A");
            //}
            //else
            //{
            //    if (socre >=80&&socre<90)//可以不用写<90,后面一样
            //    {
            //        Console.WriteLine("B");
            //    }
            //    else
            //    {
            //        if (socre<80&&socre >= 70)
            //        {
            //            Console.WriteLine("C");
            //        }
            //        else
            //        {
            //            if (socre<70&& socre >=60)
            //            {
            //                Console.WriteLine("D");
            //            }
            //            else
            //            {
            //                Console.WriteLine("E");
            //            }
            //        }
            //    }
            //}
            //Console.ReadKey();
            #endregion

        }
    }
}
