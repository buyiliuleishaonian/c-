using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U盘移动硬盘
{
    public abstract class Father
    {
        public abstract void Read(string path);
        public abstract void Write(string path);
    }
}
