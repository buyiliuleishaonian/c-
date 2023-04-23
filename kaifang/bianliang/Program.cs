using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bianliang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //变量类型，变量名
            //变量名=值

            //官方语言，声明或者定义了一个变量
            int number;//在内存中，开辟了整数的空间
            //官方语言：给变量赋值
            number = 100;//100存储在number变量

            int n = 100;

            double m = 1.233;
            double a = 1;//double 表示小数，也可以是整数

            string Name = "张三";//字符串可以存储"空"
            string name = "";

            char gender = '男';//字符是单引号，字符只能有一个
            char Gender = '女';//字符类型不能存空

            //decimal也是可以表示小数的,单独用decimal用来存钱
            decimal money = 5000m;  //值的后面跟一个m


        }
    }
}
