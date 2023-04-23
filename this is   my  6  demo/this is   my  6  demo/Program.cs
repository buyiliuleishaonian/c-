using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace this_is___my__6__demo
{
    internal class Program
    {
        public static int  _number=0;
        static void Main(string[] args)
        {
            _number = 0;
            int x = 91;//(实参)
            Xx(x);
            Console.WriteLine(_number);//还是输出0，因为方法，没有返回值类型，也没有返回值
            Console.ReadKey();
        }
        public static void Xx(int x)//(形参)
        {
            x = x+ 2;
        }
    }
}
