using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值传递和引用传递
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //值传递和引用传递
            //值传递：在复制时，是将本身传递给对方
            //引用传递：在复制时，是将对象的引用传递下去,string例外因为string的不可变性

            Class1 test = new Class1(22);
            Class1 test1 = test;
            test1.Age = 18;
            Console.WriteLine(test.Age);
        }
    }
}
