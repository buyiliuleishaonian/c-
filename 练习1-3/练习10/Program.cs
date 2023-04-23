using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //用方法将0~100的数全部相加
            int number=Test();
            Console.WriteLine(number);
            int num = Test1();
            Console.WriteLine(num);
            Console.ReadKey();
        }
        public static int Test()
        {
            int nums = 0;
            for (int i = 0; i <=100; i++)
            {
                nums = nums + i;
            }
            return nums;
        }
        public static int Test1()
        {
            int nums = 0;
            for (int i = 0; i <=100; i++)
            {
                if (i % 2 == 0)
                {
                    nums = nums+i;
                }
                else
                {
                    
                    continue;
                }
            }
            return nums;
        }
    }
}
