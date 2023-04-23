using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher("文憔悴","英语",'男',22);
            Student s1 = new Student("文憔悴",'男',22,1500);
            Console.ReadKey();
        }
    }
}
