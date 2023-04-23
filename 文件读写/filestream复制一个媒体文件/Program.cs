using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filestream复制一个媒体文件
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //就是将一个媒体文件，读取之后，在别的地方写入
            const string name1 = @"F:\wallhaven壁纸下载地\今天吃的很饱 天气晴 你呢.mp4";
            const string name2 = @"D:\桌面\1.mp4";
            Tset(name1,name2);
            Console.ReadKey();
        }
        /// <summary>
        /// 将一个媒体文件，复制粘贴到别的地方
        /// </summary>
        /// <param name="name1"></param>
        /// <param name="name2"></param>
        public static void Tset(string name1,string name2)
        {
            //首先创建一个写入的filestream对象,因为，最后结束写入，所以最后释放空间
            using (FileStream file1 = new FileStream(name2,FileMode.OpenOrCreate,FileAccess.Write))
            {
                //在创建一个读取filestring对象
                using (FileStream file2=new FileStream(name1,FileMode.OpenOrCreate,FileAccess.Read))
                {
                    //需要字节数组接受
                    byte[] buffer = new byte[1024 * 1024 * 5];//5mb
                    while (true)
                    {
                        //读取完一次5mb之后，重新开始读取的地方下标是0
                        int number = file2.Read(buffer, 0, buffer.Length);
                        //当读取不到时，number=0
                        if (number==0)
                        {
                            break;
                        }
                        file1.Write(buffer,0,number);
                    }
                }
            }
            Console.WriteLine("ok");
        }
    }
}
