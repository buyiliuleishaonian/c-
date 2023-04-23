using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图片的上一张和下一张
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] path = Directory.GetFiles(@"F:\wallhaven壁纸下载地");
        int nums=0;
        /// <summary>
        /// 当打开窗体，就启动程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //启动窗体，就读取文件夹中的文件，之后随便展示一张图片
            Random number = new Random();
            number.Next(0, path.Length);
            pictureBox1.Image = Image.FromFile(path[number.Next(0,path.Length)]);
        }
        /// <summary>
        /// 点击按钮则会显示，下一张图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            nums++;
            if (nums==path.Length)
            {
                nums = 0;
            }
            pictureBox1.Image = Image.FromFile(path[nums]);
        }
        /// <summary>
        /// 点击显示上一张
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            nums--;
            if (nums<0)
            {
                nums = path.Length - 1;
            }
            pictureBox1.Image = Image.FromFile(path[nums]);
        }
    }
}
