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

namespace Panel容器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //创建一个泛型集合将所有的打开的文件的地址，放入其中。
        List<string> list = new List<string>();
        /// <summary>
        /// 进入窗体时，将panel容器隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textBox1.WordWrap = false;
        }
        /// <summary>
        /// 打开记录显示和隐藏。将panel容器显示和隐藏。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        /// <summary>
        /// 点击时隐藏panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        /// <summary>
        /// 点击文件里面的打开，打开文件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            //打开文件的窗体名
            op.Title = "打开";
            //选择打开窗体的初始文件夹
            op.InitialDirectory = @"D:\桌面";
            //选择可以打开的文件类型
            op.Filter = "文本文件|*.txt|所有文件|*.*";
            //可以打开多个文件夹。
            op.Multiselect = true;
            //展示窗体
            op.ShowDialog();
            //将我们选择的文件的路径也拿出来
            string pathname = op.FileName;
            //将文件文件名给listbox1.items
            listBox1.Items.Add(Path.GetFileName(pathname));
            list.Add(pathname);
            if (pathname=="")
            { return; }
            //创建文件流来达到将文本文件的内容，导入textbox.text中。
            using (FileStream readfile=new FileStream(pathname,FileMode.OpenOrCreate,FileAccess.Read))
            {
                //首先需要见文本文件的数据转成字节
                byte[] buffer = new byte[1024 * 1024 * 5];
                int number =readfile.Read(buffer,0,buffer.Length);
                //将字节转成字符串
                textBox1.Text = Encoding.Default.GetString(buffer,0,number);
            }
            MessageBox.Show("打开成功");
        }
        /// <summary>
        /// 将我们写入在textbox.text保存成为一个文本文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建保存的对话框
            SaveFileDialog sl = new SaveFileDialog();
            sl.Title = "保存";
            sl.InitialDirectory = @"D:\桌面";
            sl.Filter = "文本文件|*.txt|所有文件|*.*";
            sl.ShowDialog();
            string pathname = sl.FileName;
            //将textbox.text保存为txt
            if (pathname=="")
            { return; }
            using (FileStream writefile=new FileStream(pathname,FileMode.OpenOrCreate,FileAccess.Write))
            {
                //首先也是需要将textbox.text转成字节
                byte[] buffer = Encoding.Default.GetBytes(textBox1.Text);
                //之后将其写文本文件
                writefile.Write(buffer,0,buffer.Length);
            }
            MessageBox.Show("保存成功");
        }
        /// <summary>
        /// 点击之后判断是否为自动换行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (自动换行ToolStripMenuItem.Text == "自动换行")
            {
                自动换行ToolStripMenuItem.Text = "★取消自动换行";
                textBox1.WordWrap = true;
            }
            else if (自动换行ToolStripMenuItem.Text == "★取消自动换行")
            {
                自动换行ToolStripMenuItem.Text = "自动换行";
                textBox1.WordWrap = false;
            }
        }
        /// <summary>
        /// 点击字体，对字体进行改变。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建字体的对话框对象
            FontDialog fo = new FontDialog();
            fo.ShowDialog();
            //之后将其选择的字体给textbox.font
            textBox1.Font = fo.Font;
        }
        /// <summary>
        /// 点击颜色，选择字体颜色，之后替换textbox1.color的颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog co = new ColorDialog();
            co.ShowDialog();
            textBox1.ForeColor = co.Color;
        }
           
        /// <summary>
        /// 双击listbox里面的文件名，则会调出对应的文件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string path = list[listBox1.SelectedIndex];
            using (FileStream fo=new FileStream(path,FileMode.OpenOrCreate,FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int number = fo.Read(buffer,0,buffer.Length);
                textBox1.Text = Encoding.Default.GetString(buffer,0,number);
            }
        }
        /// <summary>
        /// 选择好文件之后，隐藏panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
