using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace directory类
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 将textbox.text的内容传送给webbrowser，进去
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //首先收集网站
            string name = textBox1.Text;
            //因为webbrowser.uri只接受隐式string
            //所以我们创建uri对象
            Uri url = new Uri("http://"+name);
            webBrowser1.Url = url;
        }
    }
}
