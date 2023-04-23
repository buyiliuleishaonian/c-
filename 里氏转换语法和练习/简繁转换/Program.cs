using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简繁转换
{
    internal class Program
    {
        public const string n = "布衣流泪少年郎";
        public const string g = "孤高自傲少年郎";
        static void Main(string[] args)
        {
            Hashtable hs = new Hashtable();
            for (int x=0;x<n.Length;x++)//将简体和繁体的，做成键和值一一对应
            {
                hs.Add(n[x], g[x]);
            }
            Console.WriteLine("请随便输入几个数");
            string name = Console.ReadLine();
            for (int x=0;x<name.Length;x++)
            {
                if (hs.ContainsKey(name[x]))
                {
                    Console.Write(hs[name[x]]);
                }
                else
                {
                    Console.Write(name[x]);
                }
            }
            Console.ReadKey(true);
        }
    }
}
