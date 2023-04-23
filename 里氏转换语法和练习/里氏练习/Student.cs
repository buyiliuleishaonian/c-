using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏练习
{
    public class Student:Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("你好，我是学生");
        }
    }
}
