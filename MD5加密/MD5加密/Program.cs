using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MD5加密
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //只要涉及存储用户的密码，就要MD5加密
            Console.WriteLine("请输入密码");
            string password = Console.ReadLine();
            string md5PassWord= GetMD5(password);
            Console.WriteLine(md5PassWord);
            Console.ReadKey(true);
        }
        public static string GetMD5(string password)
        {
            //手下需要创建MD5对象
            //MD5是个抽象类
            //通过MD5类中的create方法从，返回值是MD5，这样来模拟一个对象
            MD5 md5 = MD5.Create();
            //开始加密字节数组
            //需要将字符串转成字节数组
            byte[] buffer = Encoding.Default.GetBytes(password);
            //开始加密,得到得是一个字节数组
            buffer = md5.ComputeHash(buffer);
            //将字节数组转成字符串有三种方式
            //1、就是将字节数组通过编码方式转成对应得字串
            //2、就是将字节数组直接tostring（）；这样得到只可能是字节数组所在的命名空间
            //3、将字节数组里面的每一个元素都转成字符串。
            string newstr = null;
            for (int i = 0; i < buffer.Length; i++)
            {
                newstr += buffer[i].ToString("x");//十进制转程16进制
            }
            return newstr;
        }
    }
}
