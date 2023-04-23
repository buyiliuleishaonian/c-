using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @int.pase类型转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //使用convert 使用成功啦 就成功啦 失败啦 就失败啦
            //int number=convert.toint32("1243adv")//convert本质上就是在调用int.parse

            //int number = int.Parse("123");//将字符串类型转换成数字类型,也不能将带有字母的字符串改为数字类型
            //还有 double.parse（）；
            //Console.WriteLine(number);

            int number=10;
            //参数 放回值，参数就是，函数帮我们完成这件事情需要的东西，返回值，就是做这个事情之后的结果也就是bool x的值ture和false
            bool x=int.TryParse("123abc", out number);//“123” number 为参数：需要转换的数据，需要接收转换的数据变量。
            //不管number的初始值为多少，但是转换失败之后，会将0给与number
            //int.tryparse();尝试将字符串类型，转换成number类型，要是转换成功，x=true
            //如果说转换失败，x=false，number=0；不会出现异常。
            //tryparse：称为方法或者是函数
            //方法或者函数？ 帮助我们做一件事情，
            Console.WriteLine(x);
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
