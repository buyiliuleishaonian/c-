using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace driectory类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory(@"D:\桌面\新文件夹");
            //Directory.Delete(@"D:\桌面\新文件夹");
            Directory.Move(@"D:\桌面\新文件夹",@"D:\桌面\1");
            Console.WriteLine("ok");
            Console.ReadKey();
        }
    }
}
