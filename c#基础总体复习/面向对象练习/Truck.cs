using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象练习
{
    public  class Truck:Vehicle
    {
      
        public Truck(string color, string bland,double weight):base(color,bland)
        {
            this.Weight = weight;
        }
        public double Weight
        {
            get;
            set;
        }
        public void LaHuo()
        {
            Console.WriteLine("可以拉动{0}货物",this.Weight);
        }
    }
}
