using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串中的各种方法
{
    public enum Name
    {
        蒋,
        文
    }
    public struct People
    {
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入你当前想到的名字，然后将其字符串的长度输出
            //Console.WriteLine("请入一个最想的名字");
            //string name = Console.ReadLine();
            //Console.WriteLine(name.Length);
            //Console.ReadKey(true);

            ////将字字符串的数据转为大写或者小写
            //Console.WriteLine("请输入最喜欢的课程");
            //string s1 = Console.ReadLine();
            string s1 = "jiang";
            s1 = s1.ToUpper();
            s1 = s1.ToLower();
            //s1=s1.ToUpper();//转大写
            //s1=s1.ToLower();//转小写
            //Console.WriteLine("请输入最喜欢的课程");
            //string s2=Console.ReadLine();
            ////s2 = s2.ToUpper();
            ////s2 = s2.ToLower();
            ////if (s1 == s2)
            //    if(s1.Equals(s2,StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("相同");
            //}
            //else
            //{
            //    Console.WriteLine("不相同");
            //}
            //Console.ReadKey();

            //将字符串中的不需要的，删除之后又在分隔
            //string name2 = "2023-3-21";
            //string[] name3 = name2.Split(new char[] {'-' },StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}年{1}月{2}日", name3[0], name3[1], name3[2]);
            //Console.ReadKey();

            //字符串替换、
            //这三个方法都需要bool类型的返回值
            //判断字符串中是否有子串  bool x= .conatains(string value)
            //判断字符串是否以某字符开始  bool x=.startswith(string value)
            //判断字符串是否以某字符结尾  bool x=.endswith(string value)
            //取字符串中某一字符串第一次出现的位置，输出索引  找不到输出为-1
            string name = "烟花三月下扬州，三月,欲雨泪先流,水";
            name = name.Replace("烟花","烟雨");
            if (name.Contains("烟雨"))
            {
                Console.WriteLine(name);
                Console.WriteLine("replace是替换的方法");
                Console.WriteLine("contains是判断字符串是否有子符串的方法");
            }
            else
            {
                Console.WriteLine("没有");
            }
            if (name.StartsWith("烟雨"))
            {
                Console.WriteLine("startswiths是以什么开始的");
            }
            if (name.EndsWith("流"))
            {
                Console.WriteLine("endswith是以什么结尾的");
            }
            int index = name.IndexOf("扬州");//取某字符第一次出现地方，输出其索引
            int index1 = name.IndexOf("三月",4);//从指定的索引开始搜索出现的第一次指定字符的索引
            Console.WriteLine(index);
            Console.WriteLine(index1);

            //字符串截取
            string name1 = name.Substring(2);
            string name2 = name.Substring(2,4);
            Console.WriteLine(name1);
            Console.WriteLine(name2);


            //字符串去空格
            //字符串去除所有空格 trim
            //字符串去除前面的空格  trimsarta
            //字符串去除后面的空格  trimend
            string sum = "      sdjajda       sdasadsa       ";
            string sum1 = sum.Trim();//将前后的空格全部山粗
            //Console.Write(sum1);
            //Console.ReadKey(true);
            //将字符串前面的空白全部删除
            //sum1 = sum.TrimStart();
            //Console.Write(sum1);
            //Console.ReadKey();
            //将字符串后面的空白全部删除
            sum1 = sum.TrimEnd();
            Console.Write(sum1);
            Console.ReadKey();
            string name4;
            bool x=string.IsNullOrEmpty(name);
        }
    }
}
