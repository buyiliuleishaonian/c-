 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //猫叫，狗叫
            //当给定的类，没有可以当作虚方法的父类时,
            //就需要抽象一个类和方法。
            Class1 s = new Class3(); //new Class2();
            s.Jiao();
            Console.ReadKey();
        }
    }
}
