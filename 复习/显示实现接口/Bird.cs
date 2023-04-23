using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 显示实现接口
{
    internal class Bird : Ifly
    {
        public void fly()
        {
            Console.WriteLine("我会飞");
        }
        /// <summary>
        /// 显示实现方法.
        /// </summary>
        void Ifly.fly()
        {
            Console.WriteLine("显示使用此方法。");
        }
    }
}
