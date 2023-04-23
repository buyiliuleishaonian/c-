using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 画一条直线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //首先创建画直线的对象,因为graphics不能实例化，
            //所有将这个窗体作为它的画纸
            Graphics g = this.CreateGraphics();
            //创建画笔，随便确定颜色
            Pen pen = new Pen(Brushes.Black);
            //画一条直线需要两个点
            Point n1 = new Point(200,200);
            Point n2 = new Point(350,350);
            //调用画一条直线的方法
            g.DrawLine(pen,n1,n2);
        }
        /// <summary>
        /// 当我们拖动窗体时，窗体会发生改变，所以要重新绘制直线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         int i=0;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            i++;
            label1.Text = i.ToString();
            //重新绘制，还是需要画直线的对象，画纸，笔，颜色
            //首先创建画直线的对象,因为graphics不能实例化，
            //所有将这个窗体作为它的画纸
            Graphics g = this.CreateGraphics();
            //创建画笔，随便确定颜色
            Pen pen = new Pen(Brushes.Black);
            //画一条直线需要两个点
            Point n1 = new Point(200, 200);
            Point n2 = new Point(350, 350);
            //调用画一条直线的方法
            g.DrawLine(pen, n1, n2);
        }
        /// <summary>
        /// 画矩形
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Graphics juxing = this.CreateGraphics();
            Pen p1 = new Pen(Brushes.Red);
            Size s1 = new Size(200, 200);
            Rectangle re = new Rectangle(new Point(80,80),s1);
            juxing.DrawRectangle(p1,re);
        }
        /// <summary>
        /// 画一个文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Graphics text = this.CreateGraphics();
            text.DrawString("文憔悴最帅",new Font ("宋体",20,FontStyle.Underline),Brushes.Black,new Point(500,500));
        }
    }
}
