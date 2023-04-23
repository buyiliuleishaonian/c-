using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    public class calMN : CalFather
    {
        public int M
        { get; set ; }
        public int N
        { get; set; }
        public calMN(int M,int N)
        {
            this.M = M;
            this.N = N;
        }

        public override double RealMoney(double money)
        {
            double realmoney = money > M ? money - (int)money / M * N : money;
            return realmoney;
        }
    }
}
