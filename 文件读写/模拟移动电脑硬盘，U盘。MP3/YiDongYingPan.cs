using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模拟移动电脑硬盘_U盘_MP3
{
    internal class YiDongYingPan : YIDongCunChu
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘读取") ;
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘写入");
        }
    }
}
