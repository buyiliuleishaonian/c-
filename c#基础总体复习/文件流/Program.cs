using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 文件流
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //using (FileStream filename=new FileStream(@"D:\桌面\c#基础复习.txt",FileMode.OpenOrCreate,FileAccess.Read))
            //{
            //    byte[] buffer = new byte[1024 * 1024 * 5];
            //    int number=filename.Read(buffer,0,buffer.Length);
            //    string s = Encoding.UTF8.GetString(buffer,0,number);
            //    Console.WriteLine(s);
            //}
            //using (FileStream readfile=new FileStream(@"D:\桌面\1.txt",FileMode.OpenOrCreate,FileAccess.Write))
            //{
            //    string s = "今天天气好晴朗，处处好风光";
            //    byte[] buffer = Encoding.UTF8.GetBytes(s);
            //    readfile.Write(buffer,0,buffer.Length);
            //    Console.WriteLine("ok");
            //}
            #endregion
            using (StreamReader s=new StreamReader(@"D:\桌面\c#基础复习.txt",Encoding.UTF8))
            {
                while (!s.EndOfStream)
                {
                    Console.WriteLine(s.ReadLine());
                }
            }
            byte[] buffer = new byte[1024*1024*5];
            using (StreamWriter sw=new StreamWriter(@"D:\桌面\2.txt",true,Encoding.UTF8,buffer.Length))
            {
                sw.Write("今天天气好晴朗，处处好风光");
            }
            Console.ReadKey();
        }
    }
}
