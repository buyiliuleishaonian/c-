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

namespace 保存对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //创建保存文件的对象
            SaveFileDialog sfl = new SaveFileDialog();
            sfl.Title = "保存到";
            sfl.InitialDirectory = @"D:\桌面";
            sfl.Filter = "文本文件|*.text|所有文件|*.*";
            sfl.ShowDialog();
            string path = sfl.FileName;
            if (path == " ")
            {
                return;
            }
            using (FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = Encoding.GetEncoding("GBK").GetBytes(textBox1.Text);
                file.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("保存成功");
        }
    }
}
