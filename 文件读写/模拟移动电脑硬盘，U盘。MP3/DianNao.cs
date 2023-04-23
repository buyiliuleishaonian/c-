using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模拟移动电脑硬盘_U盘_MP3
{
    internal class DianNao
    {
        //写两个方法来，调用父类的对象实现读写
        //调用父类的对象，有两种方式，一是，传递父类类型的参数
        //二是：构建父类的字段
        YIDongCunChu _yd;
        YIDongCunChu Yd
        {
            get { return _yd; }
            set { _yd = value; }
        }
        public DianNao(YIDongCunChu yd)
        {
            this.Yd = yd;
        }
        /// <summary>
        ///  通过里氏转换，加上多态，使之插入什么就读取什么。
        /// </summary>
        public void CPUread()
        {
            Yd.Read();
        }
        /// <summary>
        /// 通过里氏变换和多态，使之插入什么就写入什么.
        /// </summary>
        public void CPUwrite()
        {
            Yd.Write();
        }
    }
}
