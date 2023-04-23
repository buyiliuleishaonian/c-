using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态之虚方法
{
    public  class MTduck:Realduck
    {
        public override void Dark()
        {
            Console.WriteLine("木头鸭子叫");
        }
        public override void DK()
        {
            Console.WriteLine("经理十一点打卡");
        }
    }
}
