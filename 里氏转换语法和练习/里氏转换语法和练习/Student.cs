using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换语法和练习
{
    internal class Student:Person
    {
        public void  SayHeoll()
        {
            Console.WriteLine("你好，我是学生");
        }
    }
}
