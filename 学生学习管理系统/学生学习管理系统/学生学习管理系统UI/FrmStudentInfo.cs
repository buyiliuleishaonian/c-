using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 学生学习管理系统.Common;
using 学生学习管理系统.Model;

namespace StudentManager
{
    public partial class FrmStudentInfo : Form
    {
        public FrmStudentInfo()
        {
            InitializeComponent();
        }

        public FrmStudentInfo(StudentModel stuModel):this()
        {
            this.lblStudentName.Text = stuModel.StudentName;
            this.lblGender.Text = stuModel.Gender;  
            this.lblBirthday.Text=stuModel.Bithday.ToShortDateString();
            this.lblCardNo.Text = stuModel.CardNO;
            this.lblStudentIdNo.Text= stuModel.StudentIdNo;
            this.lblClass.Text = stuModel.ClassName;
            this.lblAddress.Text = stuModel.StudentAddress;
            this.pbStu.Image = stuModel.StuImage.Trim().Length == 0 ? null :(Image) new SerializeObjectToString().DeserializeObject(stuModel.StuImage);
            this.lblPhoneNumber.Text = stuModel.PhoneNumber;

            List<StudentModel> stulist=new List<StudentModel>();
            stulist.Add(stuModel);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = stulist;    
        }

        //关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dataGridView1,e);
        }
    }
}