using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_线程执行带参数的方法
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool x = false;
        /// <summary>
        /// 按下就开始启动，或者停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (x==false)
            {
                x = true;
                button1.Text = "停止";
                Thread th = new Thread(Test);
                //将创建的线程变为后台线程
                th.IsBackground = false;
                th.Start();
            }
            else
            {
                button1.Text = "开始";
                x = false;
            }
        }
        public void Test()
        {
            Random ran = new Random();
            while (x)
            {
                label1.Text = ran.Next(0,10).ToString();
                label2.Text = ran.Next(0, 10).ToString();
                label3.Text = ran.Next(0,10).ToString();
            }
        }
        /// <summary>
        /// 当启动窗体的时候，不检查所创建的线程跨线程调用控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //不检查跨线程调用控件。
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
