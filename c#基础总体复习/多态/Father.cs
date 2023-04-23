using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
   public  abstract class Father
    {
        public double Number1
        { get; set; }
        public double Number2 
        { get ; set; }
        public abstract double Test();
        public Father(double num1,double num2)
        {
            this.Number1 = num1;
            this.Number2 = num2;
        }
    }
}
