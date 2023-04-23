using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类练习
{
    public class Yuan : Xing
    {
        private double _r;

        public double R
        {
            get => _r;
            set => _r = value;
        }
        public Yuan(double r)
        {
            this.R = r;
        }

        public override double  C()
        {
            return this.R * Math.PI * this.R;
        }

        public override double S()
        {
            return this.R * 2 * Math.PI;
        }
    }
}
