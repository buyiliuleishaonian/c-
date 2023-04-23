using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象练习
{
    public   class Daugther:Father
    {
        public void Dance()
        {
            Console.WriteLine("女儿会跳舞");
        }
        public Daugther(string lastname,decimal money,string blondtype):base(lastname,money,blondtype)
        {
            
        }
    }
}
