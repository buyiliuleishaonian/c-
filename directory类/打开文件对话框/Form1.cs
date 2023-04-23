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

namespace 打开文件对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击之后，选择文件打开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //首先要创建打开文件的类的对象
            OpenFileDialog ofd = new OpenFileDialog();
            //设置打开文件的，窗体名
            ofd.Title = "文憔悴的所有文件";
            //设置对话框的可以多选文件。
            ofd.Multiselect = true;
            //设置对话框的初始目录
            ofd.InitialDirectory = @"F:\edge下载地";
            //设置对话框可以打开文件的类型
            ofd.Filter = "文本文件|*.txt|媒体文件|*.jpg|所有文件|*.*";
            //展示对话框
            ofd.ShowDialog();

            //将我们打开的文本文件在textbox上打开。
            string path = ofd.FileName;
            if (path != " ")
            {
                using (FileStream fls = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    //读取到的是文件的字节
                    byte[] buffer = new byte[5 * 1024 * 1024];
                    int number = fls.Read(buffer, 0, buffer.Length);
                    textBox1.Text = Encoding.Default.GetString(buffer, 0, number);
                }
            }
            else
            {
                return;
            }
                
        }
    }
}
