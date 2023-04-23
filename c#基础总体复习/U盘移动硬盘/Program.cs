using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U盘移动硬盘
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请选择什么盘");
                string s = Console.ReadLine();
                Father f = Test(s);
                //选择读取，还是写入
                Console.WriteLine("读取还是写入文件");
                string s1 = Console.ReadLine();
                if (s1 == "读取")
                {
                    Console.WriteLine("请输入读取的文件夹");
                    string path = Console.ReadLine();
                    Read(f, path);
                }
                else if (s1 == "写入")
                {
                    Console.WriteLine("请输入写入的文件夹");
                    string path = Console.ReadLine();
                    Write(f, path);
                }
                Console.ReadKey();
            }
        }
        /// <summary>
        /// 简单工厂，判断是那个一存储工具
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static Father Test(string s)
        {
            Father f = null;
            switch (s)
            {
                case "硬盘":
                    f = new MobileDisk();
                    break;
                case "U盘":
                    f = new UDisk();
                    break;
                case "Mp3":
                    f = new Mp3();
                    break;
            }
            return f;
        }
        public static void Read(Father f, string path)
        {
           
            if (f is MobileDisk || f is UDisk)
            {
                f.Read(path);
            }
            else if (f is Mp3)
            {
                f.Write(path);
                Console.WriteLine("是否读取歌曲");
                string s = Console.ReadLine();
                if (s == "是")
                {
                    (f as Mp3).PlayMusic(path);
                }
                else if (s == "否")
                {
                    Console.WriteLine("结束读取");
                }
            }
        }
        public static void Write(Father f, string path)
        {
            f.Write(path);
        }
    }
}
