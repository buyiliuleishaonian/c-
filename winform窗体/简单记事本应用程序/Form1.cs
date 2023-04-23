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

namespace 简单记事本应用程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 启动窗体时，将某些组件隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //将计事文本隐藏，将文本的自动换行取消，将另外两个组件隐藏
            textBox1.Visible = false;
            textBox1.WordWrap = false;
            zidonghuanhang.Visible = false;
            baocun.Visible = false;
            textnaem.Focus();
        }
        /// <summary>
        /// 点击登入，判断输入的密码和用户名是否正确
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            //收集文本框内输入的密码和用户名
            string userName = textnaem.Text;
            string password = textpass.Text;
            if (userName == "admin" && password == "admin")
            {
                textBox1.Visible = true;
                textBox1.WordWrap = false;
                zidonghuanhang.Visible = true;
                baocun.Visible = true;

                btnname.Visible = false;
                btnpass.Visible = false;
                btngo.Visible = false;
                btnstart.Visible = false;
                textnaem.Visible = false;
                textpass.Visible = false;
                MessageBox.Show("登入成功");
            }
            else //如果登入失败，将密码和用户名的文本框全部清空
            {
                //清空密码
                //textnaem.Text = null;
                //textpass.Text = null;
                textnaem.Clear();
                textpass.Clear();
                textnaem.Focus();//设置为输入的焦点
                MessageBox.Show("登入失败");
            }
        }
        /// <summary>
        /// 点击重置，不管密码和用户名里面的用本框写的啥，都清楚
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnstart_Click(object sender, EventArgs e)
        {
            textnaem.Clear();
            textpass.Clear();
            textnaem.Focus();
        }
        /// <summary>
        /// 点击自动换行，开启自动换行，或者关闭自动换行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zidonghuanhang_Click(object sender, EventArgs e)
        {
            if (zidonghuanhang.Text == "自动换行")
            {
                textBox1.WordWrap = true;
                zidonghuanhang.Text = "取消自动换行";
            }
            else if (zidonghuanhang.Text=="取消自动换行")
            {
                zidonghuanhang.Text = "自动换行";
                textBox1.WordWrap = false;
            }
        }
        /// <summary>
        /// 在一个一个指定的路径创建文件保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void baocun_Click(object sender, EventArgs e)
        {
            using (FileStream writefile=new FileStream(@"D:\桌面\new.text", FileMode.OpenOrCreate,FileAccess.Write))
            {
                //将文本里面的前后的空白删除
                string txt = textBox1.Text.Trim();
                byte[] buffer = Encoding.Default.GetBytes(txt);
                writefile.Write(buffer,0,buffer.Length);
                MessageBox.Show("保存成功");
            }
        }
    }
}
