using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 练习25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 当启动时，给定combox.text的选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //这样就可以显示，下标为0
            comboBox1.SelectedIndex = 0;
        }
        /// <summary>
        /// 点击=等于时，就进行计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = Convert.ToInt32(textBox1.Text);
                int n2 = Convert.ToInt32(textBox2.Text);
                switch (comboBox1.Text.ToString())
                {
                    case "+":
                        label1.Text = (n1 + n2).ToString();
                        break;
                    case "-":
                        label1.Text = (n1 - n2).ToString();
                        break;
                    case "/":
                        label1.Text = (n1 / n2).ToString();
                        break;
                    case "*":
                        label1.Text = (n1 * n2).ToString();
                        break;
                    default:
                        MessageBox.Show("请选择运算符");
                        break;
                }
            }
            catch
            {
                MessageBox.Show("请输入数字");
            }
        }
    }
}
