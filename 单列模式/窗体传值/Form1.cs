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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击创建窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //两个窗体之间要是想要互通其值，可以通过另一个窗体的构造函数，调用构造函数

            Form2 frm2 = new Form2(ShowMsg);
            frm2.Show();
        }
        public void ShowMsg(string s)
        {
            label1.Text = s;
        }
    }
}
