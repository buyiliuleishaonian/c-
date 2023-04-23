using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    public  class Chen:Father
    {
        public override double Test()
        {
             return this.Number1 * this.Number2;
        }
        public Chen(double num1,double num2):base(num1,num2)
        {

        }
    }
}
