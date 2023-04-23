using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform窗体
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 当启动程序的时候，窗体就运行的程序
        /// 将创建的主窗体存在一个静态类中。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //当主窗体体启动的时候，就将创建主窗体的对象，存放在静态类中
            //这样一来全局都可以调用主窗体。
            Test.FRm1 = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //可以将sender 转换成对应控件的对象
            Button btn = (Button)sender;
            MessageBox.Show("hello word");
        }
        /// <summary>
        /// 打开窗体2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //在内存中创建窗体2的对象
            Form2 frm2 = new Form2();
            //展示这个窗体
            frm2.Show();
        }
    }
}
