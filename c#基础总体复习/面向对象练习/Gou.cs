using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象练习
{
    public class Gou:Dongwu
    {
        public override void Eat()
        {
            Console.WriteLine("狗吃骨头");
        }
        public override void Bark()
        {
            Console.WriteLine("狗叫是旺旺");
        }
    }
}
