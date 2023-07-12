using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using 学生学习管理系统.Model;
using 学生学习管理系统.Common;
using 学生学习管理系统.BLL;
using 学生学习管理系统UI;

namespace StudentManager
{
    public partial class FrmEditStudent : Form
    {

        public FrmEditStudent()
        {
            InitializeComponent();
            this.cboClassName.DataSource = new ClassIDBLL().GetClassID();
            this.cboClassName.ValueMember = "classid";
            this.cboClassName.DisplayMember = "className";
            this.cboClassName.SelectedIndex = -1;
        }


        public FrmEditStudent(StudentModel stuModel) : this()
        {
            this.txtStudentId.Text = stuModel.StudentID.ToString();
            this.txtStudentName.Text = stuModel.StudentName;
            if (stuModel.Gender == "男")
            { this.rdoMale.Checked = true; }
            else { this.rdoFemale.Checked = true; }
            this.dtpBirthday.Text = stuModel.Bithday.ToShortDateString();
            this.txtCardNo.Text = stuModel.CardNO;
            this.txtStudentIdNo.Text = stuModel.StudentIdNo;
            this.cboClassName.Text = stuModel.ClassName;
            this.txtAddress.Text = stuModel.StudentAddress;
            this.pbStu.Image = stuModel.StuImage.Trim().Length == 0 ? null : (Image)new SerializeObjectToString().DeserializeObject(stuModel.StuImage);
            this.txtPhoneNumber.Text = stuModel.PhoneNumber;
            this.txtStudentId.Enabled = false;
        }
        //提交修改
        private void btnModify_Click(object sender, EventArgs e)
        {
            //在修改数据库之前，需要验证数据是否为空，
            #region  验证修改信息
            if (this.txtStudentName.Text.Trim().Length == 0)
            {
                MessageBox.Show("学生姓名不能为空");
                this.txtStudentName.Focus();
                return;
            }
            if (this.txtStudentIdNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("身份证不能为空");
                this.txtStudentIdNo.Focus();
                return;
            }
            if (this.txtPhoneNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("手机号码不能为空");
                this.txtPhoneNumber.Focus();
                return;
            }
            if (this.txtCardNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("卡号不能为空");
                this.txtCardNo.Focus();
                return;
            }
            if (this.txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("家庭住址不能为空");
                this.txtAddress.Focus();
                return;
            }
            if (this.cboClassName.SelectedIndex == -1)
            {
                MessageBox.Show("班级不能为空");
                this.cboClassName.Focus();
                return;
            }
            if (this.pbStu.Image == null)
            {
                MessageBox.Show("学生图像不能为空");
                this.btnChoseImage.Focus();
            }
            if (this.txtPhoneNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("手机号码不能为空");
                this.txtPhoneNumber.Focus();
                return;
            }
            if (!this.rdoMale.Checked && !this.rdoFemale.Checked)
            {
                MessageBox.Show("请选择性别");
                this.rdoFemale.Focus();
                return;
            }
            //年龄限定18~35，用电脑运行程序的时间，减去所选择的时间
            //或者利用数据库的时间，减去选择的时间
            int age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year;
            if (age > 35 || age < 18)
            {
                MessageBox.Show("年龄不符合要求");
                return;
            }
            //身份证格式的验证，用正则表达式来，判断身份证格式
            if (new StudnetBLL().determine(this.txtStudentId.Text,this.txtStudentIdNo.Text))
            {
                MessageBox.Show("身份证格式已经存在于数据中");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }
            //验证身份证和出生日期是否对的上，将选择的日期改为字符串的格式，
            //通过字符串包含的方法来确定是否对的上
            string drithday = Convert.ToDateTime(this.dtpBirthday.Text).ToString("yyyyMMdd");
            if (!this.txtStudentIdNo.Text.ToString().Contains(drithday))
            {
                MessageBox.Show("身份证和生日不符");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }

            //输入身份证号格式是否正确
            if (!DataValidate.IsIdentityCard(this.txtStudentIdNo.Text))
            {
                MessageBox.Show("身份证格式不对");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }
            #endregion

            //将修改的信息传送给数据库
            StudentModel studentModel = new StudentModel()
            {
                StudentID = Convert.ToInt32(this.txtStudentId.Text),
                StudentName = this.txtStudentName.Text,
                Gender = this.rdoMale.Checked == true ? "男" : "女",
                Bithday = Convert.ToDateTime(this.dtpBirthday.Text),
                CardNO = this.txtCardNo.Text,
                StudentIdNo = this.txtStudentIdNo.Text,
                ClassID = Convert.ToInt32(this.cboClassName.SelectedValue),
                StudentAddress = this.txtAddress.Text,
                StuImage = new SerializeObjectToString().SerializeObject(this.pbStu.Image) != null ? new SerializeObjectToString().SerializeObject(this.pbStu.Image) :
                null,
                PhoneNumber = this.txtPhoneNumber.Text,
                Age = age
            };
            int number=new StudnetBLL().UpdateStu(studentModel);
            if (number == 0)
            {
                MessageBox.Show("修改失败");
                return;
            }
            else
            {
                MessageBox.Show("修改成功");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //选择照片
        /// <summary>
        /// 选择照片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoseImage_Click(object sender, EventArgs e)
        {
           OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "选择照片";
            openFileDialog.Filter = "所有文件|*.*";
            openFileDialog.Multiselect = false;
            openFileDialog.InitialDirectory = @"F:\wallhaven壁纸下载地";
            DialogResult ds= openFileDialog.ShowDialog();
            if (ds==DialogResult.OK)
            {
                this.pbStu.Image = Image.FromFile(openFileDialog.FileName);
            }
            else
            {
                return;
            }
        }
    }
}