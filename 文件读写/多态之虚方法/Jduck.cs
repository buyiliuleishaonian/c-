using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态之虚方法
{
    public  class Jduck:Realduck
    {
        public override void Dark()
        {
            Console.WriteLine("假鸭子叫");
        }
        public override void DK()
        {
            Console.WriteLine("程序员不打卡");
        }
    }
}
