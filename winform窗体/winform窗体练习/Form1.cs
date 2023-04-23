using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform窗体练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 注册事件，点击之后显示文本，关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("万家灯火，大家都是爱你的");
            this.Close();//清屏，关闭窗体
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 只要鼠标移入到，控件里面，控件就切换位置
        /// 就需要随机生成位置给控件
        /// 控件最大的活动空间：是窗体的最大坐标值减去控件的最大坐标值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            //得到控件可以活动的最大空间。
            int x = this.ClientSize.Width - button2.Width;
            int y = this.ClientSize.Height - button2.Height;
            Random number = new Random();
            button2.Location = new Point(number.Next(0,x+1),number.Next(0,y+1));
        }
    }
}
