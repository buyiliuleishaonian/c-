using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托使用
{
    internal class Program
    {
        //声明一个委托类型
        public delegate void MyDelegate(string name);
        //委托就是将一个方法当作参数给另一个方法
       //创建的委托类型要与其参数要和当作参数的方法的参数一样，并且放回值也要一样
        static void Main(string[] args)
        {
            //创建一个委托对象,这个对象这里必须输入和其签名相同的方法名
            MyDelegate del = new MyDelegate(SayHiChinese);
            Test("文憔悴",del);
            Console.ReadKey();
        }
        //这个方法，需要满足当作参数的方法这个方法的参数和这个方法的参数相同，还要加入委托的参数
        public static void Test(string name,MyDelegate del)
        {
            //
            del(name);
        }
        public static void SayHiChinese(string name)
        {
            Console.WriteLine("你好" + name) ;
        }
        public static void SayHiEngish(string name)
        {
            Console.WriteLine("hello wrod"+name);            
        }
    }
}
