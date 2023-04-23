using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filestream读取文件
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //创建filestream对象，之后设置读写的地址，如果存在，就读写，如不存在直接，创建一个写入。
            FileStream file1 = new FileStream(@"D:\桌面\O0521.txt",FileMode.OpenOrCreate,FileAccess.Read);
            //需要设定每次读取的内存大小，
            byte[] buffer = new byte[1024 * 1024 * 5];
            //将读取的内容存放，并且明确从哪里开始读。
            //其放回值，显示实际读取了多少内存
            int number=file1.Read(buffer,0,buffer.Length);
            //将实际读取的内存，编码出来
            string str = Encoding.Default.GetString(buffer,0,number);
            file1.Close();//关闭文件流
            file1.Dispose();
            Console.WriteLine(str);
            Console.WriteLine("ok");
            Console.ReadKey();


            //写入对象
            using (FileStream file2 = new FileStream(@"D:\桌面\O0521.txt",FileMode.OpenOrCreate,FileAccess.Write))
            {
                string str1 = "天天好风景，今天好风光。";
                byte[] buffer1 = Encoding.Default.GetBytes(str1);
                file2.Write(buffer1, 0, buffer1.Length);
            }
            Console.WriteLine("ok");
            Console.ReadKey();
        }
    }
}
