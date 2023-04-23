using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Socket socketsend;
        /// <summary>
        /// 点击连接就通信到服务端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //创建负责通信的socket
                socketsend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //来接上ip和端口号
                IPAddress ip = IPAddress.Parse(textip.Text);
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(textpoint.Text));
                //让socket连接上ip和端口号
                socketsend.Connect(point);
                Show(socketsend.RemoteEndPoint + ":");
                //创建thread来实现接受信息
                Thread thr = new Thread(Receive);
                thr.IsBackground = true;
                thr.Start();
            }
            catch
            { }
        }
        public void Show(string str)
        {
            textlog.AppendText(str + "\r\n");
        }
        /// <summary>
        /// 发送信息.客户端给服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string str = textmsg.Text.Trim();
            //将其转换成字节
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
            socketsend.Send(buffer);
        }
        /// <summary>
        /// 当启动窗体，不检查线程跨线程调用控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        /// <summary>
        /// 用来接受服务器发送过来的信息
        /// </summary>
        public void Receive()
        {
            //因为可能需要一直接受
            while (true)
            {
                try
                {
                    //需要字节数组来接收
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    int number = socketsend.Receive(buffer);
                    if (number == 0)
                    {
                        break;
                    }
                    //需要判断是否为文本
                    if (buffer[0] == 0)
                    {
                        //将字节转成字符串
                        string str = Encoding.UTF8.GetString(buffer, 1, number);
                        //将其展示在textmgs.text
                        textlog.Text = str;
                        Show(socketsend.RemoteEndPoint + ":" + str);
                    }
                    else if (buffer[0] == 1)
                    {
                        //如果需要对不同的文件，进行选定的话，需要可以在数组后面第二位，进行限定
                        SaveFileDialog sa = new SaveFileDialog();
                        sa.Title = "保存到";
                        sa.InitialDirectory = @"D:\桌面";
                        sa.Filter = "所有文件|*。*";
                        sa.ShowDialog(this);
                        string path = sa.FileName;
                        if (path == null)
                        {
                            return;
                        }
                        using (FileStream writefile = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            writefile.Write(buffer, 1, buffer.Length);
                        }
                        MessageBox.Show("保存成功");
                    }
                    else if (buffer[0] == 2)
                    {
                        ZD();
                    }
                }
                catch { }
            }
        }
        /// <summary>
        /// 让主窗体在两个坐标之间，来回切换
        /// </summary>
        public void ZD()
        {
            for (int i = 0; i < 500; i++)
            {
                this.Location = new Point(200, 200);
                this.Location = new Point(280, 280);
            }
        }
    }
}
