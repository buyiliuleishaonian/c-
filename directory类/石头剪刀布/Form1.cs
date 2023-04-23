using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 石头剪刀布
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 给玩家输入出拳
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            NewMethod(btnshitou.Text.ToString());
        }
        /// <summary>
        /// 将每次点击玩家的出拳，电脑出拳，裁判判断，设置为方法。
        /// </summary>
        private void NewMethod(string name)
        {
            //首先得到我们给定的出拳
            labelnumber.Text = name;
            //调用玩家的方法,并且得到给出拳对应的数字。
            Player player = new Player();
            int playernums = player.Playernumber(name);
            //之后就是电脑得到数字
            Computer com = new Computer();
            int comnums = com.Computernumber();
            labernumber1.Text = com.Name;
            //最后开始裁判判断
            Jieguo jie = Caipan.Caipanout(playernums, comnums);
            label6.Text = jie.ToString();
        }
        /// <summary>
        /// 给玩家出剪刀
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnjiandao_Click(object sender, EventArgs e)
        {
            NewMethod(btnjiandao.Text.ToString());
        }
        /// <summary>
        /// 给玩家出布
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndao_Click(object sender, EventArgs e)
        {
            NewMethod(btnbu.Text.ToString()) ;
        }
    }
}
