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

namespace listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //可以通过list集合，来将读取出来的文件名保存。
        List<string> listname = new List<string>();
        /// <summary>
        /// 当启动窗体，就让listbox，扫描一个文件夹里面的所有图片，得到文件名。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //将所有jpg的文件的全路径全部读取出来。
            string[] pathname = Directory.GetFiles(@"F:\wallhaven壁纸下载地","*.png");
            //将全路径里面的文件名读取出来。
            for (int i = 0; i <pathname.Length; i++)
            {
              string  Name = Path.GetFileName(pathname[i]);
                listBox1.Items.Add(Name);
                //将图片的全路径添加到泛型集合list中
                listname.Add(pathname[i]);
            }
        }
        /// <summary>
        /// 当双击选中的文件名时，出现对应的图片
        /// 将得到的文件名，做下标
        /// </summary>
        /// <param name="sender"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //这里list.selectedindex，就表示了我们在listbox双击
            //选中文件，在items集合中元素的下标。
            pictureBox1.Image = Image.FromFile(listname[listBox1.SelectedIndex]);
        }
    }
}
