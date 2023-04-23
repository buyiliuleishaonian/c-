using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 重写Tostring__方法
{
    public class Tostring:Object
    {
        public override string ToString()
        {
            Console.WriteLine("转换成功");
            return "ok";
        }
    }
}
