using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 回顾
{
    public enum Name
    {
        蒋,
        孙
    }
    public struct People
    {
        int _age;
        string _naem;
        char _ganson;
        Name _x;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //枚举，结构，数组
            //枚举，创建在命名空间和类之间，通过public可以公正在整个里面使用
            //枚举的语法 public enum  Gender（枚举名，满足pacal命名方式）
            //public enum Name
            //{
            //      蒋，
            //      孙
            //}
            //可以用来规定一些约定俗成的东西，
            //在程序里面调用枚举时
            //Name  name=Name.蒋；//首先是需要声明某枚举名的变量，然后赋予枚举值
            //枚举和int类型的转换，都是通过强制类型转换，说明int和枚举是兼容的
            //Name name=Name.蒋；
            //int number_1=(int) name;
            //枚举类型的值，是从0开始的，也可以给枚举的值给定数字
            //枚举和string类型之间的相互转换
            //枚举转string
            Name name = Name.蒋;
            string name_1 = name.ToString();//这两种转换方式都算是，tostring类型转换
            name_1 = Convert.ToString(name);
            //string 类型的转枚举，需要通过一个方法
            string name_2 = "0";
            Name name_3 = (Name)Enum.Parse(typeof(Name),name_2);
            //这个转换公式是 代转成的枚举名 变量名=代转成的枚举名 枚举 .parse方法，参数，转换的成枚举名，带转换的string



            //结构：也是在命名空间和类之间
            //语法
            //public strcut  Ganson
            //{
            //  int age;字段
            //  string name;
            //  char people;
            //  Name  name_4;
            //}
            //结构是用来声明多个类型的变量的
            //字段可以存储多个值
            //Ganson  x；
            //x.age=12；
            //Ganson y；
            //y.age=22；
            //结构里面还可以调用枚举，
            // Ganson a;
            //a.name=Name.蒋

            //常量，就是不能改变其值的量
            //语法: const int number=111;

            //数组；创建在函数当中，可以创建多个相同类型的变量
            //语法
            //int[] nums=new int[10]；
            int[] nums = new int[10];
            //需要依靠下标来寻找数组中的元素
            //  int类型的数组，没有赋值之前都是0，
            //bool类型数组没有赋值之前都是 false
            //string类型，没有赋值之前都是 null null表示在内存里面还没有开空间，""空表是开空间了，只不过没有存值


            //创建随机数
            Random number_110 = new Random();//创建生成随机数的对象
            int number_111 = number_110.Next(1,100);//调用.Next方法来生成随机数，后面是随机数的范围
        }
    }
}
