using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace path_file_directory练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s=File.ReadAllLines(@"D:\桌面\2.txt");
            for (int i = 0; i < s.Length; i++)
            {
                //首先得到“|”这个字符的下标，
                int number=s[i].IndexOf("|");
                //将其之后的所有字符，截取出来
                string slay=s[i].Substring(number+1);
                int sum = Convert.ToInt32(slay);
                int sum1= sum * 2;
                s[i]=s[i].Replace(slay,sum1.ToString());
            }
            File.WriteAllLines(@"D:\桌面\1.txt",s);
            Console.WriteLine("ok");
            Console.ReadKey();
        }
    }
}
