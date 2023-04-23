using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace 冒泡排序
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //让数组里面的数，从小到大的排序或者从大到小的排序
            //int[] nums = new int[11];
            //Random number = new Random();//创建生成随机数的对象
            ////不能创建在for循环里面，要不然只会生成一个特定的数值
            //for (int x=0;x<nums.Length;x++)
            //{
            //    //创建生成随机数的对象
            //    nums[x] = number.Next(-100,100);//生成随机数的对象调用.next的方法生成随机数，-100，100是范围，
            //    //方法：就是帮我做一件事情，当然需要使用的参数，和接收结果的数据
            //    //number_1是接收方法之后得到的结果

            //}
            //这个是升序
            //Array.Sort(nums);//array排序  sort数组
            //这个是反转
            //array.reverse（nums）；
            //如果要达到降序排列可以先升序，再反转
            //for (int x = 0; x < nums.Length - 1; x++)
            //{
            //    for (int y = 0; y < nums.Length; y++)
            //    {
            //        int number_2 = 0;
            //        number_2 = nums[x + 1];
            //        if (nums[y] > nums[y+ 1])
            //        {
            //            nums[y + 1] = nums[y];
            //            nums[y] = number_2;
            //        }
            //    }
            //}
            //for (int x=0;x<nums.Length;x++)
            //{
            //    Console.WriteLine(nums[x]);
            //}
            //Console.ReadKey();

            //冒泡排序
            Random number = new Random();
            int[] nums = new int[10];
            for (int x=0;x<nums.Length;x++)
            {
                nums[x] = number.Next(0,100);
            }
            //Array.Sort(nums);
            for (int x = 0; x < nums.Length - 1; x++)
            {
                for (int y = 0; y < nums.Length - 1; y++)
                {
                   
                    if (nums[y] > nums[y + 1])
                    {
                        int number_1=nums[y];
                        nums[y] = nums[y + 1];
                        nums[y+ 1] = number_1;
                    }
                }
            }
            for (int x=0;x<nums.Length;x++)
            {
                Console.WriteLine(nums[x]);
            }
            Console.ReadKey();
        }
    }
}
