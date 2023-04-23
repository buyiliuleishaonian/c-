using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂设计模式
{
    public  class Mac:Contour
    {
        public override void Test()
        {
            Console.WriteLine("我是苹果电脑");
        }
    }
}
