using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ѧ��ѧϰ����ϵͳ.Model;
using ѧ��ѧϰ����ϵͳ.BLL;
using ѧ��ѧϰ����ϵͳ.Common;
using ѧ��ѧϰ����ϵͳUI;

namespace StudentManager
{
    public partial class FrmAddStudent : Form
    {
        //��������������°༶��ȫ�ֱ���
         private  ClassIDBLL classIDBLL = new ClassIDBLL();
        //��������������µ���Ϣ��ȫ�ֱ���
        private  StudnetBLL st=new StudnetBLL();

        private List<StudentModel> liststu=new List<StudentModel>();

        public FrmAddStudent()
        {
            ClassIDBLL  classIDBLL = new ClassIDBLL();
            InitializeComponent();
            this.cboClassName.DataSource = classIDBLL.GetClassID();
            //�����߶��Ƕ�Ӧ�����е����ԣ������Լ�ѡ������������ѡ��˭
            //���߶���һһ��Ӧ�Ĺ�ϵ
            this.cboClassName.DisplayMember = "ClassName";//��ʾ�������е��ı�
            this.cboClassName.ValueMember = "ClassID";//��ʾ���������ı���Ӧ������
            this.cboClassName.SelectedIndex = -1;
        }
        //�����ѧԱ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region ������֤
            if (this.txtStudentName.Text.Trim().Length==0)
            {
                MessageBox.Show("ѧ����������Ϊ��");
                this.txtStudentName.Focus();
                return;
            }
            if (this.txtStudentIdNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("���֤����Ϊ��");
                this.txtStudentIdNo.Focus();
                return;
            }
            if (this.txtPhoneNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("�ֻ����벻��Ϊ��");
                this.txtPhoneNumber.Focus();
                return;
            }
            if (this.txtCardNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("���Ų���Ϊ��");
                this.txtCardNo.Focus();
                return;
            }
            if (this.txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("��ͥסַ����Ϊ��");
                this.txtAddress.Focus();
                return;
            }
            if (this.cboClassName.SelectedIndex==-1)
            {
                MessageBox.Show("�༶����Ϊ��");
                this.cboClassName.Focus();
                return;
            }
            if (this.pbStu.Image==null)
            {
                MessageBox.Show("ѧ��ͼ����Ϊ��");
                this.btnChoseImage.Focus();
            }
            if (this.txtPhoneNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("�ֻ����벻��Ϊ��");
                this.txtPhoneNumber.Focus();
                return;
            }
            if (!this.rdoMale.Checked && !this.rdoFemale.Checked)
            {
                MessageBox.Show("��ѡ���Ա�");
                this.rdoFemale.Focus();
                return;
            }
            //�����޶�18~35���õ������г����ʱ�䣬��ȥ��ѡ���ʱ��
            //�����������ݿ��ʱ�䣬��ȥѡ���ʱ��
            int age=DateTime.Now.Year-Convert.ToDateTime(this.dtpBirthday.Text).Year;
            if (age>35 || age<18)
            {
                MessageBox.Show("���䲻����Ҫ��");
                return;
            }
            //���֤��ʽ����֤����������ʽ�����ж����֤��ʽ
            if (!DataValidate.IsIdentityCard(this.txtStudentIdNo.Text))
            {
                MessageBox.Show("���֤��ʽ����");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }
            //��֤���֤�ͳ��������Ƿ�Ե��ϣ���ѡ������ڸ�Ϊ�ַ����ĸ�ʽ��
            //ͨ���ַ��������ķ�����ȷ���Ƿ�Ե���
            string drithday = Convert.ToDateTime(this.dtpBirthday.Text).ToString("yyyyMMdd");
            if(!this.txtStudentIdNo.Text.ToString().Contains(drithday))
            {
                MessageBox.Show("���֤�����ղ���");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }

            //����Ŀ��ź����֤�Ų��ܺ����ݿ��ظ�
            Program.studentModel.StudentIdNo=this.txtStudentIdNo.Text;
            Program.studentModel.CardNO=this.txtCardNo.Text;
            if (StudnetBLL.BoolInStudent(Program.studentModel))
            {
                MessageBox.Show("ѧ���������Ѿ����������֤���߿���");
                Program.studentModel = null;
                this.txtStudentIdNo.Text = null;
                this.txtCardNo.Text= null;
                this.txtStudentIdNo.Focus();
                return;
            }
            #endregion

            #region  //���ѧ��
            StudentModel stumodel = new StudentModel()
            {
                StudentName = this.txtStudentName.Text,
                ClassID = Convert.ToInt32( this.cboClassName.SelectedValue),
                Gender = this.rdoMale.Checked != true ? "Ů" : "��",
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
                MessageBox.Show("��ӳɹ�");
                stumodel.StudentID = StudnetBLL.InsertStu(stumodel);
                this.liststu.Add(stumodel);
                this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource =this.liststu;
                new DataGridViewStyle().DgvStyle2(this.dataGridView1);
            }
            else
            {
                MessageBox.Show("���ʧ��");
            }
            #endregion
        }
        //�رմ���
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        //ѡ������Ƭ
        /// <summary>
        /// ѡ��ͼƬ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoseImage_Click(object sender, EventArgs e)
        {
            //�������ļ��ж���
            OpenFileDialog open=new OpenFileDialog();
            open.InitialDirectory = @"F:\wallhaven��ֽ���ص�";//���ļ��еĳ�ʼĿ¼
            open.Title = "ѡ��ͼƬ";//�򿪶Ի��������
            open.Filter = "�����ļ�|*.*|*.jpg|";//����ѡ���ļ�����չ��
            DialogResult result= open.ShowDialog();//ͨ�����ļ��еķ���ֵ
            if (result==DialogResult.OK)//���ļ���ȡ��ʱ������ͼƬ�ռ�·��
            {
                //��ѡ��ͼƬ��·������ͼƬ�ؼ�
                pbStu.Image = Image.FromFile(open.FileName);
            }
        }

        /// <summary>
        /// �����Ƭ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            pbStu.Image = null;
        }

        
        /// <summary>
        /// ÿ�����ݸ��£������к�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
             DataGridViewStyle.DgvRowPostPaint(this.dataGridView1,e);
        }
    }
}