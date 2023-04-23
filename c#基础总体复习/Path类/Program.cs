using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //获得文件名
            string textPath = Path.GetFileName(@"D:\桌面\c#基础复习.txt");
            //或者不加扩展的文件名
            string textPath1= Path.GetFileNameWithoutExtension(@"D:\桌面\c#基础复习.txt");
            //获得文件的扩展名
           string textpath2= Path.GetExtension(@"D:\桌面\c#基础复习.txt");
            //获得文件的文件夹名
            string path=Path.GetDirectoryName(@"D:\桌面\c#基础复习.txt");
            //绝对路劲
            string  path1=Path.GetFullPath(@"D:\桌面\c#基础复习.txt");
            Console.WriteLine(path1);
            Console.ReadKey();
        }
    }
}
