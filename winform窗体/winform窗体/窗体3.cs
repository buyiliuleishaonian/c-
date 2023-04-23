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
    public partial class 窗体3 : Form
    {
        public 窗体3()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 关闭所有窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //所以要关闭主窗体
            Test.FRm1.Close();
        }
    }
}
