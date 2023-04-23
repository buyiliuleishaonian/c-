using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象练习
{
    public class Miao:Dongwu
    {
        public override void Eat()
        {
            Console.WriteLine("猫吃猫粮");
        }
        public override void Bark()
        {
            Console.WriteLine("猫叫是喵喵");
        }
    }
}
