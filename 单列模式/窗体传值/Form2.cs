using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体传值
{
    //创建一个委托，来得到另一个窗体的函数
    public delegate void DelTest(string s);
    public partial class Form2 : Form
    {
        //创建一个私有字段
        private static Form2 window=null;      
        //创一个类型为委托的字段
        public DelTest _del;
        public   Form2(DelTest del)
        {
            this._del = del;
            InitializeComponent();
        }
        /// <summary>
        /// 对私有字段赋值，使之只能创建一个窗体
        /// </summary>
        /// <returns></returns>
        //public static Form2 Show1()
        //{
        //    if (window==null)
        //    {
        //        window = new Form2();
        //    }
        //    return window;
        //}
        /// <summary>
        /// 通过del委托来将窗体的值传递给另一个窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            _del(textBox1.Text);
        }
    }
}
