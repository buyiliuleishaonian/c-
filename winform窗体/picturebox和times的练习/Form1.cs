using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picturebox和times的练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //获取图片所在的地址
        string[] path = Directory.GetFiles(@"F:\wallhaven壁纸下载地\壁纸");
        Random number = new Random();
        
        /// <summary>
        /// 当窗体出现，就执行程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(path[number.Next(0,path.Length)]);
            pictureBox2.Image = Image.FromFile(path[number.Next(0, path.Length)]);
            pictureBox3.Image = Image.FromFile(path[number.Next(0, path.Length)]);
            pictureBox4.Image = Image.FromFile(path[number.Next(0, path.Length)]);
            pictureBox5.Image = Image.FromFile(path[number.Next(0, path.Length)]);
            pictureBox6.Image = Image.FromFile(path[number.Next(0, path.Length)]);
            SoundPlayer muisc = new SoundPlayer();
            muisc.SoundLocation= @"D:\桌面\1.wav";
            muisc.Play();
        }
        /// <summary>
        /// 每隔一秒就给图框里面的照片换了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(path[number.Next(0, path.Length)]);
            pictureBox2.Image = Image.FromFile(path[number.Next(0, path.Length)]);
            pictureBox3.Image = Image.FromFile(path[number.Next(0, path.Length)]);
            pictureBox4.Image = Image.FromFile(path[number.Next(0, path.Length)]);
            pictureBox5.Image = Image.FromFile(path[number.Next(0, path.Length)]);
            pictureBox6.Image = Image.FromFile(path[number.Next(0, path.Length)]);
        }
    }
}
