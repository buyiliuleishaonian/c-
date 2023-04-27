using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型委托
{
    internal class Program
    {
        public delegate int MyDelegate<T>(T t1, T t2);
        static void Main(string[] args)
        {
            //求解任何数组的最大值
            int[] nums = { 1, 2, 3, 45, 6, 7, 854 };
            int max = GetMax<int>(nums, delegate (int n1, int n2) { return n1 - n2; }); ;
            Console.WriteLine(max);
            string[] strs = { "dadadadada", "dadadadadadadadadadad", "dadfafa" };
            string s = GetMax<string>(strs, (string s1, string s2) =>
            {
                int n1 = s1.Length; int n2 = s2.Length;
               return
                n1 - n2;
            });
            Console.WriteLine(s);
            Console.ReadKey();
        }
        public static T GetMax<T>(T[] num, MyDelegate<T> del)
        {
            T max = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                if (del(num[i], max) > 0)
                {
                    max = num[i];
                }
            }
            return max;
        }

    }
}
