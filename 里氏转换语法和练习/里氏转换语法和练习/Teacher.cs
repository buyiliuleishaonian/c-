using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换语法和练习
{
    internal class Teacher:Person
    {
        public void SatHellotwo()
        {
            Console.WriteLine("你好，我是老师");
        }
    }
}
