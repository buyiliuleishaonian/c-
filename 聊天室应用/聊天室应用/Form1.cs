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

namespace 聊天室应用
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //这是来调用socket负责监听的全局
        Socket socketwatch;
        //创建键值对集合，来确定ip和端口号对应不同客户端的通信的socket
        Dictionary<string,Socket> dicsocket=new Dictionary<string, Socket> ();
        /// <summary>
        /// 因为需要创建线程，调用主窗体的控件
        /// 需要取消对线程跨线程调用的线程取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        /// <summary>
        /// 点击连接，必须于客户端建立连接
        /// 首先创建socket负责监听，之后创建负责通信的socket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnreceive_Click(object sender, EventArgs e)
        {
            //创建负责监视的socket
            socketwatch = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            //之后判定ip和端口号将本电脑的ip提供给socket
            IPAddress ip = IPAddress.Any;
            IPEndPoint ippoint = new IPEndPoint(ip,Convert.ToInt32(textPoint.Text));
            //让负责监听的socket来绑定ip和端口号
            socketwatch.Bind(ippoint);
            SHow("连接成功");
            //之后确定最多可同时有几个客户端可以连接
            socketwatch.Listen(10);
            //创建好负责监听的socket之后，需要创建扶着接收的socket
            //需要创建thread线程来调用接收
            Thread thrreceive = new Thread(Receive);
            thrreceive.IsBackground = true;
            thrreceive.Start();
        }
        /// <summary>
        /// 创建接收的socket
        /// </summary>
        public void Receive()
        {
            //需要循环连接
            while (true)
            {
                try
                {
                    //创建接收好的socket.将每次连入的客户端ip和端口号读取出来
                    Socket socketreceive = socketwatch.Accept();
                    //将连接过来的客户端的ip，放入combobox的下拉款选项当中
                    cmbip.Items.Add(socketreceive.RemoteEndPoint.ToString());
                    dicsocket.Add(socketreceive.RemoteEndPoint.ToString(), socketreceive);
                    //将其展示在textmsg.text中
                    SHow(socketreceive.RemoteEndPoint.ToString());
                    //创建字节来接受数据
                    //创建一个线程来调用
                    Thread thr = new Thread(Receivesocket);
                    thr.IsBackground = true;
                    thr.Start(socketreceive);
                }
                catch
                { }
            }
        }
        /// <summary>
        /// 在textlog.text展示通信结果和通信信息
        /// </summary>
        /// <param name="str"></param>
        public void SHow(string str)
        {
            textmsg.AppendText(str+"\r\n");
        }
        /// <summary>
        /// 用来通信的socket，来接收数据
        /// 需要判断数据类型
        /// </summary>
        /// <param name="o"></param>
        public void Receivesocket(object o)
        {
            Socket socketr = o as Socket;
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    int number = socketr.Receive(buffer);
                    if (number == 0)
                    {
                        break;
                    }
                    if (buffer[0] == 0)
                    {
                        string str = Encoding.UTF8.GetString(buffer, 1, number);
                        SHow(socketr.RemoteEndPoint.ToString() + ":" + str);
                    }
                    else if (buffer[0] == 1)
                    {
                        SaveFileDialog sfile = new SaveFileDialog();
                        sfile.Title = "保存到";
                        sfile.InitialDirectory = @"D:\桌面";
                        sfile.Filter = "所有文件|*.*";
                        sfile.ShowDialog(this);
                        string path = sfile.FileName;
                        if (path==null)
                        {
                            return;
                        }
                        using (FileStream writefile = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            writefile.Write(buffer, 1, buffer.Length);
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
        /// <summary>
        /// 让主窗体震动
        /// </summary>
        public void ZD()
        {
            for (int i = 0; i < 500; i++)
            {
                this.Location = new Point(200, 200);
                this.Location = new Point(280, 280);
            }
        }
        /// <summary>
        /// 点击发送文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsend_Click(object sender, EventArgs e)
        {
            string str = textlog.Text;
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            List<byte> list = new List<byte>();
            list.Add(0);
            list.AddRange(buffer);
            byte[] newbuffer = list.ToArray();
            dicsocket[cmbip.Text.ToString()].Send(newbuffer);
        }
        /// <summary>
        /// 选择需要发送的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fod = new OpenFileDialog();
            fod.Title = "选择需要发送的文件";
            fod.InitialDirectory = @"D:\桌面";
            fod.Filter = "所有文件|*.*";
            fod.Multiselect = true;
            fod.ShowDialog();
            string path = fod.FileName;
            textfile.Text = path;
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
            dicsocket[cmbip.Text.ToString()].Send(buffer);
        }
        /// <summary>
        /// 发送选择好的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textpath_Click(object sender, EventArgs e)
        {
            string str = textfile.Text;
            using (FileStream readfile=new FileStream(str,FileMode.OpenOrCreate,FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int number = readfile.Read(buffer,0,buffer.Length);
                List<byte> list = new List<byte>();
                list.Add(1);
                list.AddRange(buffer);
                byte[] newbuffer = list.ToArray();
                dicsocket[cmbip.Text.ToString()].Send(newbuffer,0,number+1,SocketFlags.None);
            }
        }
    }
}
