using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    internal class Zhishengfeiji:Bird, Interface1
    {
        public void fly()
        {
            Console.WriteLine("直升飞机可以飞");
        }
    }
}
