using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    public  class DianNao :Porduck
    {
        //调用父类的构造函数，
        public DianNao(string id ,string name,double price):base(id,price,name)
        {
            
        }
    }
}
