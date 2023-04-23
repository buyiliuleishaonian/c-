using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_基础总体复习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //需要使用进程，需要多态，需要简单工厂，
            Console.WriteLine("请选择磁盘"+"\t"+@"磁盘名：+\");
            string filename = Console.ReadLine();
            Console.WriteLine("请输入想要访问的文件名");
            string pathname = Console.ReadLine();
            Person p = OpenFile(pathname,filename+pathname);
            p.Test();
            Console.ReadKey();
        }
        /// <summary>
        /// 通过简单工厂，得到具体的文件类型，调用进程实现
        /// </summary>
        /// <param name="pathname"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static  Person OpenFile(string pathname,string filename)
        {
            //创建需放回的父类
            Person p = null;
            //将文件的扩展名提取出来
            string name = Path.GetExtension(pathname);
            switch (name)
            {
                case ".txt" : p = new Txt(filename);
                    break;
                case ".wav":p = new Wav(filename);
                    break;
                case ".jgp":
                case ".png": p = new TuPian(filename);
                    break;
            }
            return p;
        }
    }
}
