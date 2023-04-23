using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //对于文件的创建，删除，剪切，移除
            //创建
            //File.Create(@"D:\桌面\1.txt");
            //Console.WriteLine("ok");
            //删除
            //File.Delete(@"D:\桌面\1.txt");
            //Console.WriteLine("ok");
            //复制
            // File.Copy(@"D:\桌面\c#基础复习.txt",@"D:\桌面\1.txt");
            //剪切
            //File.Move(@"D:\桌面\1.txt",@"D:\桌面\2.txt");
            //Console.WriteLine("ok");
            #endregion
            #region 读取文件的三种方式、
            //byte[] buffer= File.ReadAllBytes(@"D:\桌面\2.txt");
            //string s = Encoding.UTF8.GetString(buffer,0,buffer.Length);
            //Console.WriteLine(s);

            //string[] s=File.ReadAllLines(@"D:\桌面\2.txt");
            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.WriteLine(s[i]);
            //}


            //string s = File.ReadAllText(@"D:\桌面\2.txt");
            //Console.WriteLine(s);
            #endregion
            //string s = "文憔悴最帅";
            //byte[] buffer = Encoding.UTF8.GetBytes(s);
            //File.WriteAllBytes(@"D:\桌面\2.txt",buffer);

            File.WriteAllLines(@"D:\桌面\2.txt",new string[] { "布衣流泪少年最帅"});

            File.WriteAllText(@"D:\桌面\2.txt","孤高自傲少年郎");

            File.AppendAllLines(@"D:\桌面\2.txt",new string[] {"无敌最俊朗文憔悴"});
            Console.ReadKey();
        }
    }
}
