using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 文件读写
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //里氏转换
            //1、将子类对象可以父类赋值
            //2、当父类含有子类对象时，可以强行将父类转换成子类

            //转换方式 is as
            //is  转换成功输出true  转换失败false
            //as 转换成功输出转换的值，转换失败输出null，所以接受as的类型，必须可以接受null

            //关键字protected
            //不仅可以在本类中调用，还可以在子类中调用

            //arraylist和hashtable集合
            //arraylist
            //增加 add  addrange  删 remove removeat removerange 
            //插入 insert  insertrange   清屏 clear
            //sort 排序 reveser 反装
            //包含 contains
            //hashtable
            //增加 add  删除 remove
            //清屏clear 包含键containskey 包含值containsvalue

            //path类
            //输出文件名
            //Console.WriteLine(Path.GetFileName(@"D:\桌面\O0521.txt"));
            //输出文件名，不包括扩展名
            //Console.WriteLine(Path.GetFileNameWithoutExtension(@"D:\桌面\O0521.txt")) ;
            //获取扩展名
            //Console.WriteLine(Path.GetExtension(@"D:\桌面\O0521.txt"));
            //获取绝对路径
            //Console.WriteLine(Path.GetFullPath(@"D:\桌面\O0521.txt"));
            ////获取文件夹
            //Console.WriteLine(Path.GetDirectoryName(@"D:\桌面\O0521.txt"));
            //Console.ReadKey();

            //file类
            //创建 create  删除 delect  剪切move
            //读写文本文件 writeallbytes   readallbytes
            //先需要写入的字符串
            //string name = "布衣流泪少年";
            //需要将字符串，编码，之后转成字节类型
            // byte[] buffer = Encoding.Default.GetBytes(name) ;
            //先判断是否存在此文本，存在就覆盖，不存在就创建一个
            //File.WriteAllBytes(@"D:\桌面\new.txt", buffer);
            //Console.ReadKey();

            //读取文本
            //byte[] buffer=File.ReadAllBytes(@"D:\桌面\O0521.txt");
            ////然后需要将字节类型转化成字符串
            //string name = Encoding.Default.GetString(buffer);
            //Console.WriteLine(name);
            //Console.ReadKey();

            //一行行写入，存在原有文件，会覆盖原有文件
            File.WriteAllLines(@"D:\桌面\O0521.txt", new string[] { "d1", "22" });
            Console.WriteLine("ok");
            Console.WriteLine();

            //整个写入，并且需要，提供写入的编码形式，也会覆盖原有文件
            File.WriteAllText(@"D:\桌面\O0521.txt", "张三赵四王五", default);
            Console.WriteLine("ok");
            Console.ReadKey();

            //不会覆盖原有文件，会添加写入
            File.AppendAllLines(@"D:\桌面\O0521.txt", new string[] { "  ", "12334567" });
            Console.WriteLine();
            Console.ReadKey();

            //File.AppendText(@"D:\桌面\O0521.txt");
            //Console.ReadKey();

            //一行行读取
           string[] strin= File.ReadAllLines(@"D:\桌面\O0521.txt");
            foreach (string item in strin)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();


            //整个读取
            string s = File.ReadAllText(@"D:\桌面\O0521.txt");
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
