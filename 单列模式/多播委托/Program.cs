using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多播委托
{
    public delegate void Mydel();
    internal class Program
    {
        static void Main(string[] args)
        {
            Mydel del = new Mydel(T1);
            del += T2;
            del -= T1;
            del();
            Console.ReadKey();
        }
        public static void T1()
        {
            Console.WriteLine("T1");
        }
        public static void T2()
        {
            Console.WriteLine("T2");
        }
        public static void T3()
        {
            Console.WriteLine("T3");
        }
    }
}
