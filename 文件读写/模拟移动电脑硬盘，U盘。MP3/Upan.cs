using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模拟移动电脑硬盘_U盘_MP3
{
    internal class Upan:YIDongCunChu
    {
        public override void Read()
        {
            Console.WriteLine("U盘读取");
        }
        public override void Write()
        {
            Console.WriteLine("U盘写入");
        }
    }
}
