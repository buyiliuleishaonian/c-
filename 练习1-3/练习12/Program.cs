using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //用方法来实现，判断一个字符串数组，中的那个元素最长
            //string[] str = { "布衣流泪少年","孤高自傲少年郎","文憔悴","少年阿文"};
            //int number= Test(str);
            //Console.WriteLine(str[number]);
            //Console.ReadLine();

            //用方法将一个整型数组的最小值求出来，然后将其平均值求解出来，判断是否有小数，有小数保留两位
            //int[] nusm = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 ,5};
            //double sum = Test1(nusm);
            //Console.WriteLine("{0:0.00}", sum / nusm.Length);
            //Console.ReadKey();

            //通过冒泡排序对整个升序做出一个升序排序
            //int[] nums = { 1, 4, 67, 9, 90, 89, 6899, 543, 97800, 1234214 };
            //nums=Test2(nums);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write(nums[i]+"  ");
            //}
            //Console.ReadKey();

            //给一个数组的每一个元素赋值
            //int[] nums = new int[30];
            //int sum = Test3(nums);
            //Console.WriteLine(sum);
            //Console.ReadKey();

            //判断一个字符串数组，出现次一个词组
            //string str = "\"患者:“大夫，我咳嗽得很重。\r\n" +
            //    "大夫:“你多大年记?”" +
            //    "患者:“七十五岁。” 大夫:“二十岁咳嗽吗”患者:“不咳嗽。”大夫:“四十岁时咳嗽吗?” " +
            //    "患者:“也不咳嗽。”大夫:“那现在不咳嗽，还要等到什么时咳嗽?\"\"。";
            //int num =0;
            //Test(str, ref num);
            //Console.ReadKey();

            //
        }
        /// <summary>
        /// 判断一个字符串数组，最长的元素
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static int Test(string[] name)
        {
            int str = 0;
            for (int i = 0; i < name.Length; i++)
            {
                int number = name[0].Length;
                if (name[i].Length > number)
                {
                    number = name[i].Length;
                    str = i;
                }
            }
            return str;
        }
        /// <summary>
        /// 求出一个数组的总数。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static double Test1(int[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += i;
            }
            return sum;
        }
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="nums"></param>
        public static int[] Test2(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int x = 0; x < nums.Length - 1 - i; x++)
                {
                    if (nums[i] > nums[i + x])
                    {
                        int y = nums[i + x];
                        nums[i + x] = nums[i];
                        nums[i] = y;
                    }
                }
            }
            return nums;
        }
        public static int Test3(int[] nums)
        {
            Random r = new Random();
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = r.Next(0, 101);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum / nums.Length;
        }
        /// <summary>
        /// 判断字符串数组，里面咳嗽出现的次数。
        /// </summary>
        /// <param name="str"></param>
        /// <param name="num"></param>
        public static void Test(string str,ref int num)
        {
            int nums=str.IndexOf("咳嗽");
            num = 1;
            Console.WriteLine( "第一次出现咳嗽的地方{0}" ,nums);
            while (nums!=-1)
            {
                num++;
                nums=str.IndexOf("咳嗽",nums+1);
                if (nums==-1)
                {
                    break;
                }
                Console.WriteLine("第{0}出现在咳嗽，地址是{1}",num,nums);
            }
        }
    }
}
