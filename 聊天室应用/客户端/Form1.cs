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

namespace 客户端
{
    public partial class btnfile : Form
    {
        public btnfile()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 当窗体启动的时候不让检查，跨线程调用的控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnfile_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        Socket socketsend;
        /// <summary>
        /// 点击连接，连接客户端的socket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnreceive_Click(object sender, EventArgs e)
        {
             socketsend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //获取服务端的ip和端口号，这里就是需要将字符串转变成一个ipaddress的实例
            IPAddress ip = IPAddress.Parse(textip.Text);
            IPEndPoint ippoint = new IPEndPoint(ip,Convert.ToInt32(textPoint.Text));
            //这里连接到的服务端的ip和端口号
            socketsend.Connect(ippoint);
            SHow(socketsend.RemoteEndPoint.ToString());
            //在这之后，客户端给服务器发送信息
            Thread thr = new Thread(Receive);
            thr.IsBackground = true;
            thr.Start();
        }
        public void SHow(string str)
        {
            textmsg.AppendText(str+"\r\n");
        }
        /// <summary>
        /// 给服务器发送信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsend_Click(object sender, EventArgs e)
        {
            string str = textlog.Text.ToString();
            //将字符串转为字节
            byte[] buffer =Encoding.UTF8.GetBytes(str);
            List<byte> list = new List<byte>();
            //给输送过去的字节第一位用来判断是文本，还是文件，还是震动
            list.Add(0);
            list.AddRange(buffer);
            byte[] newbuffer = list.ToArray();
            socketsend.Send(newbuffer);
            MessageBox.Show("发送成功");
        }
        /// <summary>
        /// 选择一个文件发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfile = new OpenFileDialog();
            opfile.Title = "选择需要发送的文件";
            opfile.InitialDirectory = @"D:\桌面";
            opfile.Filter = "所有文件|*.*";
            opfile.Multiselect = true;
            opfile.ShowDialog();
            string str = opfile.FileName;
            textfile.Text = str;
        }
        /// <summary>
        /// 发送震动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnzd_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1];
            buffer[0] = 2;
            socketsend.Send(buffer);
        }
        /// <summary>
        /// 发送文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textpath_Click(object sender, EventArgs e)
        {
            string str = textfile.Text;
            using (FileStream readfile = new FileStream(str, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int number = readfile.Read(buffer, 0, buffer.Length);
                List<byte> list = new List<byte>();
                list.Add(1);
                list.AddRange(buffer);
                byte[] newbuffer = list.ToArray();
                socketsend.Send(newbuffer, 0, number + 1, SocketFlags.None);
            }
        }
        /// <summary>
        /// 接收客户端的数据
        /// </summary>
        public void Receive()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    int number = socketsend.Receive(buffer);
                    if (number==0)
                    {
                        break;
                    }
                    if (buffer[0] == 0)
                    {
                        string str = Encoding.UTF8.GetString(buffer, 1, number);
                        SHow(socketsend.RemoteEndPoint.ToString() + ":" + str);
                    }
                    else if (buffer[0] == 1)
                    {
                        SaveFileDialog save = new SaveFileDialog();
                        save.Title = "保存到";
                        save.InitialDirectory = @"D:\桌面";
                        save.Filter = "所有文件|*.*";
                        save.ShowDialog(this);
                        string path = save.FileName;
                        using (FileStream writefile = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            writefile.Write(buffer, 1, number);
                        }
                    }
                    else if (buffer[0]==2)
                    {
                        ZD();
                    }
                }
                catch
                { }
            }
        }
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
