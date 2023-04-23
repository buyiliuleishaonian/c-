using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 老师或者学生登入
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 在点击登入前判断，是否选择了登入身份，并且判断密码是否正确
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btngo_Click(object sender, EventArgs e)
        {
            string name = textname.Text;
            string pass = textpass.Text;
            if (radstudent.Checked == true || radteacher.Checked == true)
            {
                if (radstudent.Checked == true && name == "student" && pass == "student")
                {
                    MessageBox.Show("登入成功");
                }
                else if (radteacher.Checked == true && name == "teacher" && pass == "teacher")
                {
                    MessageBox.Show("登入成功");
                }
                else
                {
                    //直接将文本框清空
                    textname.Clear();
                    textpass.Clear();
                    //将焦点返回到用户名输入的文本框
                    textname.Focus();
                    MessageBox.Show("登入失败\r\n请请重新输入\r\n用户名和密码");
                }
            }
            else 
            {
                MessageBox.Show("请先选择登入身份");
            }
        }
    }
}
