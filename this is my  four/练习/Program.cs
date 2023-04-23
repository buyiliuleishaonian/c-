using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //连续输出100次下一次一定细心
            int socre = 0;
            while (socre != 100)
            {
                Console.WriteLine("下一次一定细心 {0}",socre);
                socre++;
            }
            Console.ReadKey();



        }
    }
}
