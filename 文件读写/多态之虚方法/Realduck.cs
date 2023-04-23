using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态之虚方法
{
    public  class Realduck
    {
        public virtual void Dark()
        {
            Console.WriteLine("真鸭子叫");
        }
        public virtual void DK()
        {
            Console.WriteLine("员工九点打卡");
        }
    }
}
