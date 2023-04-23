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

namespace Socket网络编辑简介
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //创建一个监听的socket
        Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //创建一个线程thread
        Thread thr;
        //创建一个dictionary集合，来存储ip地址和socket
        Dictionary<string,Socket> dicsocket=new Dictionary<string,Socket>();  
        /// <summary>
        /// 点击开始监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnstart_Click(object sender, EventArgs e)
        {
            //在接受和通信的地方就容易出现异常，就需要try catch
            try
            {
                //创建ip地址和端口号的对象
                IPAddress ipname = IPAddress.Any;//会拿到我的ip地址，IP地址改变，这里也改变// IPAddress.Parse(textserver.Text);
                                                 //这里创建的开端口号，也需要将ip地址给入端口号
                                                 //我这里是给定的端口号。
                IPEndPoint ippoint = new IPEndPoint(ipname, Convert.ToInt32(textport.Text));
                //让负责监听的socket绑定ip和端口号
                socketWatch.Bind(ippoint);
                TestShow("监听成功");
                //设置监听队列,在某一个时间点，可以连入服务端的最大客户端的数量
                socketWatch.Listen(10);
                //用一个线程来调用接受客户端的方法
                thr = new Thread(Test);
                //首先需要将这个前台线程变成后台线程
                thr.IsBackground = true;
                //之后告诉cpu，可以启动该线程啦
                thr.Start();
            }
            catch
            { 
            }
        }
        /// <summary>
        /// 表现开始监听
        /// </summary>
        /// <param name="str"></param>
        public void TestShow(string str)
        {
            //append追加
            textlog.AppendText(str + "\r\n");
        }
        Socket socketSend;
        /// <summary>
        /// 接受客户端的socket，建在一个方法里面，用线程来调用
        /// </summary>
        public void Test()
        {
            try
            {
                //服务器端，可能有多个客户端连接过来。
                while (true)
                {
                    //负责监听的socket，来接受客户端的连接
                    //当不知道本机的局域网地址，可以在控制台输入ipconfig读取出本机局域网的ip地址
                    socketSend = socketWatch.Accept();
                    //将每次连接服务器的客户端的ip和端口号，存入dictionary集合
                    dicsocket.Add(socketSend.RemoteEndPoint.ToString(),socketSend);
                    //之后将每个客户端的ip和端口号放入下拉框
                    cboUsers.Items.Add(socketSend.RemoteEndPoint.ToString());
                    //获取客户端的ip地址和端口号,负责连接的socket对象调用.remoteEndPoint();
                    TestShow(socketSend.RemoteEndPoint.ToString());
                    //在创建一个线程，来接受客户端的信息
                    Thread thr = new Thread(Receive);
                    thr.IsBackground = true;
                    thr.Start(socketSend);
                }
            }
            catch
            { }
        }
        /// <summary>
        /// 当启动窗体时，要明白不可以因为不可以跨线程调用控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //所以不可以检查该线程跨线程调用的窗体
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        /// 来接受客户端传输过来的信息
        /// </summary>
        /// <param name="o"></param>
        public void Receive(object o)
        {
            //在网络中出现异常
            Socket socketSend = o as Socket;
            while (true)
            {
                try
                {
                    //客户端连接成功之后，服务器接受客户端发送的信息
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    //实际接受的有效字节
                    int number = socketSend.Receive(buffer);
                    //判断是否还有有效字节，也就是判断是否还有发送的信息
                    if (number != 0)
                    {
                        string str = Encoding.UTF8.GetString(buffer, 0, number);
                        TestShow(socketSend.RemoteEndPoint.ToString() + ":" + str);
                    }
                    else
                    {
                        //要是为0直接跳出循环
                        break;
                    }
                }
                catch
                {

                }
            }
        }
        /// <summary>
        /// 给客户端发送信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            //首先将要发的字符串转为字节数组
            string str = textMsg.Text;
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            //给文本文件，的buffer最开头加上0，用以区别
            List<byte> list = new List<byte>();
            list.Add(0);
            list.AddRange(buffer);
            byte[] newbuffer = list.ToArray();
            //负责通信的socket，来发送
            //需要选择发送客户端的socket
            string ip = cboUsers.SelectedItem.ToString();
            dicsocket[ip].Send(newbuffer);
        }
        /// <summary>
        /// 点击x选择需要发送文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog olg = new OpenFileDialog();
            olg.Title = "选择需要发送的文件";
            olg.InitialDirectory = @"D:\桌面";
            olg.Multiselect = true;
            olg.Filter = "所有文件|*.*";
            olg.ShowDialog();
            string pathname=olg.FileName;
            textpath.Text = pathname;
        }
        /// <summary>
        /// 将我们选择的文件进行发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string pathname = textpath.Text;
            using (FileStream readfile=new FileStream(pathname,FileMode.OpenOrCreate,FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int number = readfile.Read(buffer, 0, buffer.Length) ;
                List<byte> list = new List<byte>();
                list.Add(1);
                list.AddRange(buffer);
                byte[] newbuffer = list.ToArray();
                //对于所传的文件需要从位开始传，使客户端接收，判断是否是文本文件
                dicsocket[cboUsers.SelectedItem.ToString()].Send(newbuffer,0,number+1,SocketFlags.None);
            }
        }
        /// <summary>
        /// 给客户端发送一个震动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte [1];
            buffer[0] = 2;
            dicsocket[cboUsers.SelectedItem.ToString()].Send(buffer);
        }
    }
}
