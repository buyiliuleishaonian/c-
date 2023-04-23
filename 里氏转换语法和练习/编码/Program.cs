using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 编码
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte[] buffer = File.ReadAllBytes(@"C:\Users\何明洋\Desktop\1.txt");

            //获取所有编码方式
            EncodingInfo[] en = Encoding.GetEncodings();
            foreach (var item in en)
            {
                Console.WriteLine(item.DisplayName);
            }
            Console.ReadKey();

            //将字节数组转换成字符串
            string s = Encoding.UTF8.GetString(buffer);
            Console.WriteLine(s);
            Console.WriteLine(buffer.ToString());
            // 编码格式：指的就是你以怎样的形式来存储字符串
            //  a - z  0 - 9  Ascii  117 u---- > 汉字--->GB2312 GBK
            int n = (int)'u';
            char c = (char)188;
            Console.WriteLine(c);
            Console.WriteLine(n);
            Console.ReadKey();

            //写入文件
            //string s = "今天天气好晴朗，处处好风光";
            //将字符串转换成字节数组
            //byte[] buffer = Encoding.Default.GetBytes(s);
            //以字节的形式向计算机中写入文本文件
            //File.WriteAllBytes(@"C:\Users\何明洋\Desktop\1.txt", buffer);
            //Console.WriteLine("写入成功");
            //Console.ReadKey();


            //使用File类来实现一个多媒体文件的复制操作

            //读取
            //byte[] buffer = File.ReadAllBytes(@"C:\Users\SpringRain\Desktop\12333.wmv");
            //Console.ReadKey();

            // 写入
            //File.WriteAllBytes(@"C:\Users\SpringRain\Desktop\new.wav", buffer);
            //Console.WriteLine("复制成功");
            //Console.ReadKey();

            //设置写入文件大小
            //byte[] buffer = new byte[1024 * 1024 * 5];
            //while (true)
            //{
            //    File.WriteAllBytes(@"C:\Users\何明洋\Desktop\1.txt", buffer);
            //}


            //循环读取文件//一行一行的读取
            //string[] contents = File.ReadAllLines(@"C:\Users\SpringRain\Desktop\抽象类特点.txt", Encoding.Default);
            //foreach (string item in contents)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            //文件全部加载一起读取
            //string str = File.ReadAllText("抽象类特点.txt", Encoding.Default);
            //Console.WriteLine(str);
            //Console.ReadKey();

            //一行一行写入
            //File.WriteAllLines(@"C:\Users\SpringRain\Desktop\new.txt", new string[] { "aoe", "ewu" });
            //Console.WriteLine("OK");
            //Console.ReadKey();

            //直接写入一个字符串
            //File.WriteAllText(@"C:\Users\SpringRain\Desktop\new.txt", "张三李四王五赵六");
            //Console.WriteLine("OK");
            //Console.ReadKey();

            //以上写入文件时会将文件原有内容覆盖
            //    使用AppendAllText对文件进行写入时是对文件进行追加，不会覆盖原有数据
            //File.AppendAllText(@"C:\Users\SpringRain\Desktop\new.txt", "看我有木有把你覆盖掉");
            //Console.WriteLine("OK");
            //Console.ReadKey();


        }
    }
}
