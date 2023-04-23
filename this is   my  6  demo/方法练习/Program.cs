using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //读取输入的整数，定义成方法
            //多次调用（如果用户输入的是数字，则返回，否则提示用户重新输入，）
            //Console.WriteLine("请输入一个数字");
            //string number = Console.ReadLine();
            //int number_1=Num(number);
            //Console.WriteLine(number_1);
            //Console.ReadKey();



            //只允许输入y和n
            //Console.WriteLine("请输入一个用户名和密码");
            //string userName = Console.ReadLine();
            //bool a = User(userName);
            //Console.WriteLine("输入正确");
            //Console.ReadKey();





            //查找两个数之间的最大值
            //Console.WriteLine("请随便输入两个数字");
            //string number_1 = Console.ReadLine();
            //string number_2 = Console.ReadLine();
            //int max = Max(number_1,number_2);
            //Console.WriteLine(max);
            //Console.ReadKey();






            //计算输入数组的和 int[] sum（int[] values ）
            //    int[] nums = new int[10];
            //    int[] nums1 = new int[10];
            //    nums1=Sum( nums);
            //    for (int x=0;x<nums.Length;x++)
            //    {
            //        Console.WriteLine(nums1[x]);
            //    }
            //    int sum = Sums(nums1);
            //    Console.WriteLine("这个数组的总值是{0}",sum);
            //    Console.ReadKey();

            //判断一个数组里面的最大值，最小值，总值，平均值
            int[] nums = new int[12];
            int max, min, sum, agr;
            nums = Sum(nums);
            Sumder(nums,out max,out min,out sum);
            for (int x = 0; x < nums.Length; x++)
            {
                Console.WriteLine(nums[x]);
            }
            Console.WriteLine("随机生成的一个数组{0},最大值{1}，最小值{2}，平均值{3}，总值{4}",nums,max,min,sum/nums.Length,sum);
            Console.ReadKey();
        }
        /// <summary>
        /// 判断一个输入是否为数字，
        /// 是数字则输出，不是请重新输入
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Num(string x)
        {
            while (true)
            {
                try
                {
                    int y = Convert.ToInt32(x);
                    return y;//因为直接结束了这个方法，并且输出了y之值，所以不用break；跳出循环
                }
                catch
                {
                    Console.WriteLine("输入有误，重新输入");
                    x = Console.ReadLine();
                }
            }
        }

        /// <summary>
        /// 判断输入是否正确
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool User(string name)
        {
            while(true)
            {
                bool a = true;
                if (name == "y" || name == "x")
                {
                    return a;
                }
                else 
                {
                    Console.WriteLine("输入错误，请重新输入");
                    name = Console.ReadLine();
                }
            }
        }

        /// <summary>
        /// 判断输入的两个数字的最大值
        /// </summary>
        /// <param name="n1">输入值1</param>
        /// <param name="n2">输入值2</param>
        /// <returns>输出最大值</returns>
        public static int Max(string n1,string  n2)
        {
            while (true)
            {
                try
                {
                    int a1 = Convert.ToInt32(n1);
                    int a2 = Convert.ToInt32(n2);
                    return a1 > a2 ? a1 : a2;
                }
                catch
                {
                    Console.WriteLine("输入错误,请重新输入");
                    n1 = Console.ReadLine();
                    n2 = Console.ReadLine();
                }
            }
        }
        /// <summary>
        /// 用随机数填满一个数组
        /// </summary>
        /// <param name="valus"></param>
        /// <returns></returns>
        public static int[] Sum(int[] valus)
        {
            Random number = new Random();
            for (int x=0;x<valus.Length;x++)
            {
                valus[x] = number.Next(0,100);
            }
            return valus;
        }
        /// <summary>
        /// 计算一个数组里面的元素整合
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int Sums(int[] nums)
        {
            int y = 0;
            for (int x=0;x<nums.Length;x++)
            {
                y = y + nums[x];
            }
            return y;
        }

        /// <summary>
        ///判断一个数组里面的最大值，最小值，平均值，总和
        /// </summary>
        /// <param name="nums">数组</param>
        /// <param name="max">最大值</param>
        /// <param name="min">最小值</param>
        /// <param name="sum">总和</param>
        /// <param name="agr">平均值</param>
        public static void Sumder(int[] nums,out int max ,out int min ,out int sum)
        {
            max = nums[2];
            min = nums[1];
            sum = nums[3];
            for (int x=0;x<nums.Length;x++)
            {
                if (nums[x]>max)
                {
                    max = nums[x];
                }
                if (nums[x]<min)
                {
                    min = nums[x];
                }
                sum = sum + nums[x];
            }
        }
    }
}
