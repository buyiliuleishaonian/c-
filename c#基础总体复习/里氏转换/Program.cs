using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Student();
            Student p1 = p as Student;
            Console.WriteLine(p1);
            if (p is Teacher)
            {
                Console.WriteLine("转换成功");
            }
            else
            {
                Console.WriteLine("转换失败");
            }
            Console.ReadKey();
        }
    }
}
