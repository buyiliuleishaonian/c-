using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Xing y = new Yuan(4);
            double s=y.S();
            double c = y.C();
            Xing j = new Ju(12,13);
            double s1 = j.S();
            double c1 = j.C();
            Console.Write(s);
        }
    }
}
