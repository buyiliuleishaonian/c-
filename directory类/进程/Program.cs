using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 进程
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //获得当前程序中所有正在运行的程序
            //Process[] number= Process.GetProcesses();
            // foreach (var item in number)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.ReadKey();

            //通过进程打开一些应用
            Process.Start("calc");
            Process.Start("iexplore", "http://www.baidu.com");
            Process.Start("iexplore", "http://www.douyin.com");
            Console.ReadKey();


            //通过一个进程打开指定的文件
            //第一：创建进程对象
            //第二：创建一个人processstartinfo的对象
            //第三：之后将processStartinfo的对象，传给process对象，调用startinfo的属性；
            //ProcessStartInfo psi = new ProcessStartInfo(@"F:\yy\YY.exe");
            //Process pro = new Process();
            //pro.StartInfo = psi;
            //pro.Start();
            //Console.ReadKey();
        }
    }
}
