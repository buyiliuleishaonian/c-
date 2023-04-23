using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace path类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name= @"F:\edge下载地\外网加速器\chatgpt.aw";
            //获得文件名
            Console.WriteLine(Path.GetFileName(name));
            //获得文件名但是不包含扩展
            Console.WriteLine(Path.GetFileNameWithoutExtension(name)) ;
            //获得扩展名
            Console.WriteLine(Path.GetExtension(name));
            //获得文件的文件夹的名称
            Console.WriteLine(Path.GetDirectoryName(name));
            //返回文件的全路径
            Console.WriteLine(Path.GetFullPath(name));
            //连接两个字符串作为路径
            Console.WriteLine(Path.Combine(@"c:\s\","e.ww"));
            Console.ReadKey(true);
        }
    }
}
