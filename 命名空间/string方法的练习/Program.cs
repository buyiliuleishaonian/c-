using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string方法的练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //课上练习4∶文本文件中存储了多个文章标题、作者，`
            //标题和作者之间用若干空格（数量不定)隔开，每行一个，
            //标题有的长有的短，输出到控制台的时候最多标题长度10，
            //如果超过10，则截取长度8的子串并且最后添加"...”，加一个竖线后输出作者的名字。
            //string path = @"D:\桌面\1.txt";
            //string[] contents = File.ReadAllLines(path, Encoding.Default);
            //for (int x = 0; x < contents.Length; x++)
            //{
            //    string[] s = contents[x].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //    //选择用三元表达式
            //    Console.WriteLine((s[0].Length>8? s[0].Substring(0, 8) + "..." + "|": s[0]) + s[1]);
            //}
            //Console.ReadKey(true);


            //课堂练习1：接收用户输人的字符串，将其中的字符以与输人相反的顺序输出。"abc" >"cba"
            //Console.WriteLine("请随便输入一个字符串");//应该使用tocharstring();将string转换成char数组
            //然后将char数组，反转，之后通过new string（char[]）转换成string。
            //string x = Console.ReadLine();
            //x = x.Replace(x,"cba");
            //Console.WriteLine(x);
            //Console.ReadKey();

            //课上练习2:接收用户输入的一句英文，将其中的单词以反序输出。"hello c sharp"> "sharp c hello"
            //Console.WriteLine("请输入一段英文对话");
            //string y = Console.ReadLine();
            //string[] y1 = y.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            ////y = string.Join(" ", y1);
            ////Console.Write(y);
            //if (y1.Contains("hello"))
            //{
            //    string z = y1[0];
            //    y1[0] = y1[2];
            //    y1[2] = z;
            //}
            //y = string.Join(" ",y1);
            //Console.WriteLine(y);
            //Console.ReadKey(true);

            //课上练习3:从Email中提取出用户名和域名:abc@163.com o
            //Console.WriteLine("请输入邮箱地址");
            //string mail = Console.ReadLine();
            //int num1 = mail.IndexOf("@");
            //string userName = mail.Substring(0,num1);
            //string passWord = mail.Substring(num1+1);
            //Console.WriteLine(userName);
            //Console.WriteLine(passWord);
            //Console.ReadKey(true);

            //让用户输入一句话，找出所有e的位置
            Console.WriteLine("请随便输入一句话");
            string m = Console.ReadLine();
            int index = m.IndexOf("e");
            int index1 = m.LastIndexOf("e");
            Console.WriteLine("这是第一次出现e的位置{0}",index);
            while (index!=-1&&index<index1)
            {
                index = m.IndexOf("e",index+1);
                Console.WriteLine(index);
            }
            //if (m.Contains("e"))//for循环，因为不知道循环多少次
            //{
            //    int num3 = m.LastIndexOf('e');
            //    int num2 = 0;
            //    for (int l = 0; l <= num3; l = num2)
            //    {

            //        num2 = m.IndexOf('e', num2);
            //        if (num2 != -1)
            //        {
            //            Console.Write(num2);
            //        }
            //    }
            //}
            Console.ReadKey(true);

            //让用户输入一句话,判断这句话中有没有邪恶,
            //如果有邪恶就替换成这种形式然后输出,如:老牛很邪恶,输出后变成老牛很**:
            //    Console.WriteLine("请随便输入一句话");
            //    string s = Console.ReadLine();
            //    if (s.Contains("邪恶"))
            //    {
            //        s = s.Replace("邪恶", "**");
            //        Console.WriteLine(s);
            //    }
            //    else
            //    {
            //        Console.WriteLine(s);
            //    }
            //    Console.ReadKey(true);


            //把“诸葛亮”.”鸟叔”.”卡卡西",”卡哇伊"
            //变成诸葛亮 | 鸟叔 | 卡卡西 | 卡哇伊,然后再把 | 切割掉
            //string s = "“诸葛亮”,“鸟叔”,“卡卡西”,“卡哇伊”";
            //string[] s1 = s.Split(new char[] { '”','“',','} ,StringSplitOptions.RemoveEmptyEntries);
            //s = string .Join("|",s1);
            //Console.WriteLine(s);
            //Console.ReadKey(true);
        }
    }
}
