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
    public partial class FrmStudentManage : Form
    {
        //������FrmStudentManage�����µ�ȫ�ֱ���
        public StudnetBLL stuBll = new StudnetBLL();

        public ClassIDBLL classIDBLL = new ClassIDBLL();

        public List<StudentModel> Stulist=new List<StudentModel>();

        /// <summary>
        /// ��ComboBox����ʾ�༶��Ϣ
        /// </summary>
        public FrmStudentManage()
        {
            InitializeComponent();
            //���Ƚ��༶��Ϣ��ȡ����֮����ʾ����������
            this.cboClass.DataSource = classIDBLL.GetClassID();
            this.cboClass.DisplayMember = "ClassName";//���Զ�Ӧ���ı�
            this.cboClass.ValueMember = "ClassID";//����
            this.cboClass.SelectedIndex = -1;
        }

        //���հ༶��ѯ
        /// <summary>
        /// ���༶��ѯѧ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //������༶��Ϣ��ѧԱ��ѡ������˳������
            if (this.cboClass.SelectedIndex==-1 )
            {
                MessageBox.Show("��ѡ��༶��ѯ");
            }
            else
            {
                this.Stulist = stuBll.SelectStudent(this.cboClass.Text);
                this.dgvStudentList.AutoGenerateColumns = false;
                this.dgvStudentList.DataSource = this.Stulist;
                new DataGridViewStyle().DgvStyle1(this.dgvStudentList);//����DataGridView���У�������ɫ����
            }
        }

        //����ѧ�Ų�ѯ
        /// <summary>
        /// ��ѧ������ѯ��ѧԱ��ϸ��Ϣ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueryById_Click(object sender, EventArgs e)
        {
            //��Ҫ�ж�ѧ��TextBox�Ƿ����ѧ��
            if (this.txtStudentId.Text.Trim().Length==0)
            {
                MessageBox.Show("������ѧ��֮���ѯ��Ϣ","��ʾ��Ϣ");
            }
            //��Ҫ�ж�ѧ���Ƿ���������
            if (!DataValidate.IsInteger(this.txtStudentId.Text.Trim()))
            {
                MessageBox.Show("������������","��ʾ��Ϣ");
            }
            StudentModel student = new StudentModel();
            //�����ѯ������Ҫ��ʾѧԱ��Ϣ����
            if ((student = stuBll.SelectCardNo(this.txtStudentId.Text.Trim())) == null)
            {
                MessageBox.Show("��ѧ��û�ж�Ӧ��ѧԱ", "��ʾ��Ϣ");
            }
            //�����ѯ������Ҫ��ʾѧԱ��Ϣ����
            //֮����ҪչʾѧԱ����ϸ��Ϣ
            else
            {
                FrmStudentInfo frmstuinfo= new FrmStudentInfo(student);
                frmstuinfo.ShowDialog();
            }
        }

        /// <summary>
        /// �û����»س���ֱ֮�Ӳ�ѯѧԱ��ϸ��Ϣ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtStudentId_KeyDown(object sender, KeyEventArgs e)
        {
            //ȷ����ѧ�����룬������ǻس���
            if (this.txtStudentId.Text.Trim().Length!=0 && e.KeyValue==13 )
            {
                btnQueryById_Click(null,null);
            }
        }

        //˫��ѡ�е�ѧԱ������ʾ��ϸ��Ϣ
        /// <summary>
        /// ˫��DataGridView��������ʱ����ʾѧԱ����ϸ��Ϣ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentModel model = new StudentModel();
            model= stuBll.SelectCardNo( this.dgvStudentList.CurrentRow.Cells["studentid"].Value.ToString());
            FrmStudentInfo modelinfo = new FrmStudentInfo(model);
            modelinfo.ShowDialog();
        }

        //�޸�ѧԱ����
        /// <summary>
        /// �����ť����ʾѧԱ��ϸ��Ϣ���Ա����Ա�޸�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEidt_Click(object sender, EventArgs e)
        {
            //�ж�DataGridVIew�Ƿ��ѯ֮�󣬴��������/�Ƿ�ѡ����һ��
            if (this.dgvStudentList.RowCount==0)
            {
                MessageBox.Show("û�����ݿ����޸�","��ʾ��Ϣ");
                return;
            }
            if (this.dgvStudentList.CurrentRow == null)
            {
                MessageBox.Show("�û�û��ѡ��","��ʾ��Ϣ");
                return;
            }
            //֮��õ�����ѧԱ��ѧ��
            StudentModel model= new StudentModel();
            model = stuBll.SelectCardNo(this.dgvStudentList.CurrentRow.Cells["Studentid"].Value.ToString());
            FrmEditStudent frmEditStu = new FrmEditStudent(model);
            if (frmEditStu.ShowDialog() == DialogResult.OK)
            {
                btnQuery_Click(null,null);
            }
        }

        //ɾ��ѧԱ����
        /// <summary>
        /// ɾ��ѧԱ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount==0)
            {
                MessageBox.Show("û��ѧԱ��Ϣ","��ʾ��Ϣ");
            }
            if (this.dgvStudentList.CurrentCell == null)
            {
                MessageBox.Show("��ѡ�е���û������");
            }
           DialogResult dlgrlt= MessageBox.Show("ȷ���Ƿ�ɾ��","��ʾ��Ϣ",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dlgrlt==DialogResult.OK)
            {
                stuBll.DeleteStuinfo(this.dgvStudentList.CurrentRow.Cells["studentid"].Value.ToString());
                btnQuery_Click(null, null);
            }
        }

        //��������
        /// <summary>
        /// ��ѧԱ�����ֽ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNameDESC_Click(object sender, EventArgs e)
        {
            if(this.dgvStudentList.RowCount==0)
            { return; }
            this.Stulist.Sort(new StuNameDESC());
            this.dgvStudentList.Refresh();
        }

        //ѧ�Ž���
        /// <summary>
        /// ��ѧ�Ž���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStuIdDESC_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount == 0)
            { return; }
            this.Stulist.Sort(new StuIDDESC());
            this.dgvStudentList.Refresh();
        }

        //����к�
        /// <summary>
        /// ��DataGridView��ʾ�������У���ÿһ�еĸ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint( this.dgvStudentList,e);
        }

        //��ӡ��ǰѧԱ��Ϣ
        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }

        //�ر�
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// ������ʱ����ѯѧԱ����ϸ��Ϣ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiModifyStu_Click(object sender, EventArgs e)
        {
            btnEidt_Click(null, null);
        }

        /// <summary>
        /// ����ʱ����ѧԱ��Ϣɾ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmidDeleteStu_Click(object sender, EventArgs e)
        {
            btnDel_Click(null,null);
        }
    }

    #region ������
    class StuNameDESC : IComparer<StudentModel>
    {
        public int Compare(StudentModel x, StudentModel y)
        {
            return x.StudentName.CompareTo(y.StudentName);
        }
    }

    class StuIDDESC : IComparer<StudentModel>
    {
        public int Compare(StudentModel x, StudentModel y)
        {
            return x.StudentID.CompareTo(y.StudentID);
        }
    }
    #endregion
}