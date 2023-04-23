using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类练习
{
    internal class Ju : Xing
    {
        private double _l;
        public double L { get => _l; set => _l = value; }
        private double _h;
        public double H { get => _h; set => _h = value; }


        public Ju(double l,double h)
        {
            this.H = h;
            this.L = l;
        }

        

        public override double C()
        {
            return this.H * this.L;
        }

        public override double S()
        {
            return (this.H*this.L) * 2;
        }
    }
}
