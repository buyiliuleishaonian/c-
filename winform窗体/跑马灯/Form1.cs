using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 跑马灯
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 每隔一段时间，就执行一次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //每隔0.1秒
            //MessageBox.Show("电脑中病毒啦，关不掉啦");
            //每次将第一个字符串放到最后
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0,1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 显示当前时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            //这是需要当一秒之后再执行这个程序
            string time = DateTime.Now.ToString();
            labtime.Text = time;   
        }
        /// <summary>
        /// 当启动窗体时，执行的程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString();
            labtime.Text = time;
        }
        /// <summary>
        /// 当到达某个时间之后，就开始播放音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer3_Tick(object sender, EventArgs e)
        {
            DateTime dt=DateTime.Now;
            if (dt.Hour==21&&dt.Minute==3&&dt.Second==0)
            {
                //播放视频的对象
                SoundPlayer sp=new SoundPlayer();
                sp.SoundLocation = @"F:\wallhaven壁纸下载地\今天吃的很饱 天气晴 你呢.wav";
                sp.Play();
                MessageBox.Show("播放音乐");
            }
        }
    }
}
