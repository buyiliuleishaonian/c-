using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace socket通信
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
        /// <summary>
        /// 点击开始监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnstart_Click(object sender, EventArgs e)
        {
            try
            {
                //创建ip地址和端口号的对象，我们一般可以在控制台通过ipconfig得到本机得局域网的ip地址
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
            { }
            
        }
        /// <summary>
        /// 表现开始监听
        /// </summary>
        /// <param name="str"></param>
        public void TestShow(string str)
        {
            //append追加，可以保留原来的值
            textlog.AppendText(str + "\r\n");
        }
        /// <summary>
        /// 接受客户端的socket，建在一个方法里面，用线程来调用
        /// </summary>
        public void Test()
        {
            try
            {
                //循环等待客户端连接，并且接受客户端信息
                while (true)
                {
                    //负责监听的socket，来接受客户端的连接
                    //当不知道本机的局域网地址，可以在控制台输入ipconfig读取出本机局域网的ip地址
                    Socket socketSend = socketWatch.Accept();
                    //获取客户端的ip地址和端口号,负责连接的socket对象调用.remoteEndPoint();
                    TestShow(socketSend.RemoteEndPoint.ToString());
                    //再创建一个新的线程来调用接受信息的方法
                    Thread thr = new Thread(Receive);
                    thr.IsBackground = true;
                    thr.Start(socketSend);
                }
            }
            catch { }
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
        /// <summary>
        /// 当关闭前台线程，结束所有的程序的时候，要判断后台线程是否结束啦
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (thr != null)
            {
                //终止线程
                thr.Abort();
            }
        }
        /// <summary>
        /// 接受客户端发送过来的信息
        /// </summary>
        public void Receive(object o)
        {

            Socket socketsend = o as Socket;
            while (true)
            {
                try
                {
                    //首先接受信息必须是byte类型
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    //实际转换的字节
                    int number = socketsend.Receive(buffer);
                    if (number == 0)
                    {
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, number);
                    //将输入的字符转到textbox.text中
                    TestShow(socketsend.RemoteEndPoint + ":" + str);
                }
                catch
                { }
            }
        }
    }
}
