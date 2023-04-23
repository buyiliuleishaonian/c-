using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 用out编写一个人类似.tryparse的方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool x = int.TryParse("xadd",out number);
            Console.WriteLine(number);
            Console.ReadKey();
        }
        public static bool MyTryParse(string x,out int number)
        {
            number = 0;
            try
            {
                number = Convert.ToInt32(x);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
