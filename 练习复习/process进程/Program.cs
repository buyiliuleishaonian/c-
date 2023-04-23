using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace process进程
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //开启一些引用程序
            Process.Start("iexplore","http://www.douyin.com");
            //通过进程打开我们的文件
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\Public\Desktop\QQ音乐.lnk");
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
            Console.ReadKey();

            //thread
            
        }
    }
}
