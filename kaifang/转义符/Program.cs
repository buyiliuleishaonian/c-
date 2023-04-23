using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 转义符
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            //Console.WriteLine("布衣流泪少年郎\n孤高自傲少年郎");

            //Console.WriteLine("我想这句话中输出 \"\"英文半角双引号");

            //string name_1 = "蒋国文";
            //string name_2 = "文憔悴";
            //string name_3 = "文无敌";
            //string name_4 = "帅文文";
            //Console.WriteLine("{0}\t{1}", name_1, name_2);//  \t表示为一个tap的距离
            //Console.WriteLine("{0}\t{1}", name_3, name_4);
            //Console.ReadKey();


            //Console.WriteLine("我想这句话中输出 英文半角双引号我想这句话中输出 英文半角双引号");
            //Console.ReadKey();

            //string str = "布衣流泪少年\n孤高自傲少年";//windows系统\n，不能换行，苹果系统可以，windows需要\r\n
            //System.IO.File.WriteAllText(@"D:\桌面\111.txt",str);
            //Console.WriteLine("写入成功");
            //Console.ReadKey(); 


            //string path = @"F:\qqj图片";//可以用  //表示一个/    也可以在路劲最前面用@
            //Console.WriteLine(path);


            Console.WriteLine(@"布衣流泪少年
                                                    孤高自傲少年");
        }
    }
}
