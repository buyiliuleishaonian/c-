using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //麻雀会飞，乌鸦会飞，鸵鸟不会飞，企鹅不会飞，直升机会飞。
            //用多态的方法实现
            //多态，抽象，接口
            Interface1 niao = new Zhishengfeiji();
            niao.fly();
            Console.ReadKey();
        }
    }
}
