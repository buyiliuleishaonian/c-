using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模拟移动电脑硬盘_U盘_MP3
{
    /// <summary>
    /// 构建一个抽象类
    /// </summary>
    public abstract class YIDongCunChu
    {
        /// <summary>
        /// 将方法写为抽象方法，实现多态
        /// </summary>
        public abstract void Read();
        public abstract void Write();
    }
}
