using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace 异常捕获
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //语法上没有错误，程序运行过程中，由于某学原因出现了错误
            //变量只在生成的{大括号开始到这个括号结束}在这个范围内可以使用
            Console.WriteLine("请输入数值");
            int number=0;//声明变量，所以先给变量赋予初始值
            bool x = true;
            try 
            {
                number = Convert.ToInt32(Console.ReadLine());//变量赋值，用户可能不一定赋值数字
                
            }
            //之间不让写代码
            catch
            {
                Console.WriteLine("请只输入数字，字母不能出现");
                x = false;
            }

            //我们如果要执行下面这行代码，需要满足一些条件，当try里面的代码，出现异常，就不执行，不出现异常，就执行
            //让代码满足条件去执行，最常用的就是使用bool类型
            if (x == true)
            {
                Console.WriteLine(number*2);//使用，两种方式，第一将这行代码放在try{}中，第二就是声明一个bool用if语句选择执行
            }
            Console.ReadKey();
        }
    }
}
