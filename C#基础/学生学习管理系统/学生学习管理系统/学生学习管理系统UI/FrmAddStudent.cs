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
using System.Runtime.Remoting.Messaging;

namespace StudentManager
{
    public partial class FrmAddStudent : Form
    {
        //��������������°༶��ȫ�ֱ���
        private ClassIDBLL classIDBLL = new ClassIDBLL();
        //���������������ѧ������Ϣ��ȫ�ֱ���
        private StudnetBLL st = new StudnetBLL();
        //����list���Ͻ����е�ѧ����Ϣ��ӽ�ȥ
        List<StudentModel> liststu = new List<StudentModel>();

        public FrmAddStudent()
        {
            ClassIDBLL classIDBLL = new ClassIDBLL();
            InitializeComponent();
            this.cboClassName.DataSource = classIDBLL.GetClassID();
            //�����߶��Ƕ�Ӧ�����е����ԣ������Լ�ѡ������������ѡ��˭
            //���߶���һһ��Ӧ�Ĺ�ϵ
            this.cboClassName.DisplayMember = "ClassName";//��ʾ�������е��ı�
            this.cboClassName.ValueMember = "ClassID";//��ʾ���������ı���Ӧ������
            this.cboClassName.SelectedIndex = -1;

            this.dataGridView1.AutoGenerateColumns = false;
        }
        //�����ѧԱ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region ������֤
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

            //����Ŀ��ź����֤�Ų��ܺ����ݿ��ظ�
            string[] str = new string[] { this.txtStudentIdNo.Text, this.txtCardNo.Text };
            if (StudnetBLL.BoolInStudent(str))
            {
                MessageBox.Show("ѧ���������Ѿ����������֤���߿���");
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

            #region  ���ѧ��
            StudentModel stuModel = new StudentModel()
            {
                StudentName = this.txtStudentName.Text,
                Gender = this.rdoMale.Checked ? "��" : "Ů",
                Bithday = Convert.ToDateTime(this.dtpBirthday.Text),
                StudentIdNo = this.txtStudentIdNo.Text,
                CardNO = this.txtCardNo.Text,
                StuImage = this.pbStu.Image != null ? new SerializeObjectToString().SerializeObject(this.pbStu.Image) : "",
                Age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year,
                PhoneNumber = this.txtPhoneNumber.Text,
                StudentAddress = this.txtAddress.Text,
                ClassID = Convert.ToInt32(this.cboClassName.SelectedValue)
            };
            int number = StudnetBLL.GetStu(stuModel);
            if (number > 1)
            {
                //ͬ����ʾ��ӵ�ѧԱ
                stuModel.ClassName = this.cboClassName.Text;
                stuModel.StudentID = number;
                this.liststu.Add(stuModel);
                this.dataGridView1.DataSource = null;
                this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.DataSource = this.liststu;
                #region ���ѧԱ�ɹ�֮����Ҫ�ж��Ƿ�������ѧԱ
                //ѯ���Ƿ�������,������ʾ��Ϣ��֮�����ɰ�ť����ʾ�������ǽ���
                try
                {
                    DialogResult result = MessageBox.Show("��ѧԱ��ӳɹ�", "�Ƿ�������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        //��Ϊ���е��ı��򶼴����groupbox������
                        foreach (Control item in this.groupBox1.Controls)
                        {
                            if (item is TextBox)
                            {
                                item.Text = "";
                            }
                            else if (item is RadioButton)
                            {
                                ((RadioButton)item).Checked = false;
                            }
                        }
                        //���ڿؼ����ó�ʼ��
                        this.cboClassName.SelectedIndex = -1;
                        this.pbStu.Image = null;
                        this.txtStudentName.Focus();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("���ѧԱʧ�ܵ�ԭ��" + ex.Message);
                }
                #endregion
            }
            else
            {
                MessageBox.Show("���ʧ��");
                return;
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
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = @"F:\wallhaven��ֽ���ص�";//���ļ��еĳ�ʼĿ¼
            open.Title = "ѡ��ͼƬ";//�򿪶Ի��������
            open.Filter = "�����ļ�|*.*|ͼƬ.jpg|";//����ѡ���ļ�����չ��
            DialogResult result = open.ShowDialog();//ͨ�����ļ��еķ���ֵ
            if (result == DialogResult.OK)//���ļ���ȡ��ʱ������ͼƬ�ռ�·��
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
        /// ����кţ�ÿ�����ѧԱ֮�󣬶���ѽ�ػ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dataGridView1,e);
        }
    }
}