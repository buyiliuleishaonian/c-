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
using System.Xml.Serialization;

namespace 播放器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            muiscplayer.Ctlcontrols.play();
        }
        /// <summary>
        /// 停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            muiscplayer.Ctlcontrols.stop();
        }
        /// <summary>
        /// 暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            muiscplayer.Ctlcontrols.pause();
        }

        /// <summary>
        /// 当程序启动时，将播放器默认播放关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //当程序加载的时候，取消播放器的自动播放功能
            muiscplayer.settings.autoStart = false;
            // muiscplayer.URL = @"F:\CloudMusic\正歌 - 酒是穿肠毒药.mp3";
            label1.Image = Image.FromFile("放音.png");
            label1.Tag = "1";
        }

        /// <summary>
        /// 播放音乐或暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        bool b = true;
        private void btnplayerorpuase_Click(object sender, EventArgs e)
        {
            if (btnplayerorpuase.Text == "播放")
            {
                if (b)
                {
                    //选择好，音乐之后想要选择，播放按钮播放
                    muiscplayer.URL = listpath[listBox1.SelectedIndex];
                }
                muiscplayer.Ctlcontrols.play();
                btnplayerorpuase.Text = "暂停";
                //在播放的时候，需要先得到播放文件的文件
                lab3.Text = null;
                IsExisLrc(listpath[listBox1.SelectedIndex]);
            }
            else if (btnplayerorpuase.Text == "暂停")
            {
                muiscplayer.Ctlcontrols.pause();
                btnplayerorpuase.Text = "播放";
                b = false;
            }
        }
        /// <summary>
        /// 停止音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnstop_Click(object sender, EventArgs e)
        {
            muiscplayer.Ctlcontrols.stop();
        }

        List<string> listpath = new List<string>();
        /// <summary>
        /// 打开文件夹，选择音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndirectory_Click(object sender, EventArgs e)
        {
            //创建打开文件的对象
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.InitialDirectory = @"F:\CloudMusic";
            ofg.Filter = "mp3文件|*.mp3|视频文件|*.mp4|所有文件|*.*";
            ofg.Title = "选择音乐文件";
            ofg.Multiselect = true;
            ofg.ShowDialog();
            //将选取的文件，放在listbox中
            string[] filename = ofg.FileNames;
            for (int i = 0; i < filename.Length; i++)
            {
                listpath.Add(filename[i]);
            }
            for (int i = 0; i < filename.Length; i++)
            {
                //将文件名和扩展名，放在listbox中
                listBox1.Items.Add(Path.GetFileName(filename[i]));
            }
        }

        /// <summary>
        /// 双击时，播放对应的音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //可能还没有选择音乐文件，我们就已经双击listbox控件
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("请选择音乐文件");
                return;
            }
            try
            {
                //这里需要得到全路径
                muiscplayer.URL = listpath[listBox1.SelectedIndex];
                muiscplayer.Ctlcontrols.play();
                btnplayerorpuase.Text = "暂停";
                lab3.Text = null;
                IsExisLrc(listpath[listBox1.SelectedIndex]);
            }
            catch
            { }

        }

        /// <summary>
        /// 选择下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnshang_Click(object sender, EventArgs e)
        {
            //首先需要得到现在的下标
            int number = listBox1.SelectedIndex;
            //将本来的蓝标删除,因为listbox控件将其改为了可以多选
            listBox1.SelectedItems.Clear();
            number++;
            if (number == listpath.Count)
            {
                number = 0;
            }
            muiscplayer.URL = listpath[number];
            //将下一曲设置为蓝标
            listBox1.SelectedIndex = number;
            muiscplayer.Ctlcontrols.play();
        }

        /// <summary>
        /// 上一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnxia_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.SelectedItems.Clear();
            index--;
            if (index < 0)
            {
                index = listpath.Count - 1;
            }
            muiscplayer.URL = listpath[index];
            listBox1.SelectedIndex = index;
            muiscplayer.Ctlcontrols.play();
        }

        /// <summary>
        /// 右击菜单，点击删除之后，删除listbox中的选中项
        /// 也需要将list<>集合中的全路径的位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //先通过我们listbox.selectedindex,得到每个对应的下标
            //删除集合，之后在删除listbox中的items，
            //要不然删除listbox，之后，我们无法删除对应的集合
            int count = listBox1.SelectedIndices.Count;//这里是得到当前所选择项的索引
                                                       // int count=listBox1.SelectedItems.Count;//这里是得到当前所选择的项
            for (int i = 0; i < count; i++)
            {
                listpath.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        /// <summary>
        /// 点击之后放音，静音
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            //通过tag来标记啊
            if (label1.Tag.ToString() == "1")
            {
                label1.Tag = "2";
                label1.Image = Image.FromFile("静音.png");
                //静音
                muiscplayer.settings.mute = true;
            }
            else if (label1.Tag.ToString() == "2")
            {
                //放音
                muiscplayer.settings.mute = false;
                label1.Tag = "1";
                label1.Image = Image.FromFile("放音.png");
            }
        }

        /// <summary>
        /// 单击listbox，更改文件音乐之后
        /// 判断是否更改了音乐，更改了就重新播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (muiscplayer.URL == listpath[listBox1.SelectedIndex])
                {
                    if (btnplayerorpuase.Text == "播放")
                    {
                        btnplayerorpuase.Text = "暂停";
                        muiscplayer.Ctlcontrols.play();
                        IsExisLrc(listpath[listBox1.SelectedIndex]);
                    }
                    else if (btnplayerorpuase.Text == "暂停")
                    {
                        return;
                    }
                }
                else
                {
                    muiscplayer.URL = listpath[listBox1.SelectedIndex];
                    btnplayerorpuase.Text = "播放";
                }
            }
            catch { }
        }

        /// <summary>
        /// 当播放完成之后，直接播放下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (muiscplayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                label2.Text = muiscplayer.currentMedia.duration.ToString() + "\r\n" +
                muiscplayer.currentMedia.durationString + "\r\n" + muiscplayer.Ctlcontrols.currentPosition.ToString() +
                "\r\n" + muiscplayer.Ctlcontrols.currentPositionString;
                //因为分钟表示的无法，类型不同无法转换。
                double number1 = Convert.ToDouble(muiscplayer.currentMedia.duration.ToString());
                double number2 = Convert.ToDouble(muiscplayer.Ctlcontrols.currentPosition.ToString());
                if (number1 <= number2 + 1)
                {
                    //首先需要得到现在的下标
                    int number = listBox1.SelectedIndex;
                    //将本来的蓝标删除,因为listbox控件将其改为了可以多选
                    listBox1.SelectedItems.Clear();
                    number++;
                    if (number == listpath.Count)
                    {
                        number = 0;
                    }
                    muiscplayer.URL = listpath[number];
                    //将下一曲设置为蓝标
                    listBox1.SelectedIndex = number;
                    muiscplayer.Ctlcontrols.play();
                    lab3.Text = null;
                    IsExisLrc(listpath[listBox1.SelectedIndex]);
                }
            }
        }


        //开始做歌词
        /// <summary>
        /// 读取歌词文件
        /// </summary>
        /// <param name="filepath"></param>
        public void IsExisLrc(string filepath)
        {
            //需要先判断歌词文件是否存在
            string lrc = filepath + ".lrc";
            if (File.Exists(lrc))
            {
                //第二步读取歌词,因为需要一行行读取，所以不能使用filestream
                string[] textTime = File.ReadAllLines(lrc);
                //第三步格式化歌词，就是将歌词和歌词时间，分别读取出来
                FormatLrc(textTime);
            }
            else
            {
                lab3.Text = "-----歌词未找到-----";
                return;
            }
        }

        //用来存储歌词时间
        List<double> listTime = new List<double>();
        //用来存储歌词
        List<string> listLrcText = new List<string>();
        /// <summary>
        /// 将歌词文件读取出来的string[]集合，读取出来时间和歌词
        /// </summary>
        /// <param name="lrcText">string[]集合</param>
        public void FormatLrc(string[] lrcText)
        {
            for (int i = 0; i < lrcText.Length; i++)
            {
                //需要将其时间和歌词分割开来,[00:25.972]忧伤的夜让人心碎
                string[] textTime = lrcText[i].Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                //分为00：25.297和忧伤的夜让人心碎
                //之后将其时间和歌词，分别存储到对应的list集合
                string[] time = textTime[0].Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                //分为00，25.297
                double num = Convert.ToDouble(time[0]) * 60 + Convert.ToDouble(time[1]);
                listTime.Add(num);
                listLrcText.Add(textTime[1]);
            }
        }

        /// <summary>
        /// 每一秒，播放歌词
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int x = 0; x< listTime.Count; x++)
            {
                if (muiscplayer.Ctlcontrols.currentPosition >= listTime[x] && muiscplayer.Ctlcontrols.currentPosition < listTime[x+ 1])
                {
                    lab3.Text = listLrcText[x];
                }
            }
        }
    }
}
