using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态和非静态的区博恩
{
    public class Person//非静态类
    {
        //静态方法
        public static void M1()
        {
            Console.WriteLine("我是静态方法");
        }
        //非静态方法
        public void M2()
        {
            Console.WriteLine("我是非静态方法");
            Test._name = "hello world";
            Test._name = "蒋国文";

        }
        private int _age;//非静态字段
        private static int _age1;//静态字段
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public static int Age1
        {
            
            get { return _age1; }
            set { _age1 = value; }
        }
    }
}
