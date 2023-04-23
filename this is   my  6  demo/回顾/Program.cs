using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace 回顾
{
    public enum Name
    {
        男,
        女
    }
    public struct Gender
    {
        public int _age;
        public string _gonson;
        Name _name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("我是布衣流泪少年");
                break;
            }
            do
            {
                Console.WriteLine("我想快点学完和学好c#");
                break;
            }
            while (true);
            for (int y=0; y < 10; y++)
            {
                Console.Write(y);
            }
            if (true)
            {
                Console.WriteLine("加油学好c#");
            }
            if (true)
            {

            }
            else
            {
                
            }
            if (true)
            {

            }
            else if (true)
            {
                
            }
            int x = 10;
            switch (x)
            {
                case 10:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine();
                    break;
            }

        }
        public static void Max(out int x, ref int y)
        {
            x = 10;
        }
        public static int Min(int x)
        {
            x = 10;
            return x;
        }
    }
}
