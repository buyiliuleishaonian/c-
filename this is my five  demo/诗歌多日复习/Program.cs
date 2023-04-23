using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace 诗歌多日复习
{
    public enum Gender
    {
        男,
        女
    }
    public struct People
    {
        public int _age;
        Gender _gender1;
        public string _name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //常量，const 一旦赋值不能在改变
            const int number1 = 0;
            //枚举，规范一类，建立在命名空间和类之间
            //枚举之间的数据类型转换
            Gender gender = Gender.男;
            int number2 = (int)gender;
            Console.WriteLine(number2);
            int number3 = 1;
            gender = (Gender)number3;
            Console.WriteLine(gender);

            string people = Convert.ToString(gender);
            Console.WriteLine(people);

            string people1 = "男";
            gender = (Gender)Enum.Parse(typeof(Gender), people1);
            Console.WriteLine(gender);

            //结构：就是建立多个不同类型的字段
            People x, y;
            x._age = 19;
            y._age = 22;

            //数组就是存储多个相同类型的变量
            int[] nums = new int[11];

            //冒泡排序
            //for循环嵌套
            //也还可以调用array.sort(nums)从小到大排序
            //array.revence(nums)数组反转

            //方法，也就是函数，相当一个子程序
            int  z=Program.Max(2, 34);
            Console.WriteLine(z);
            Console.ReadLine();

            //return  1、放回方法的返回值
            //2、跳出方法

        }
        public static int Max(int n1,int n2)
        {
            return n1 > n2 ? n1 : n2;
        }
    }
}
