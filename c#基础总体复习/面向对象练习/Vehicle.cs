using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象练习
{
    public  class Vehicle
    {
        public string Color
        { get; set; }
        public string Bland
        { get; set; }
        public  void Run()
        {
            Console.WriteLine("可以跑80码");
        }
        public Vehicle(string color,string bland)
        {
            this.Color = color;
            this.Bland = bland;
        }
    }
}
