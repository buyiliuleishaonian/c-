using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态之虚方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //多态:让一个对象可是实现多种方法（类型）；
            //1、将给定的类当中，选择一个类当作父类
            //2、将父类的方法用virtual来标记，将子类的方法用override标记


            //真鸭子叫，假鸭子叫，木头鸭子叫
            //经理十一点打卡，员工九点打卡，程序员不打卡。
            Realduck rd = new Realduck();
            Jduck jd = new Jduck();
            MTduck md = new MTduck();
            Realduck[] rd1 = { rd, jd, md };
            for (int i = 0; i < rd1.Length; i++) 
            {
                rd1[i].DK();
            }
            for (int i = 0; i < rd1.Length; i++)
            {
                rd1[i].Dark();
            }
            Console.ReadKey();
        }
    }
}
