using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace 五个数组练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //从一个整数数组里面，将最大整数，输出出来
            //首先声明一个数组，之后依次输入十个整数，最后输出最大整数
            //如果我们随机生成一个数字呢

            //int max = 0,min=0,sum=0;//这里设置了 最大值，最小值，要是刚刚好数组中的元素都比0大，或者都比0小怎么办
            //所以，可以将这些变量建立在数组下方，因为当没有给数组中的元素赋值之前，其int类型的数组元素为0，
            //string类型的数组的元素为null，bool类型数组元素为false，
            //int[] nums = new int[10];
            //int max = nums[1], min = nums[1], sum = nums[2];
            //这里也可以把int类型的最大值或者最小值，赋值给用来判断最大值，或者最小值的变量
            //将int类型最小值，用于判断最大值的变量，int类型的最大值，用于判断最端最小值
            //bool z = true;
            #region  给数组的每一个元素输入数字，最后输出最大值
            //for (int x = 0; x < nums.Length; x++)
            //{
            //    try
            //    {
            //        Console.WriteLine("请输入第{0}个整数数值", x);
            //        nums[x] = Convert.ToInt32(Console.ReadLine());
            //        if (nums[x] > max)
            //        {
            //            max = nums[x];
            //        }
            //        else if (nums[x]<min)
            //        {
            //            min = nums[x];
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入错误，程序结束");
            //        z = false;
            //        break;
            //    }
            //}
            //if (z)
            //{
            //    Console.WriteLine("这个数组里面的最大值是{0},最小值是{1}", max,min);
            //}
            //Console.ReadKey();
            #endregion
            #region  这是随机生成数组里面的每一个元素，最后输出最大值
            //Random number = new Random();//创建生成的随机数的对象
            //for (int x = 0; x < nums.Length; x++)
            //{
            //    nums[x] = number.Next(-100, 100);
            //    if (nums[x] > max)
            //    {
            //        max = nums[x];
            //        //在循环当中nums[i]
            //        //1、表示当前循环的数组元素
            //        //2、表示数组里面的所有元素
            //    }
            //    else if (nums[x]<max)
            //    {
            //        min = nums[x];
            //    }
            //    Console.WriteLine("这个数组的第{0}个值是{1}", x, nums[x]);
            //    sum += nums[x];

            //}
            //Console.WriteLine("这个数组中的最大值是{0},最小值是{1}，总和是{2}，平均数是{3}", max,min,sum,sum/nums.Length);
            //Console.ReadKey();
            #endregion

            //数组里面都是人的名字，将名字分割成 老蒋|老孙|老王
            //（老蒋，老王，老彭，老孙，老宋，老陈，老朱，老杨，老邱）
            string[] peopleName = { "老蒋","老王","老彭"};

            #region  练习
            //一个数组里面，如果是正数就加1，如果是负数就减1，
            //如果是0，则不动
            //int[] nums = new int[10];
            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Random number = new Random();
            //    nums[i] = number.Next(-100, 100);
            //    if (nums[i] > 0)
            //    {
            //        Console.WriteLine("随机生成的数字{0}", nums[i]);
            //        nums[i]++;
            //        Console.WriteLine("加1之后的数字{0}", nums[i]);
            //    }
            //    else if (nums[i] < 0)
            //    {
            //        Console.WriteLine("随机生成的负数{0}", nums[i]);
            //        nums[i]--;
            //        Console.WriteLine("减一之后的数字{0}", nums[i]);
            //    }
            //    else
            //    {

            //    }

            //    sum += nums[i];
            //}
            //Console.WriteLine("最后的数组和{0}",sum);
            //Console.ReadKey();
            #endregion    

            //将数组中的元素数据前后互换
            string[] nums = { "我", "是", "文憔悴" };
            for (int x=0;x<nums.Length/2;x++)
            {
                string name = nums[x];
                nums[x] = (nums[nums.Length - 1 - x]);//首先要声明一个变量，存储一个元素，通过赋值，来达到交换，
                 (nums[nums.Length-1-x])=name;
            }
            for (int x=0;x<nums.Length;x++)
            {
                Console.WriteLine(nums[x]);
            }
            Console.ReadKey();
        }
    }
}
