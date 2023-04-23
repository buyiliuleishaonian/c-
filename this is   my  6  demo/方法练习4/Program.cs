using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //计算多个数间的最大值
            //int max=Max(11, 233, 34455, 6566, 12);
            //Console.WriteLine(max);
            //Console.ReadKey();


            //通过冒泡排序对一个数组进行升序排序
            //int[] nums = { 1, 2, 76, 764, 89659, 56467, 23423, 423432, 3242342 };
            //Test(nums);
            //Console.ReadKey();

            //将一个字符串数组输出为分割|模式
            string[] name = { "蒋","孙","彭","宋"};
            Test1(name);
            Console.ReadKey();
        }
        /// <summary>
        /// 判断几个数字之间的最大值
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int Max(params int[] nums)
        {
            int max  = 0;
            for (int y = 0; y < nums.Length; y++)
            {
                if (nums[y] > max)
                {
                    max = nums[y];
                }
            }
            return max;
        }
        /// <summary>
        /// 将一个数组，通过冒泡排序，做一个升序模式
        /// </summary>
        /// <param name="nums">输入数组</param>
        public static void Test(int[] nums)
        {
            for (int x=0;x<nums.Length;x++)
            {
                for (int y = 0; y < nums.Length - 1 - x; y++)
                {
                    if (nums[y] > nums[y + 1])
                    {
                        int z = nums[y];
                        nums[y] = nums[y + 1];
                        nums[y + 1] = z;
                    }
                }
            }
            for (int x=0; x<nums.Length;x++)
            {
                Console.WriteLine(nums[x]);
            }
        }
        public static void Test1(string[] name)
        {
            for (int x=0;x<name.Length;x++)
            {
                Console.Write(name[x] +"|");
            }
        }
    }
}
