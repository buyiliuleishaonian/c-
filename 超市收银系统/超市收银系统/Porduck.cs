using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    /// <summary>
    /// 给超市的货物建立的父类
    /// </summary>
    public class Porduck
    {
        //父类
        //用自然属性，会自动默认生成对应字段，这样对于字段的限制
        //这样对于字段的限制就需要写在构造函数当中。
        public string ID
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public double  Price
        {
            get;
            set;
        }
        public Porduck(string id,double price,string name)
        {
            this.ID = id;
            this.Price = price;
            this.Name = name;
        }
    }
}
