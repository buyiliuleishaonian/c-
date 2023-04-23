using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Son类 son = new Son类("蒋",100m,"A");
            Daugther gril = new Daugther("蒋",1000m,"AB");
            son.SayHello();
            son.PlayGame();
            gril.SayHello();
            gril.Dance();
            Console.ReadLine();
        }
    }
}
