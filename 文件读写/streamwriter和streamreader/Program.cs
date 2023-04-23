using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streamwriter和streamreader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s=" ";
            ////读取一个文本文件
            //using (StreamReader read=new StreamReader(@"D:\桌面\O0521.txt"))
            //{
            //    //判断是否读取到最后一行
            //    while (!read.EndOfStream)
            //    {
            //        s = read.ReadLine();
            //        Console.WriteLine(s);
            //    }
            //    Console.ReadKey();
            //}
            //写入一个文本文件,加上true,不清楚原本文本的数据，不加写入时，清除原本文件的数据
            using (StreamWriter read1=new StreamWriter(@"D:\桌面\O0521.txt",true))
            {
                read1.Write("天天好风景，今天好风光2222222");
            }
            Console.ReadKey();
        }
    }
}
