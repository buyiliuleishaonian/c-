using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace 练习3
{
    internal class Program
    {
        public  static int[] nums = new int[50];
        static void Main(string[] args)
        {
            //定义一个数组长50的数组，随机給数组赋值，用户输入一个数组n
            //按一行n个数，输出数组
            Random r = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = r.Next(0,10);
                Console.Write(nums[i]+"  ");
            }
            Console.WriteLine();
            Console.WriteLine("请输入一个数");
            string number = Console.ReadLine();
            Test(number);
            Console.ReadKey(true);
        }
        public static void Test(string number1)
        {
            int sum = 0,sum1=1;
            int number = Convert.ToInt32(number1);
            for (int i = 0; i < nums.Length; i=number*sum)
            {
                for (int x = number*sum; x < number*sum1; x++)
                {
                    if (x < nums.Length)
                    {
                        Console.Write(nums[x] + "\t");
                    }
                    else
                    {
                        return;
                    }
                }
                Console.WriteLine();
                sum++;
                sum1++;
            }
        }
    }
}
