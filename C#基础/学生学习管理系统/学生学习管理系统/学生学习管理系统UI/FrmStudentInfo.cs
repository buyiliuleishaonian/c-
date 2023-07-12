using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ѧ��ѧϰ����ϵͳ.Model;
using ѧ��ѧϰ����ϵͳ.Common;
namespace StudentManager
{
    public partial class FrmStudentInfo : Form
    {
        public List<StudentModel> stulist=new List<StudentModel>();
        public FrmStudentInfo()
        {
            InitializeComponent();
        }

        public FrmStudentInfo(StudentModel student) : this()
        {
            this.lblStudentName.Text = student.StudentName;
            this.lblStudentIdNo.Text = student.StudentIdNo;
            this.lblCardNo.Text = student.CardNO;
            this.lblBirthday.Text = student.Bithday.ToShortDateString();
            this.lblAddress.Text = student.StudentAddress;
            this.lblClass.Text = student.ClassName;
            this.lblPhoneNumber.Text = student.PhoneNumber; 
            this.lblGender.Text = student.Gender;

            this.pbStu.Image = student.StuImage.Trim().Length != 0 ?
               (Image)new SerializeObjectToString().DeserializeObject(student.StuImage) :
               null;
            //��DataGridView��ʾ����
            this.stulist.Add(student);
            //��Ҫ��������Ϊ���Զ����ɣ������ɶ�Ӧstudney�������õ���
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = stulist;
            
        }

        //�ر�
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}