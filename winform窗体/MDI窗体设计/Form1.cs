using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI窗体设计
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         /// <summary>
         /// 点击菜单栏中的显示子窗体，创建子窗体，并显示子窗体
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //创建子窗体对象，并显示，而且限制其范围
            Form2 fom2 = new Form2();
            fom2.MdiParent = this;
            fom2.Show();
            Form3 fom3 = new Form3();
            fom3.MdiParent = this;
            fom3.Show();
            Form4 fom4 = new Form4();
            fom4.MdiParent = this;
            fom4.Show();
        }
        /// <summary>
        /// 点击横向排列，就是将MDI主窗体中的所有子窗体排列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 横向排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        /// <summary>
        /// 纵向排列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 纵向排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical) ;
        }
    }
}
