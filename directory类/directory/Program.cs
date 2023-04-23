using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace directory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //path:针对路径，file：针对 文本文件，filestream，streamreader，streamwriter
            //Directory:是静态类
            //创建文件夹
            Directory.CreateDirectory(@"D:\桌面\a");
            Console.WriteLine("ok");
            Console.ReadKey();
            //删除文件夹
            //Directory.Delete(@"D:\桌面\a");
            //Console.Write("ok");
            //Console.ReadKey();
            //剪切文件夹
            Directory.Move(@"D:\桌面\a", @"D:\new");
            Console.WriteLine("ok");
            Console.ReadKey();
            //获得指定路径下的所有文件全路径
            string[] number=Directory.GetFiles(@"D:\桌面\蒋国文");
           foreach (string numberItem in number) 
            {
                Console.WriteLine(numberItem);
            }
            Console.ReadKey();
            //获得指定路径下的所有文件夹
           string[] nums= Directory.GetDirectories(@"D:\桌面\蒋国文");
            foreach (string numsItem in nums)
            {
                Console.WriteLine(numsItem);
            }
            Console.ReadKey();
        }
    }
}
