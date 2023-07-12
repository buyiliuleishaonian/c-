using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ѧ��ѧϰ����ϵͳ.Model;
using ѧ��ѧϰ����ϵͳ.BLL;
using ѧ��ѧϰ����ϵͳ.Common;

namespace StudentManager
{
    public partial class FrmEditStudent : Form
    {
        public ClassIDBLL classbll = new ClassIDBLL();

        public StudnetBLL st=new StudnetBLL();

        public FrmEditStudent()
        {
            //��Ҫ��ʼ���༶
            InitializeComponent();
            this.cboClassName.DataSource = classbll.GetClassID();
            this.cboClassName.ValueMember = "ClassID";
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.SelectedIndex = -1;
        }

        /// <summary>
        /// ����ϸ��ѧԱ��Ϣ���뵽����
        /// </summary>
        /// <param name="objstudent"></param>
        public FrmEditStudent(StudentModel objstudent) : this()
        {
            this.txtStudentId.Text = objstudent.StudentID.ToString();
            this.txtStudentName.Text = objstudent.StudentName;
            if (objstudent.Gender == "��")
            {
                this.rdoMale.Checked = true;
            }
            else
            {
                this.rdoFemale.Checked = true;
            }
            this.dtpBirthday.Text = objstudent.Bithday.ToShortDateString();
            this.txtStudentIdNo.Text = objstudent.StudentIdNo;
            this.txtCardNo.Text = objstudent.CardNO;
            this.txtAddress.Text = objstudent.StudentAddress;
            this.txtPhoneNumber.Text = objstudent.PhoneNumber;
            this.pbStu.Image = objstudent.StuImage.Trim().Length != 0 ?
                (Image)new SerializeObjectToString().DeserializeObject(objstudent.StuImage) :
                null;
            this.cboClassName.Text = objstudent.ClassName;
        }

        //�ύ�޸�
        private void btnModify_Click(object sender, EventArgs e)
        {
            //���޸�ȷ��ǰ����Ҫ��֤���е�����û������
            #region ������֤�����ڿ��ź����֤����Ҫ�����ж�
            if (this.txtStudentName.Text.Trim().Length == 0)
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
            if (this.cboClassName.SelectedIndex == -1)
            {
                MessageBox.Show("�༶����Ϊ��");
                this.cboClassName.Focus();
                return;
            }
            if (this.pbStu.Image == null)
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
            int age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year;
            if (age > 35 || age < 18)
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
            if (!this.txtStudentIdNo.Text.ToString().Contains(drithday))
            {
                MessageBox.Show("���֤�����ղ���");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }

            if (StudnetBLL.BoolInStudent(this.txtStudentIdNo.Text,this.txtCardNo.Text))
            {
                MessageBox.Show("���ѧԱ�Ѵ��ڴ����֤","�������޸����֤");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }
           

            //��֤���ű�����������
            if (!DataValidate.IsInteger(this.txtCardNo.Text))
            {
                MessageBox.Show("���ű�����������");
                this.txtCardNo.SelectAll();
                this.txtCardNo.Focus();
                return;
            }
            #endregion

            #region  �������
            StudentModel stuModel = new StudentModel()
            {
                StudentID = Convert.ToInt32(this.txtStudentId.Text),
                StudentName = this.txtStudentName.Text,
                Gender = this.rdoMale.Checked == true ? "��" : "Ů",
                Bithday = Convert.ToDateTime(this.dtpBirthday.Text),
                StudentIdNo = this.txtStudentIdNo.Text,
                CardNO = this.txtCardNo.Text,
                StudentAddress = this.txtAddress.Text,
                PhoneNumber = this.txtPhoneNumber.Text,
                StuImage = this.pbStu.Image != null ?
                new SerializeObjectToString().SerializeObject(this.pbStu.Image) : null,
                ClassID = Convert.ToInt32( this.cboClassName.SelectedValue),
                Age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year
            };
            #endregion
            if (st.UpdateStuinfo(stuModel))
            {
                MessageBox.Show("�޸ĳɹ�");
                this.DialogResult= DialogResult.OK;
            }
            else 
            {
                MessageBox.Show("�޸�ʧ��");
            }
        }

        /// <summary>
        /// �رմ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //ѡ����Ƭ
        /// <summary>
        /// ѡ����Ƭ
        /// </summary>
        /// <param name="sender"></param>dada
        /// <param name="e"></param>
        private void btnChoseImage_Click(object sender, EventArgs e)
        {
           OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "ѡ��ͼƬ";
            openFileDialog.InitialDirectory = @"F:\wallhaven��ֽ���ص�";
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "�����ļ�|*.*";
            DialogResult diaresult = openFileDialog.ShowDialog(); 
            if(diaresult==DialogResult.OK)
            {
                this.pbStu.Image=Image.FromFile( openFileDialog.FileName);
            }
        }
    }
}