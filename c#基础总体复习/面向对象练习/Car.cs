using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象练习
{
    public  class Car:Vehicle
    {
        public override void Run()
        {
            
        }
        public int Person
        {
            get;
            set;
        }
        public Car(string color ,string bland,int person):base(color,bland)
        {
            this.Person = person;
        }
        public void passenger()
        {
            Console.WriteLine("可以最多载{1}人",this.Person);
        }
    }
}
