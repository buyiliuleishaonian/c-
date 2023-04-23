using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox下拉框显示日期
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 当窗体启动的时候，给定年份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            for (int i = year; i>=1949; i--)
            {
                comboBox1.Items.Add(i);
            }
        }
        /// <summary>
        /// 当年份确定之后，给定可以选择的月份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //先要判断combbox1.text是否为空
            //当重复选择年份的时候需要将之前的月份清空
            comboBox2.Items.Clear();
            if (comboBox1.Text!=null)
            {
                for (int i =1; i <=12; i++)
                {
                    comboBox2.Items.Add(i);
                }
            }
        }
        /// <summary>
        /// 当月份选择之后也需要将对应月份的天数给出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //首先也是将日期清空，并判断定是否有月份啦
            comboBox3.Items.Clear();
            int day = 0;
            string month = comboBox2.Text.Split(new char[] { '月'})[0];
            //因为可能还要判断年份的存在
            string year = comboBox1.Text.Split(new char[] { '年'})[0];
            int intyear = Convert.ToInt32(year);
            if (comboBox2.Text != null) 
            {
                switch (month)
                {
                    case "1":
                    case "3":
                    case "5":
                    case "7":
                    case "8":
                    case "10":
                    case "12": day = 31;
                    break;
                    case "2":
                        if ((intyear % 400 == 0) || (intyear % 4 == 0 && intyear % 100 != 0))
                        {
                            day = 29;
                        }
                        else
                        {
                            day = 28;
                        }
                        break;
                    default:
                        day = 30;
                        break;
                }
                for (int i = 1; i < day; i++)
                {
                    comboBox3.Items.Add(i);
                }
            }
        }
    }
}
