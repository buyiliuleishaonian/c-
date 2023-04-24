using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 单列模式
{
    public partial class Form2 : Form
    {
        //创建全局一个单列
        //private static Form2 winDow=null;
        //这里也可以设置为私有的一个单列
        private static Form2 winDow;
        //首先将其改变成为一个
        private Form2()
        {
            InitializeComponent();
        }
        //创建一个静态的方法来，返回一个Form2的对象
        public static Form2 WinDow
        {
            get
            {
                if (winDow == null)
                {
                    winDow = new Form2();
                }
                return winDow;
            }
        }

        //public static Form2 WinDow()
        //{
        //    //在这里创建一个对象
        //    if (winDow == null)
        //    {
        //        winDow = new Form2();
        //    }
        //    return winDow;
        //}
    }
}
