using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamda表达式
{
    internal class Program
    {
        public delegate void delOne();
        public delegate void delTwo(string name);
        public delegate int delThree(int x);
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1,2,34,5,5,5};
            list.RemoveAll(x => x>3); 

        }
    }
}
