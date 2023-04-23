using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 复习
{
    public  class Ticket
    {
        //写一个tivket类，有距离属性（本属性只读，在构造函数中赋值）只有get
        //不能为负数，写一个价格属性，价格属性只读
        //并且根据距离distance计算价格price，一公里1元
        private double _distance;
        public double Distance
        {
            get
            {
                if (_distance<0)
                {
                    _distance =0;
                }
                return _distance; 
            }
        }
        public Ticket(double distance )
        {
            _distance = distance;    
        }
        private double _price;
        public double Price
        {
            get 
            {
                if (_distance > 0 && _distance <= 100)
                {
                    return _distance;
                }
                else if (_distance >= 101 && _distance < 200)
                {
                    return _distance * 0.95;
                }
                else if (_distance <= 300 && _distance >= 200)
                {
                    return _distance * 9;
                }
                else 
                {
                    return _distance * 8;
                }
            }
        }
        /// <summary>
        /// 显示多少公里，多少钱
        /// </summary>
        public void ShouMenoy()
        {
            Console.WriteLine("{0}公里{1}钱",_distance,Price);
        }
    }
}
