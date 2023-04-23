using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 拆箱和装箱
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();
            List<int> list1 = new List<int>();
            Stopwatch sw = new Stopwatch();
            sw.Start();//开始计时
            //00:00:20.8887604
            //00:00:01.1189925
            for (int i = 0; i < 100000000; i++)
            {
                list1.Add(i);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey(true);
        }
    }
}
