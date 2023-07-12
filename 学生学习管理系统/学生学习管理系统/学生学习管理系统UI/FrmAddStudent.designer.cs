namespace StudentManager
{
    partial class FrmAddStudent
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentIdNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cboClassName = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.pbStu = new System.Windows.Forms.PictureBox();
            this.btnChoseImage = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPaiZhao = new System.Windows.Forms.Button();
            this.btnStartSX = new System.Windows.Forms.Button();
            this.btnEndSX = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brithday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeridNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GardNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbStu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生姓名：";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(121, 40);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(188, 25);
            this.txtStudentName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "性别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "出生日期：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "身份证号：";
            // 
            // txtStudentIdNo
            // 
            this.txtStudentIdNo.Location = new System.Drawing.Point(435, 94);
            this.txtStudentIdNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudentIdNo.Name = "txtStudentIdNo";
            this.txtStudentIdNo.Size = new System.Drawing.Size(309, 25);
            this.txtStudentIdNo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "联系电话：";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(435, 148);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(309, 25);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "家庭住址：";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(121, 204);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(623, 25);
            this.txtAddress.TabIndex = 8;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(400, 42);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(43, 19);
            this.rdoMale.TabIndex = 1;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(455, 42);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(43, 19);
            this.rdoFemale.TabIndex = 2;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(605, 40);
            this.dtpBirthday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(139, 25);
            this.dtpBirthday.TabIndex = 3;
            this.dtpBirthday.Value = new System.DateTime(2001, 6, 9, 20, 49, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "所在班级：";
            // 
            // cboClassName
            // 
            this.cboClassName.FormattingEnabled = true;
            this.cboClassName.Location = new System.Drawing.Point(121, 94);
            this.cboClassName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboClassName.Name = "cboClassName";
            this.cboClassName.Size = new System.Drawing.Size(188, 23);
            this.cboClassName.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(873, 45);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 29);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "确认添加";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(997, 45);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 29);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 152);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "考勤卡号：";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(120, 148);
            this.txtCardNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(189, 25);
            this.txtCardNo.TabIndex = 6;
            // 
            // pbStu
            // 
            this.pbStu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStu.Location = new System.Drawing.Point(44, 105);
            this.pbStu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbStu.Name = "pbStu";
            this.pbStu.Size = new System.Drawing.Size(251, 246);
            this.pbStu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStu.TabIndex = 11;
            this.pbStu.TabStop = false;
            // 
            // btnChoseImage
            // 
            this.btnChoseImage.Location = new System.Drawing.Point(115, 359);
            this.btnChoseImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChoseImage.Name = "btnChoseImage";
            this.btnChoseImage.Size = new System.Drawing.Size(131, 29);
            this.btnChoseImage.TabIndex = 12;
            this.btnChoseImage.Text = "选择照片";
            this.btnChoseImage.UseVisualStyleBackColor = true;
            this.btnChoseImage.Click += new System.EventHandler(this.btnChoseImage_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(36, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 42);
            this.label9.TabIndex = 0;
            this.label9.Text = "添加新学员";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rdoMale);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboClassName);
            this.groupBox1.Controls.Add(this.rdoFemale);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCardNo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpBirthday);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtStudentIdNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(675, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(783, 260);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[学员基本信息]";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student,
            this.studentName,
            this.Gender,
            this.brithday,
            this.GeridNO,
            this.GardNO,
            this.ClassID});
            this.dataGridView1.Location = new System.Drawing.Point(89, 510);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1169, 251);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(333, 105);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnPaiZhao
            // 
            this.btnPaiZhao.Location = new System.Drawing.Point(397, 359);
            this.btnPaiZhao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPaiZhao.Name = "btnPaiZhao";
            this.btnPaiZhao.Size = new System.Drawing.Size(131, 29);
            this.btnPaiZhao.TabIndex = 16;
            this.btnPaiZhao.Text = "开始拍照";
            this.btnPaiZhao.UseVisualStyleBackColor = true;
            // 
            // btnStartSX
            // 
            this.btnStartSX.Location = new System.Drawing.Point(115, 420);
            this.btnStartSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartSX.Name = "btnStartSX";
            this.btnStartSX.Size = new System.Drawing.Size(131, 29);
            this.btnStartSX.TabIndex = 17;
            this.btnStartSX.Text = "启动摄像头";
            this.btnStartSX.UseVisualStyleBackColor = true;
            // 
            // btnEndSX
            // 
            this.btnEndSX.Location = new System.Drawing.Point(397, 420);
            this.btnEndSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEndSX.Name = "btnEndSX";
            this.btnEndSX.Size = new System.Drawing.Size(131, 29);
            this.btnEndSX.TabIndex = 18;
            this.btnEndSX.Text = "关闭摄像头";
            this.btnEndSX.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(259, 420);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 29);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "清除照片";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // student
            // 
            this.student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.student.DataPropertyName = "studentid";
            this.student.HeaderText = "学员";
            this.student.MinimumWidth = 6;
            this.student.Name = "student";
            this.student.ReadOnly = true;
            this.student.Width = 134;
            // 
            // studentName
            // 
            this.studentName.DataPropertyName = "studentname";
            this.studentName.HeaderText = "姓名";
            this.studentName.MinimumWidth = 6;
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            this.studentName.Width = 125;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "gender";
            this.Gender.HeaderText = "性别";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 125;
            // 
            // brithday
            // 
            this.brithday.DataPropertyName = "bithday";
            this.brithday.HeaderText = "出生日期";
            this.brithday.MinimumWidth = 6;
            this.brithday.Name = "brithday";
            this.brithday.ReadOnly = true;
            this.brithday.Width = 125;
            // 
            // GeridNO
            // 
            this.GeridNO.DataPropertyName = "studentidno";
            this.GeridNO.HeaderText = "身份证号";
            this.GeridNO.MinimumWidth = 6;
            this.GeridNO.Name = "GeridNO";
            this.GeridNO.ReadOnly = true;
            this.GeridNO.Width = 150;
            // 
            // GardNO
            // 
            this.GardNO.DataPropertyName = "cardno";
            this.GardNO.HeaderText = "考勤卡号";
            this.GardNO.MinimumWidth = 6;
            this.GardNO.Name = "GardNO";
            this.GardNO.ReadOnly = true;
            this.GardNO.Width = 150;
            // 
            // ClassID
            // 
            this.ClassID.DataPropertyName = "classname";
            this.ClassID.HeaderText = "班级";
            this.ClassID.MinimumWidth = 6;
            this.ClassID.Name = "ClassID";
            this.ClassID.ReadOnly = true;
            this.ClassID.Width = 125;
            // 
            // FrmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 805);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEndSX);
            this.Controls.Add(this.btnStartSX);
            this.Controls.Add(this.btnPaiZhao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnChoseImage);
            this.Controls.Add(this.pbStu);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label9);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加新学员";
            ((System.ComponentModel.ISupportInitialize)(this.pbStu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentIdNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboClassName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.PictureBox pbStu;
        private System.Windows.Forms.Button btnChoseImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPaiZhao;
        private System.Windows.Forms.Button btnStartSX;
        private System.Windows.Forms.Button btnEndSX;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn student;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn brithday;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeridNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GardNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
    }
}