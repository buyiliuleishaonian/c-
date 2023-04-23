using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值传递和引用传递
{
    internal class Class1
    {
        int _age;
        public int Age { get => _age; set => _age = value; }
        public Class1(int age)
        {
            this.Age = age;
        }
    }
}
