using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象练习
{
    public  class Father
    {
        public string LastName
        {
            get;
            set;
        }
        public decimal Money
        {
            get;
            set;
        }
        public string BlondType
        {
            get;
            set;
        }
        public Father(string lastname,decimal money,string blondtype)
        {
            this.LastName = lastname;
            this.Money = money;
            this.BlondType = blondtype;
        }
        public void SayHello()
        {
            Console.WriteLine("我叫{0},我有{1}元,血型是{2}",this.LastName,this.Money,this.BlondType);
        }
    }
}
