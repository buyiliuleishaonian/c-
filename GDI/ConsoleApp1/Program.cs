using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcessStartInfo psi = new ProcessStartInfo(@"F:\yy\YY.exe");
            Process pro = new Process();
            pro.StartInfo = psi;
            pro.Start();
            Console.ReadKey();

        }
    }
}
