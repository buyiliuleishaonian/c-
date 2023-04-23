using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换语法和练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            里氏转换
            //1、	子类可以赋值给父类。:当我们需要一个父类参数的时候，可以用子类代替
            Student s = new Student();
            Person s1 = s;
            Person s2 = new Student();
            //2、	如果父类中的是子类的对象，那么可以将这个父类强装为子类对象
            s = (Student)s1;

            //is转换
            if (s2 is Teacher)
            {
                Teacher s3 = (Teacher)s2;
                s3.SatHellotwo();
            }
            else
            {
                Console.WriteLine("转换失败");
            }

            Student s4 = s1 as Student;
            s4.SayHeoll();
            Console.ReadKey(true);

        }
    }
}
