namespace 老师或者学生登入
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labname = new System.Windows.Forms.Label();
            this.labpass = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.btngo = new System.Windows.Forms.Button();
            this.radstudent = new System.Windows.Forms.RadioButton();
            this.radteacher = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Location = new System.Drawing.Point(225, 120);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(41, 12);
            this.labname.TabIndex = 0;
            this.labname.Text = "用户名";
            // 
            // labpass
            // 
            this.labpass.AutoSize = true;
            this.labpass.Location = new System.Drawing.Point(224, 176);
            this.labpass.Name = "labpass";
            this.labpass.Size = new System.Drawing.Size(29, 12);
            this.labpass.TabIndex = 1;
            this.labpass.Text = "密码";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(343, 117);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(321, 21);
            this.textname.TabIndex = 2;
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(343, 173);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(321, 21);
            this.textpass.TabIndex = 3;
            // 
            // btngo
            // 
            this.btngo.Location = new System.Drawing.Point(302, 357);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(76, 21);
            this.btngo.TabIndex = 4;
            this.btngo.Text = "登入";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // radstudent
            // 
            this.radstudent.AutoSize = true;
            this.radstudent.Location = new System.Drawing.Point(305, 276);
            this.radstudent.Name = "radstudent";
            this.radstudent.Size = new System.Drawing.Size(47, 16);
            this.radstudent.TabIndex = 5;
            this.radstudent.TabStop = true;
            this.radstudent.Text = "学生";
            this.radstudent.UseVisualStyleBackColor = true;
            // 
            // radteacher
            // 
            this.radteacher.AutoSize = true;
            this.radteacher.Location = new System.Drawing.Point(529, 276);
            this.radteacher.Name = "radteacher";
            this.radteacher.Size = new System.Drawing.Size(47, 16);
            this.radteacher.TabIndex = 6;
            this.radteacher.TabStop = true;
            this.radteacher.Text = "老师";
            this.radteacher.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 646);
            this.Controls.Add(this.radteacher);
            this.Controls.Add(this.radstudent);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.labpass);
            this.Controls.Add(this.labname);
            this.Name = "Form1";
            this.Text = "主窗体";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.Label labpass;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.RadioButton radstudent;
        private System.Windows.Forms.RadioButton radteacher;
    }
}

