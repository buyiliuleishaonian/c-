using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模拟移动电脑硬盘_U盘_MP3
{
    internal class Mp3:YIDongCunChu
    {
        public override void Read()
        {
            Console.WriteLine("MP3读取");
        }
        public override void Write()
        {
            Console.WriteLine("MP3写入");
        }
    }
}
