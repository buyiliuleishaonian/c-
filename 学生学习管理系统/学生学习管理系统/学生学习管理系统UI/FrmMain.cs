using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using ѧ��ѧϰ����ϵͳUI;

namespace StudentManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //��ʾ�û�
            this.lblCurrentUser.Text = Program.adminModel.AdminName+"]";
            //��ʾ����ͼƬ
            this.panelForm.BackgroundImage = Image.FromFile(@"mainbg.png");
            this.panelForm.BackgroundImageLayout =ImageLayout.Stretch;
            //��ʾ�汾��
            this.lblVersion.Text ="��ǰ�汾:"+ ConfigurationManager.AppSettings["banben"].ToString();
            //Ȩ���趨
        }    

        #region Ƕ�봰����ʾ

     
        //��ʾ�����ѧԱ����       
        private void tsmiAddStudent_Click(object sender, EventArgs e)
        {          
            FrmAddStudent objForm = new FrmAddStudent();
            ShowForm(objForm);
        }
        //���ڴ�      
        private void tsmi_Card_Click(object sender, EventArgs e)
        {
            FrmAttendance objForm = new FrmAttendance();
            ShowForm(objForm);


        }
        //�ɼ����ٲ�ѯ��Ƕ����ʾ��
        private void tsmiQuery_Click(object sender, EventArgs e)
        {
          FrmScoreQuery objForm = new FrmScoreQuery();
            ShowForm(objForm);
        }
        //ѧԱ����Ƕ����ʾ��
        private void tsmiManageStudent_Click(object sender, EventArgs e)
        {
           FrmStudentManage objForm = new FrmStudentManage();
            ShowForm(objForm);
        }
        //��ʾ�ɼ���ѯ���������    
        private void tsmiQueryAndAnalysis_Click(object sender, EventArgs e)
        {
            FrmScoreManage objForm = new FrmScoreManage();
            ShowForm(objForm);
        }
        //���ڲ�ѯ
        private void tsmi_AQuery_Click(object sender, EventArgs e)
        {
            FrmAttendanceQuery objForm = new FrmAttendanceQuery();
            ShowForm(objForm);
        }
        #endregion

        #region �˳�ϵͳȷ��

        //�˳�ϵͳ
        private void tmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        #endregion

        #region ����

        //�����޸�
        private void tmiModifyPwd_Click(object sender, EventArgs e)
        {
            FrmModifyPwd objPwd = new FrmModifyPwd();
            objPwd.ShowDialog();
        }

        private void tsbAddStudent_Click(object sender, EventArgs e)
        {
            tsmiAddStudent_Click(null, null);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tsmiManageStudent_Click(null, null);
        }
        private void tsbScoreAnalysis_Click(object sender, EventArgs e)
        {
            tsmiQueryAndAnalysis_Click(null, null);
        }
        private void tsbModifyPwd_Click(object sender, EventArgs e)
        {
            tmiModifyPwd_Click(null, null);
        }
        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsbQuery_Click(object sender, EventArgs e)
        {
            tsmiQuery_Click(null, null);
        }   
     
        //���ʹ���
        private void tsmi_linkxkt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", "http://www.xiketang.com");
        }

        private void tsmi_about_Click(object sender, EventArgs e)
        {
            FrmAbout objAbout = new FrmAbout();
            objAbout.Show();
        }

        #endregion

        /// <summary>
        /// ���ѧԱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStuInsert_Click(object sender, EventArgs e)
        {
            //������Ӧ��ť�Ĵ���Ķ���
            FrmAddStudent frmAddStudent = new FrmAddStudent();
            ShowForm(frmAddStudent);
        }

        /// <summary>
        /// Ƕ�봰��ĳ��÷���
        /// </summary>
        public  void ShowForm(Form objfrm)
        {
            //�ж��������Ƿ��б�Ĵ�����ڣ�����������ر�
            foreach (Control item in this.panelForm.Controls)
            {
                if (item is Form)//�ж������е��Ƿ��Ǵ��壬��Ϊ����Ƕ�룬������Ϊ����������ʹ�����ϱ任
                {
                    Form frm = (Form)item;//����ת��Ϊ�������֮����ر�
                    frm.Close();
                }
            }
            //Ƕ�봰��Ĳ���
            //1�����Ӵ������óɷǶ����ؼ�����������ſ�����ʾ�������Ϸ�
            objfrm.TopLevel = false;
            //2��ȥ������ı߿�
            objfrm.FormBorderStyle = FormBorderStyle.None;
            //3��ָ���Ӵ�����ʾ��������ָ������ĸ���
            objfrm.Parent = this.panelForm;
            //4�����ô������������Ĵ�С�Զ�����������Ĵ�С
            objfrm.Dock = DockStyle.Fill;
            //5����ʾ����
            this.lblTitle.Visible = false;
            objfrm.Show();
        }

        #region  ��ť�����Ƕ��
        /// <summary>
        /// ѧԱ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStunInfos_Click(object sender, EventArgs e)
        {
            FrmStudentManage objForm=new FrmStudentManage();
            ShowForm(objForm);
        }

        /// <summary>
        /// ���ڴ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCard_Click(object sender, EventArgs e)
        {
            FrmAddStudent objForm=new FrmAddStudent();
            ShowForm(objForm);
        }

        /// <summary>
        /// ���ڲ�ѯ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCardInfos_Click(object sender, EventArgs e)
        {
            FrmAttendance objForm=new FrmAttendance();
            ShowForm(objForm);
        }

        /// <summary>
        /// �ɼ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScoreInfos_Click(object sender, EventArgs e)
        {
           FrmScoreQuery objForm=new FrmScoreQuery();
            ShowForm(objForm);
        }

        /// <summary>
        /// �ɼ�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScore_Click(object sender, EventArgs e)
        {
            FrmScoreManage objForm=new FrmScoreManage();
            ShowForm(objForm);
        }

        /// <summary>
        /// �����޸�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdminPwd_Click(object sender, EventArgs e)
        {
            FrmModifyPwd objForm=new FrmModifyPwd();
            ShowForm(objForm);
        }

        /// <summary>
        /// �˺��л�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdminUser_Click(object sender, EventArgs e)
        {
            FrmUserLogin objForm=new FrmUserLogin();
            objForm.Text = "�˺��л�";
            DialogResult result= objForm.ShowDialog();
            if (result==DialogResult.OK)
            {
                this.lblCurrentUser.Text = Program.adminModel.AdminName + "]";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3_Click(object sender, EventArgs e)
        {
            FrmAbout objForm=new FrmAbout();
            ShowForm(objForm);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            FrmStudentInfo objForm=new FrmStudentInfo();
            ShowForm(objForm);
        }
        #endregion

        /// <summary>
        /// ϵͳ�ر�ǰ��ȷ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("�˳�ѯ��","ȷ���˳�",MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question  );//messageboxbuttons.okcancel��������ȷ�Ϻ�ȡ����ť��
            //messageboxlcon.question��������һ���ʺ�ͼƬ
            if (dialogResult!=DialogResult.OK)
            {
                e.Cancel= true; //���ߴ���ر�����¼�ȡ��
            }
        }
    }
}