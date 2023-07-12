using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using 学生学习管理系统.BLL;
using 学生学习管理系统.Model;
using 学生学习管理系统.Common;
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
            //取消datagridview自动生成数据来源的所有数据信息
            this.dgvStudentList.AutoGenerateColumns = false;
            
            
        }

        //按照班级查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (this.cboClass.Text.Trim() == null)
            {
                MessageBox.Show("请选择班级查询", "提示信息");
                return;
            }
            else
            {
               this.dgvStudentList.DataSource = null;
               this.dgvStudentList.DataSource =this.stubll.ReadStudents((int)this.cboClass.SelectedValue);
            }
        }

        //根据学号查询
        private void btnQueryById_Click(object sender, EventArgs e)
        {
            if (this.txtStudentId.Text.Trim() == null) return;
            if (!DataValidate.IsInteger(this.txtStudentId.Text.Trim()))
            {
                MessageBox.Show("请输入正整数学号");
                return;
            }
           StudentModel stuModel= this.stubll.ReadStu(this.txtStudentId.Text);
            if (stuModel==null)
            {
                MessageBox.Show("学员不存在，请重新输入学号","提示信息");
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
        /// 按下tab键是执行，学号查询
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

        
       

        //修改学员对象
        /// <summary>
        /// 修改学员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEidt_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount==0)
            {
                MessageBox.Show("没有学员信息");
                return;
            }
            if (this.dgvStudentList.SelectedRows == null)
            {
                MessageBox.Show("没有选择学员信息");
                return;
            }
            StudentModel stumodel = stubll.ReadStu(this.dgvStudentList.CurrentRow.Cells["studentid"].Value.ToString());
            FrmEditStudent frmeditstu = new FrmEditStudent(stumodel);
            DialogResult ds =frmeditstu.ShowDialog();
            if (ds==DialogResult.OK)
            {
                //修改之后，刷新显示的信息
                btnQuery_Click(null, null);
            }
        }

        //删除学员对象
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount==0)
            {
                MessageBox.Show("没有学员信息","提示信息");
            }
        }     
        //姓名降序
        private void btnNameDESC_Click(object sender, EventArgs e)
        {
          if(this.dgvStudentList.RowCount==0)return;
            this.stulist.Sort(new NameDESC());
            //重新绘制datagridview
            this.dgvStudentList.Refresh();
        }
        //学号降序
        private void btnStuIdDESC_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount == 0) return;
            this. stulist.Sort(new StuIDDESC());
            this.dgvStudentList.Refresh();
        }
        //添加行号
        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgvStudentList,e);
        }
        //打印当前学员信息
        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }
     
        //关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 修改学员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiModifyStu_Click(object sender, EventArgs e)
        {
            btnEidt_Click(null, null);
        }
        
        /// <summary>
        /// 双击选中的行，查看学员详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvStudentList.RowCount == 0)
            {
                MessageBox.Show("没有学员信息");
                return;
            }
            if (this.dgvStudentList.SelectedRows == null)
            {
                MessageBox.Show("没有选择学员信息");
                return;
            }
            StudentModel stu = new StudnetBLL().ReadStu(this.dgvStudentList.CurrentRow.Cells["studentid"].Value.ToString());
            FrmStudentInfo frmStudentInfo = new FrmStudentInfo(stu);
            frmStudentInfo.Show();
        }
    }

    #region 排列类
    //姓名排序
    class NameDESC : IComparer<StudentModel>
    {
        public int Compare(StudentModel x, StudentModel y)
        {
            return y.StudentName.CompareTo(x.StudentName);
        }
    }
    //班级排序
    class StuIDDESC : IComparer<StudentModel>
    {
        public int Compare(StudentModel x, StudentModel y)
        {
           return y.StudentID.CompareTo(x.StudentID);
        }
    }
    #endregion
}