using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuilder和stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringn = new StringBuilder();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int x=0;x<100000;x++)
            {
                stringn.Append(x);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey(true);
        }
    }
}
