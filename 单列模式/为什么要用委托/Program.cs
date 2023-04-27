using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 为什么要用委托
{
    internal class Program
    {
        public delegate string[] MyDelegate(string[] s);
        static void Main(string[] args)
        {
            string[] s = { "wenqiao", "BuYiLiuLeiShaoNian", "GuGaoZiAoShaoNian" };
            //1、这个字符串数组全部变小写
            //2、这个字符串数组全部变大写
            //3、这个字符串数组的每个元素两边加上/
            MyDelegate del = StrToUpper;
            Test(s,del);
            Console.ReadKey();
        }
        public static string[] Test(string[] s,MyDelegate del)
        {
            return del(s);
        }
        public static  string[] StrToUpper(string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                s[i].ToUpper();
            }
            return s;
        }
        public static string[] StringToLower(string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                s[i].ToLower();
            }
            return s;
        }
        public static string[] StrJion(string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = @"\" + s[i] + @"\";
            }
            return s;
        }
    }
}
