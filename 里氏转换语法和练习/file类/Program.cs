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
            //创建文件
            //File.Create(@"D:\\桌面\new.txt");
            //Console.WriteLine("创建成功");
            //Console.ReadKey();

            //删除文件，是彻底删除
            //File.Delete(@"D:\\桌面\new.txt");
            //Console.WriteLine("删除成功");
            //Console.ReadKey();

            //复制文件,文件夹，不让复制，复制之后的扩展名要相同
            //File.Copy(@"D:\桌面\机器人1902班\电工证理论考试题库.docx", @"D:\桌面\1.docx");
            //Console.WriteLine("复制成功");
            //Console.ReadKey(true);

            //剪切,move
            //string s = @"D:\桌面\1.docx";
            //string s1 = @"D:\桌面\2.docx";
            //File.Move(s,s1);
            //Console.WriteLine("剪切成功");
            //Console.ReadKey();

            //读写数据
            //File.WriteAllBytes(@"D:\桌面\2.docx", byte[] );
            //File.ReadAllBytes();

            //所有编码格式
            EncodingInfo[] en = Encoding.GetEncodings();
            foreach (var item in en)
            {
                Console.WriteLine(item.DisplayName);
            }
            Console.ReadKey();
        }
    }
}
