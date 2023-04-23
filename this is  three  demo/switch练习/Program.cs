using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //让用户输入姓名，显示用户上辈子是什么职业
            #region   我自己的名字
            //Console.WriteLine("请输入姓名");
            //string name = Console.ReadLine();
            //bool x = true;
            //switch(name)
            //{
            //    case "文憔悴":
            //        Console.WriteLine("天下第一屌丝");
            //        break;
            //    case "孤高自傲少年":
            //        Console.WriteLine("天下第一布衣");
            //        break;
            //    case "布衣流泪少年":
            //        Console.WriteLine("邪恶");
            //        break;
            //    case "神人天下":
            //        Console.WriteLine("天下第一神棍");
            //        break;
            //    default:
            //        Console.WriteLine("程序错误，退出程序");
            //        x = false;
            //        break;
            //}
            //if (x)
            //{
            //    Console.WriteLine("你的上辈子是{0}",name);
            //}
            #endregion
            #region  
            //Console.WriteLine("请输入姓名，确认上一世的身份");
            //string name = Console.ReadLine();
            //bool judeg = true;
            //switch (name)
            //{
            //    case "老蒋":
            //        Console.WriteLine("天下第一屌丝");
            //        break;
            //    case "老孙":
            //        Console.WriteLine("天下第一土豪");
            //        break;
            //    case "老宋":
            //        Console.WriteLine("天下第一帅哥");
            //        break;
            //    case "老彭":
            //        Console.WriteLine("天下第一情种");
            //        break;
            //    default:
            //        Console.WriteLine("程序错误，退出程序");
            //        break;
            //}
            //Console.ReadKey();
            #endregion
            #region
            //将范围变成定值
            //Console.WriteLine("请输入一个数值");
            //int number = Convert.ToInt32(Console.ReadLine());//
            //bool x = true;
            //switch(number/10)//还可以是表达式的值
            //{
            //    case 10:
            //        Console.WriteLine("A");
            //        break;
            //    case 9:
            //        Console.WriteLine("A");
            //        break;
            //    case 8:
            //        Console.WriteLine("B");
            //        break;
            //    case 7:
            //        Console.WriteLine("C");
            //        break;
            //    case 6:
            //        Console.WriteLine("D");
            //        break;
            //    default:
            //        Console.WriteLine("成绩不合格");
            //        break;
            //}
            #endregion
            //输入年，输入月，输出该月天数，（结合之前的判断年份）
            #region  自己写的
            //Console.WriteLine("请输入年份");
            //int year = 0, month = 0;//声明变量，因为不给变量的初始值，后面先给变量赋值的话，再用到变量，语法报错
            //bool n = true, m = true;//设置两个变量，第一个变量当年份输入错误，就不再往下运行，第二个变量用法相同
            ////防止输入的是字母，
            //try
            //{
            //    year = Convert.ToInt32(Console.ReadLine());
            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字，不要输入字母");
            //    n = false;
            //}
            ////当输入年份有输入字母后，就不再往下进行
            //if (n)
            //{
            //    Console.WriteLine("请输入月份");
            //    try
            //    {
            //        month = Convert.ToInt32(Console.ReadLine());
            //    }
            //    catch
            //    {
            //        Console.WriteLine("请输入数字，不要输入字母");
            //        m = false;
            //    }
            //}
            ////闰年是 可以400整除或者4整除，不被100整除
            //if (m && n)
            //{
            //    int x = year % 400;//声明变量，就要给定初始值，要不然，在还没有运行输入变量代码时，在之后的代码使用变量会报错
            //    int y = year % 4;
            //    int a = year % 100;

            //    if (month == 2 && (x == 0 || (y == 0 && a != 0)))//因为是两种判断任何一种都可以
            //    {
            //        Console.WriteLine(29);
            //    }
            //    else if (month == 2)
            //    {
            //        Console.WriteLine(28);
            //    }
            //    else 
            //    {
            //        switch (month)//这里没有考虑闰年的情况
            //        {
            //            case 1:
            //                Console.WriteLine(31);
            //                break;
            //            //case 2:
            //            //    Console.WriteLine(28);
            //            //    break;
            //            case 3:
            //                Console.WriteLine(31);
            //                break;
            //            case 4:
            //                Console.WriteLine(30);
            //                break;
            //            case 5:
            //                Console.WriteLine(31);
            //                break;
            //            case 6:
            //                Console.WriteLine(30);
            //                break;
            //            case 7:
            //                Console.WriteLine(31);
            //                break;
            //            case 8:
            //                Console.WriteLine(31);
            //                break;
            //            case 9:
            //                Console.WriteLine(30);
            //                break;
            //            case 10:
            //                Console.WriteLine(31);
            //                break;
            //            case 11:
            //                Console.WriteLine(30);
            //                break;
            //            case 12:
            //                Console.WriteLine(31);
            //                break;
            //            default:
            //                Console.WriteLine("程序错误，退出程序");
            //                break;
            //        }
            //    }
            //}
            #endregion
            #region  老师的方法，先把完整的程序写完，在对可能出现异常的代码，异常捕获
            Console.WriteLine("请输入年份");
            try
            {
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入月份");
                try
                {
                    int month = Convert.ToInt32(Console.ReadLine());
                    int day;
                    if (month <= 12 && month >= 1)
                    {
                        switch (month)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                day = 31;
                                break;
                            case 2:
                                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                                {
                                    day = 29;
                                }
                                else
                                {
                                    day = 28;
                                }
                                break;
                            default:
                                day = 30;
                                break;
                        }

                        Console.WriteLine("{0}年{1}月{2}天", year, month, day);
                    }
                    else
                    {
                        Console.WriteLine("月份范围不对，程序退出");
                    }
                }//月份
                catch
                {
                    Console.WriteLine("月份输入错误，程序退出");
                }
            }//年份
            catch//年份报错
            {
                Console.WriteLine("年份输入错误，程序退出");
            }
            Console.ReadKey();
            #endregion
        }
    }
}
