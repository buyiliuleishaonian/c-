using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模拟移动电脑硬盘_U盘_MP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //用多态实现，移动硬盘，U盘，MP3，插入电脑上面直接读取数据。

            //首先由移动硬盘，U盘，MP3可知是移动存储
            //来构建父类,
            //而电脑只需要写一个方法来读取到父类，通过多态的方法，可以达到使用子类函数的效果
            YIDongCunChu yd = new YiDongYingPan();
            DianNao dn = new DianNao(yd);
            dn.CPUread();
            dn.CPUwrite();
            Console.ReadKey();
        }
    }
}
