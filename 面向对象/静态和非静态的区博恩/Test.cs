using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态和非静态的区博恩
{
    static  class Test
    {
       public  static string _name;
        public static void main()
        {
            Person.M1();
            Person s = new Person();
            s.M2();
        }
        public static void Test1()
        {
            Person s = new Person();
            s.M2();
        }
    }
}
