namespace 简单记事本应用程序
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.zidonghuanhang = new System.Windows.Forms.Button();
            this.baocun = new System.Windows.Forms.Button();
            this.textnaem = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.btnname = new System.Windows.Forms.Button();
            this.btnpass = new System.Windows.Forms.Button();
            this.btngo = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(76, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(956, 573);
            this.textBox1.TabIndex = 0;
            // 
            // zidonghuanhang
            // 
            this.zidonghuanhang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zidonghuanhang.Location = new System.Drawing.Point(77, 23);
            this.zidonghuanhang.Name = "zidonghuanhang";
            this.zidonghuanhang.Size = new System.Drawing.Size(413, 23);
            this.zidonghuanhang.TabIndex = 1;
            this.zidonghuanhang.Text = "自动换行";
            this.zidonghuanhang.UseVisualStyleBackColor = true;
            this.zidonghuanhang.Click += new System.EventHandler(this.zidonghuanhang_Click);
            // 
            // baocun
            // 
            this.baocun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baocun.Location = new System.Drawing.Point(565, 23);
            this.baocun.Name = "baocun";
            this.baocun.Size = new System.Drawing.Size(431, 19);
            this.baocun.TabIndex = 2;
            this.baocun.Text = "保存";
            this.baocun.UseVisualStyleBackColor = true;
            this.baocun.Click += new System.EventHandler(this.baocun_Click);
            // 
            // textnaem
            // 
            this.textnaem.Location = new System.Drawing.Point(364, 149);
            this.textnaem.Name = "textnaem";
            this.textnaem.Size = new System.Drawing.Size(276, 21);
            this.textnaem.TabIndex = 3;
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(364, 236);
            this.textpass.Name = "textpass";
            this.textpass.PasswordChar = '*';
            this.textpass.Size = new System.Drawing.Size(276, 21);
            this.textpass.TabIndex = 4;
            // 
            // btnname
            // 
            this.btnname.Location = new System.Drawing.Point(230, 150);
            this.btnname.Name = "btnname";
            this.btnname.Size = new System.Drawing.Size(67, 20);
            this.btnname.TabIndex = 5;
            this.btnname.Text = "用户名";
            this.btnname.UseVisualStyleBackColor = true;
            // 
            // btnpass
            // 
            this.btnpass.Location = new System.Drawing.Point(235, 236);
            this.btnpass.Name = "btnpass";
            this.btnpass.Size = new System.Drawing.Size(62, 21);
            this.btnpass.TabIndex = 6;
            this.btnpass.Text = "密码";
            this.btnpass.UseVisualStyleBackColor = true;
            // 
            // btngo
            // 
            this.btngo.Location = new System.Drawing.Point(399, 299);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(75, 23);
            this.btngo.TabIndex = 7;
            this.btngo.Text = "登入";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(565, 299);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(75, 23);
            this.btnstart.TabIndex = 8;
            this.btnstart.Text = "重置";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 658);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.btnpass);
            this.Controls.Add(this.btnname);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.textnaem);
            this.Controls.Add(this.baocun);
            this.Controls.Add(this.zidonghuanhang);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button zidonghuanhang;
        private System.Windows.Forms.Button baocun;
        private System.Windows.Forms.TextBox textnaem;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.Button btnname;
        private System.Windows.Forms.Button btnpass;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.Button btnstart;
    }
}

