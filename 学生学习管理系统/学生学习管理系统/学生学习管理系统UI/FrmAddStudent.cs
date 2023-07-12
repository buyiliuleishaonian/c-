using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 学生学习管理系统.Model;
using 学生学习管理系统.BLL;
using 学生学习管理系统.Common;
using 学生学习管理系统UI;

namespace StudentManager
{
    public partial class FrmAddStudent : Form
    {
        //创建在这个窗体下班级的全局变量
         private  ClassIDBLL classIDBLL = new ClassIDBLL();
        //创建在这个窗体下的信息的全局变量
        private  StudnetBLL st=new StudnetBLL();

        private List<StudentModel> liststu=new List<StudentModel>();

        public FrmAddStudent()
        {
            ClassIDBLL  classIDBLL = new ClassIDBLL();
            InitializeComponent();
            this.cboClassName.DataSource = classIDBLL.GetClassID();
            //其两者都是对应集合中的属性，看你自己选择在下拉框中选择谁
            //两者都是一一对应的关系
            this.cboClassName.DisplayMember = "ClassName";//显示下拉框中的文本
            this.cboClassName.ValueMember = "ClassID";//显示下拉框中文本对应的属性
            this.cboClassName.SelectedIndex = -1;
        }
        //添加新学员
        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region 数据验证
            if (this.txtStudentName.Text.Trim().Length==0)
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
            if (this.cboClassName.SelectedIndex==-1)
            {
                MessageBox.Show("班级不能为空");
                this.cboClassName.Focus();
                return;
            }
            if (this.pbStu.Image==null)
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
            int age=DateTime.Now.Year-Convert.ToDateTime(this.dtpBirthday.Text).Year;
            if (age>35 || age<18)
            {
                MessageBox.Show("年龄不符合要求");
                return;
            }
            //身份证格式的验证，用正则表达式来，判断身份证格式
            if (!DataValidate.IsIdentityCard(this.txtStudentIdNo.Text))
            {
                MessageBox.Show("身份证格式不对");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }
            //验证身份证和出生日期是否对的上，将选择的日期改为字符串的格式，
            //通过字符串包含的方法来确定是否对的上
            string drithday = Convert.ToDateTime(this.dtpBirthday.Text).ToString("yyyyMMdd");
            if(!this.txtStudentIdNo.Text.ToString().Contains(drithday))
            {
                MessageBox.Show("身份证和生日不符");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }

            //输入的卡号和身份证号不能和数据库重复
            Program.studentModel.StudentIdNo=this.txtStudentIdNo.Text;
            Program.studentModel.CardNO=this.txtCardNo.Text;
            if (StudnetBLL.BoolInStudent(Program.studentModel))
            {
                MessageBox.Show("学生表里面已经存在了身份证或者卡号");
                Program.studentModel = null;
                this.txtStudentIdNo.Text = null;
                this.txtCardNo.Text= null;
                this.txtStudentIdNo.Focus();
                return;
            }
            #endregion

            #region  //添加学生
            StudentModel stumodel = new StudentModel()
            {
                StudentName = this.txtStudentName.Text,
                ClassID = Convert.ToInt32( this.cboClassName.SelectedValue),
                Gender = this.rdoMale.Checked != true ? "女" : "男",
                Bithday = Convert.ToDateTime( this.dtpBirthday.Text),
                StudentIdNo = this.txtStudentIdNo.Text,
                CardNO = this.txtCardNo.Text,
                PhoneNumber = this.txtPhoneNumber.Text,
                Age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year,
                StudentAddress = this.txtAddress.Text,
                StuImage = new SerializeObjectToString().SerializeObject(this.pbStu.Image) != null ?
                new SerializeObjectToString().SerializeObject(this.pbStu.Image) : null,
                ClassName=this.cboClassName.Text
                
            };
            if (StudnetBLL.InsertStu(stumodel)>1)
            {
                MessageBox.Show("添加成功");
                stumodel.StudentID = StudnetBLL.InsertStu(stumodel);
                this.liststu.Add(stumodel);
                this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource =this.liststu;
                new DataGridViewStyle().DgvStyle2(this.dataGridView1);
            }
            else
            {
                MessageBox.Show("添加失败");
            }
            #endregion
        }
        //关闭窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        //选择新照片
        /// <summary>
        /// 选择图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoseImage_Click(object sender, EventArgs e)
        {
            //创建打开文件夹对象
            OpenFileDialog open=new OpenFileDialog();
            open.InitialDirectory = @"F:\wallhaven壁纸下载地";//打开文件夹的初始目录
            open.Title = "选择图片";//打开对话框的名字
            open.Filter = "所有文件|*.*|*.jpg|";//可以选择文件的扩展名
            DialogResult result= open.ShowDialog();//通过打开文件夹的返回值
            if (result==DialogResult.OK)//当文件夹取消时，不给图片空间路径
            {
                //则将选择图片的路径给到图片控件
                pbStu.Image = Image.FromFile(open.FileName);
            }
        }

        /// <summary>
        /// 清除照片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            pbStu.Image = null;
        }

        
        /// <summary>
        /// 每次数据更新，更改行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
             DataGridViewStyle.DgvRowPostPaint(this.dataGridView1,e);
        }
    }
}