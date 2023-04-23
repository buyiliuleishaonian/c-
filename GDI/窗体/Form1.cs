using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog n1 = new OpenFileDialog();
            n1.Title = "打开文件";
            n1.InitialDirectory = @"D:\桌面";
            n1.Filter = "所有文件|*.*";
            n1.ShowDialog();

        }
        /// <summary>
        /// 新建一个窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.MdiParent = this;
            x.Show();

        }
    }
}
