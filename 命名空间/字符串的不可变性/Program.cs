using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串的不可变性
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "11";

            string s2 = "11";
            Console.ReadKey();
            string s3 = "13dasfdasfsadf";
            char[] s4 = s3.ToCharArray();
            s4[2] = 's';
            s3 = new string(s4);
            Console.WriteLine(s3);
            Console.ReadKey();
        }
    }
}
