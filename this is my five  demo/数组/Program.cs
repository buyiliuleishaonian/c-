using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //数组是生成同一个类型多个变量。
            int[] nums = new int[10];//当没有给数组中的元素赋值之前，每个元素的值都是0
            int[] numsTwo = { 1, 2, 3, 4, 5, 6 };
            //一般都不记忆这两种
            //int[] numsThree = new int[3] { 1, 2, 3 };
            //int[] numsFour = new int[] { 1, 23, 3 };
            string[] str = new string[10];//当没有给数组中的元素赋值之前，每个元素的值都是null，null不空，null "" 
            //null 在内存中没有开空间， ""是开了空间，只不过存的是空
            bool[] bools = new bool[10];//bool类型的数组，没有赋值之前的初始值为false；
            for (int x = 0; x < nums.Length; x++)
            {
                nums[x] = x;
                Console.WriteLine(nums[x]);
            }
            for (int y=0;y<str.Length;y++)
            {
                Console.WriteLine("请输入密保");
                str[y] = Console.ReadLine();
                Console.WriteLine(str[y]);
            }
        }
    }
}
