using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 验证码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void YanZhenMa()
        {
            //需要随机生成验证码
            Random r = new Random();
            string str = null;
            for (int i = 0; i < 5; i++)
            {
                str += r.Next(0, 10).ToString();
            }
            //需要创建位图，也就是验证码图片的大小
            Bitmap btp = new Bitmap(150, 40);
            //创建画验证码的对象,这个GDI的对象，所要的画纸，就是这个位图
            Graphics gs = Graphics.FromImage(btp);
            //需要画出一个文本，显示在位图上
            for (int i = 0; i < 5; i++)
            {
                //画的文本，需要字体，颜色，坐标，还有验证码
                Point p = new Point(i * 20, 10);
                Color[] col = { Color.Red, Color.Green, Color.Yellow, Color.Blue, Color.Black };
                string[] pont = { "宋体", "隶书", "仿宋", "微软雅黑", "黑体" };
                gs.DrawString(str[i].ToString(), new Font(pont[r.Next(0, 5)], 15, FontStyle.Bold), new SolidBrush(col[r.Next(0, 5)]), p);
            }
            //之后画一些直线
            for (int i = 0; i < 20; i++)
            {
                Pen pen = new Pen(Brushes.Black);
                //将直线的坐标都限制在位图当中
                Point p1 = new Point(r.Next(btp.Width), r.Next(btp.Height));
                Point p2 = new Point(r.Next(btp.Width), r.Next(btp.Height));
                gs.DrawLine(pen, p1, p2);
            }
            //之后则是一些像素点
            for (int i = 0; i < 400; i++)
            {
                //也需要坐标，和颜色
                Point p = new Point(r.Next(btp.Width), r.Next(0, btp.Height));
                btp.SetPixel(p.X, p.Y, Color.Black);
            }
            //将图片镶进去picturebox1.image中
            pictureBox1.Image = btp;
        }
        /// <summary>
        /// 先随机生成一张验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            YanZhenMa();
        }
        /// <summary>
        /// 点击才切换验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            YanZhenMa();
        }
    }
}
