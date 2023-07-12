using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ѧ��ѧϰ����ϵͳ.Model;
using ѧ��ѧϰ����ϵͳ.Common;
using ѧ��ѧϰ����ϵͳ.BLL;
using ѧ��ѧϰ����ϵͳUI;

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
            if (stuModel.Gender == "��")
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
        //�ύ�޸�
        private void btnModify_Click(object sender, EventArgs e)
        {
            //���޸����ݿ�֮ǰ����Ҫ��֤�����Ƿ�Ϊ�գ�
            #region  ��֤�޸���Ϣ
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
            if (new StudnetBLL().determine(this.txtStudentId.Text,this.txtStudentIdNo.Text))
            {
                MessageBox.Show("���֤��ʽ�Ѿ�������������");
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

            //�������֤�Ÿ�ʽ�Ƿ���ȷ
            if (!DataValidate.IsIdentityCard(this.txtStudentIdNo.Text))
            {
                MessageBox.Show("���֤��ʽ����");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }
            #endregion

            //���޸ĵ���Ϣ���͸����ݿ�
            StudentModel studentModel = new StudentModel()
            {
                StudentID = Convert.ToInt32(this.txtStudentId.Text),
                StudentName = this.txtStudentName.Text,
                Gender = this.rdoMale.Checked == true ? "��" : "Ů",
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
                MessageBox.Show("�޸�ʧ��");
                return;
            }
            else
            {
                MessageBox.Show("�޸ĳɹ�");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //ѡ����Ƭ
        /// <summary>
        /// ѡ����Ƭ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoseImage_Click(object sender, EventArgs e)
        {
           OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "ѡ����Ƭ";
            openFileDialog.Filter = "�����ļ�|*.*";
            openFileDialog.Multiselect = false;
            openFileDialog.InitialDirectory = @"F:\wallhaven��ֽ���ص�";
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