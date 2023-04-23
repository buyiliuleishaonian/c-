using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 字体和颜色对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击字体的时候，选择不同字体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fo = new FontDialog();
            fo.ShowDialog();
            textBox1.Font = fo.Font;
        }
        /// <summary>
        /// 点击1颜色，选取字体背景颜色.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog co = new ColorDialog();
            co.ShowDialog();
            textBox1.ForeColor = co.Color;
        }
    }
}
