using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 练习复习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //做一个全局集合，来保存，读取出来的全路径音乐
        List<string> listname = new List<string>();
        /// <summary>
        /// 点击按钮打开，文件选取文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //创建打开文件对话框的对象
            OpenFileDialog ofd = new OpenFileDialog();
            //对对话框进行设计
            ofd.Title = "打开音乐文件";
            //可以选择多个文件
            ofd.Multiselect = true;
            //设置对话框的初始页面
            ofd.InitialDirectory = @"F:\CloudMusic";
            //选择可以打开哪些文件。
            ofd.Filter = "音乐文件|*.wav|所有文件|*.*";
            //之后则是将对话框，显示出来。
            ofd.ShowDialog();
            //将我们所选择的文件，保存到listbox1中,filename,filenames一个读取一个文件，一个读取多个文件
            string[] pathmusic = ofd.FileNames;
            listname.AddRange(pathmusic);
            //将文件名一个个存入其中
            for (int i = 0; i <pathmusic.Length; i++)
            {
                listBox1.Items.Add(Path.GetFileName(pathmusic[i]));
            }
        }
        /// <summary>
        /// 选择某个音乐双击就播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //创建播放音乐的对象
        SoundPlayer sp = new SoundPlayer();
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //获取对应双击文件的索引
            sp.SoundLocation = listname[listBox1.SelectedIndex];
            //执行播放
            //sp.Play();
        }
        /// <summary>
        /// 点击上一曲，就播放正在播放的上一手的音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //首先获得正对应的索引下标
            int number = listBox1.SelectedIndex;
            //之后判断是否是最后一首
            number--;
            if (number == 0)
            {
                number = listname.Count;
            }
            listBox1.SelectedIndex = number;
            sp.SoundLocation = listname[listBox1.SelectedIndex];
            //sp.Play();
        }
        /// <summary>
        /// 点击下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            int number = listBox1.SelectedIndex;
            number++;
            if (number == listname.Count)
            {
                number = 0;
            }
            listBox1.SelectedIndex = number;
            sp.SoundLocation = listname[listBox1.SelectedIndex];
            //sp.Play();
        }
    }
}
