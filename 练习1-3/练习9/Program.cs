using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //用方法来计算多个数的最大值
            int n1 = 10, n2 = 20, n3 = 20;
           int max= Test(n1,n2,n3);
            Console.WriteLine(max);
            Console.ReadKey(true);
        }
        public static int  Test(params int[] nums)
        {
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                max = max + nums[i];
            }
            return max;
        }
    }
}
