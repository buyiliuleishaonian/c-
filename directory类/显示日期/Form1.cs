using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 显示日期
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            for (int i = year; i >=1949; i--)
            {
                comboBox1.Items.Add(i+"年");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //首先需要判断，combobox1.text不为空
            if (comboBox1.Text!=" ")
            {
                for (int i = 1; i <=12; i++)
                {
                    comboBox2.Items.Add(i+"月");
                }
            }
        }
    }
}
