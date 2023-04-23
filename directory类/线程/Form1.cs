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

namespace 线程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //创建一个线程对象
        Thread th;
        /// <summary>
        ///  调用进程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //让线程得到委托的方法
            th = new Thread(Test);
            //因为自己所创建的线程是前台线程，当主线程结束后，所创建的前台线程还在执行
            //所以需要将其转为后台线程
            th.IsBackground = true;
            //执行方法
            th.Start();
        }
        public  void Test()
        {
            for (int i = 0; i < 10000; i++)
            {
                textBox1.Text = i.ToString();
            }
        }
        /// <summary>
        /// 因为需要调用的控件在主线程中，自己创建的前程无法调用主线程中的控件
        /// 所以需要取消对跨线程的访问
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //当窗体启动停止对跨线程的检查取消
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        /// <summary>
        /// 当我们关闭主窗体的时候，也就是结束主线程的时候，
        /// 因为没有对跨线程的访问，所以无法将所创建线程里面的资源释放
        /// 所以需要判断是否其线程是否执行完啦
        /// 没有就终止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //当我点击窗体关闭的时候，判断线程是否为null
            if (th !=null)
            {
                th.Abort();
                //abort终止线程之后，无法重新启动
            }
        }
    }
}
