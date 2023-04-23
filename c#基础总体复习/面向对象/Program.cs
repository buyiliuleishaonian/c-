using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this：表是当前类的对象，显示调用构造函数
            //new：在堆中开辟空间，创建对象，初始化对象，隐藏从父类哪里继承过来的成员
            Person wen=new Person("文");
            wen.Age = 101;
            wen.Gender = 'x';
            wen.Test();
            Console.ReadKey(true);
        }
    }
}
