using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ѧ��ѧϰ����ϵͳ.BLL;
using ѧ��ѧϰ����ϵͳ.Model;
using ѧ��ѧϰ����ϵͳ.Common;
using System.Data.SqlClient;

namespace StudentManager
{
    public partial class FrmStudentManage : Form
    {
        private StudnetBLL stubll=new StudnetBLL();

        private ClassIDBLL classdb=new ClassIDBLL();

        private List<StudentModel> stulist=new List<StudentModel>();
    
        public FrmStudentManage()
        {
            InitializeComponent();
            this.cboClass.DataSource=this.classdb.GetClassID();
            this.cboClass.ValueMember = "classid";
            this.cboClass.DisplayMember = "classname";
            this.cboClass.SelectedIndex = -1;
            //ȡ��datagridview�Զ�����������Դ������������Ϣ
            this.dgvStudentList.AutoGenerateColumns = false;
            
            
        }

        //���հ༶��ѯ
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (this.cboClass.Text.Trim() == null)
            {
                MessageBox.Show("��ѡ��༶��ѯ", "��ʾ��Ϣ");
                return;
            }
            else
            {
               this.dgvStudentList.DataSource = null;
               this.dgvStudentList.DataSource =this.stubll.ReadStudents((int)this.cboClass.SelectedValue);
            }
        }

        //����ѧ�Ų�ѯ
        private void btnQueryById_Click(object sender, EventArgs e)
        {
            if (this.txtStudentId.Text.Trim() == null) return;
            if (!DataValidate.IsInteger(this.txtStudentId.Text.Trim()))
            {
                MessageBox.Show("������������ѧ��");
                return;
            }
           StudentModel stuModel= this.stubll.ReadStu(this.txtStudentId.Text);
            if (stuModel==null)
            {
                MessageBox.Show("ѧԱ�����ڣ�����������ѧ��","��ʾ��Ϣ");
                this.txtStudentId.SelectAll();
                this.txtStudentId.Text = null;
            }
            else
            {
                FrmStudentInfo frmStudentInfo = new FrmStudentInfo(stuModel);
                frmStudentInfo.Show();
            }
        }

        /// <summary>
        /// ����tab����ִ�У�ѧ�Ų�ѯ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtStudentId_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtStudentId.Text.Trim() !=null && e.KeyValue==13)
            {
                btnQueryById_Click(null, null);
            }
        }

        
       

        //�޸�ѧԱ����
        /// <summary>
        /// �޸�ѧԱ��Ϣ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEidt_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount==0)
            {
                MessageBox.Show("û��ѧԱ��Ϣ");
                return;
            }
            if (this.dgvStudentList.SelectedRows == null)
            {
                MessageBox.Show("û��ѡ��ѧԱ��Ϣ");
                return;
            }
            StudentModel stumodel = stubll.ReadStu(this.dgvStudentList.CurrentRow.Cells["studentid"].Value.ToString());
            FrmEditStudent frmeditstu = new FrmEditStudent(stumodel);
            DialogResult ds =frmeditstu.ShowDialog();
            if (ds==DialogResult.OK)
            {
                //�޸�֮��ˢ����ʾ����Ϣ
                btnQuery_Click(null, null);
            }
        }

        //ɾ��ѧԱ����
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount==0)
            {
                MessageBox.Show("û��ѧԱ��Ϣ","��ʾ��Ϣ");
            }
        }     
        //��������
        private void btnNameDESC_Click(object sender, EventArgs e)
        {
          if(this.dgvStudentList.RowCount==0)return;
            this.stulist.Sort(new NameDESC());
            //���»���datagridview
            this.dgvStudentList.Refresh();
        }
        //ѧ�Ž���
        private void btnStuIdDESC_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount == 0) return;
            this. stulist.Sort(new StuIDDESC());
            this.dgvStudentList.Refresh();
        }
        //����к�
        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgvStudentList,e);
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
        /// �޸�ѧԱ��Ϣ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiModifyStu_Click(object sender, EventArgs e)
        {
            btnEidt_Click(null, null);
        }
        
        /// <summary>
        /// ˫��ѡ�е��У��鿴ѧԱ��ϸ��Ϣ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvStudentList.RowCount == 0)
            {
                MessageBox.Show("û��ѧԱ��Ϣ");
                return;
            }
            if (this.dgvStudentList.SelectedRows == null)
            {
                MessageBox.Show("û��ѡ��ѧԱ��Ϣ");
                return;
            }
            StudentModel stu = new StudnetBLL().ReadStu(this.dgvStudentList.CurrentRow.Cells["studentid"].Value.ToString());
            FrmStudentInfo frmStudentInfo = new FrmStudentInfo(stu);
            frmStudentInfo.Show();
        }
    }

    #region ������
    //��������
    class NameDESC : IComparer<StudentModel>
    {
        public int Compare(StudentModel x, StudentModel y)
        {
            return y.StudentName.CompareTo(x.StudentName);
        }
    }
    //�༶����
    class StuIDDESC : IComparer<StudentModel>
    {
        public int Compare(StudentModel x, StudentModel y)
        {
           return y.StudentID.CompareTo(x.StudentID);
        }
    }
    #endregion
}