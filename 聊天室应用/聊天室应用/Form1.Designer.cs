namespace 聊天室应用
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
            this.btnzd = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.textpath = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textfile = new System.Windows.Forms.TextBox();
            this.cmbip = new System.Windows.Forms.ComboBox();
            this.btnreceive = new System.Windows.Forms.Button();
            this.textlog = new System.Windows.Forms.TextBox();
            this.textmsg = new System.Windows.Forms.TextBox();
            this.textPoint = new System.Windows.Forms.TextBox();
            this.textip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnzd
            // 
            this.btnzd.Location = new System.Drawing.Point(1036, 390);
            this.btnzd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnzd.Name = "btnzd";
            this.btnzd.Size = new System.Drawing.Size(67, 31);
            this.btnzd.TabIndex = 21;
            this.btnzd.Text = "震动";
            this.btnzd.UseVisualStyleBackColor = true;
            this.btnzd.Click += new System.EventHandler(this.btnzd_Click);
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(908, 390);
            this.btnsend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(67, 29);
            this.btnsend.TabIndex = 20;
            this.btnsend.Text = "发送";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // textpath
            // 
            this.textpath.Location = new System.Drawing.Point(1036, 119);
            this.textpath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textpath.Name = "textpath";
            this.textpath.Size = new System.Drawing.Size(98, 19);
            this.textpath.TabIndex = 19;
            this.textpath.Text = "发送文件";
            this.textpath.UseVisualStyleBackColor = true;
            this.textpath.Click += new System.EventHandler(this.textpath_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(892, 119);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 21);
            this.button1.TabIndex = 18;
            this.button1.Text = "选择文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textfile
            // 
            this.textfile.Location = new System.Drawing.Point(884, 78);
            this.textfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textfile.Name = "textfile";
            this.textfile.Size = new System.Drawing.Size(264, 21);
            this.textfile.TabIndex = 17;
            // 
            // cmbip
            // 
            this.cmbip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbip.FormattingEnabled = true;
            this.cmbip.Location = new System.Drawing.Point(665, 29);
            this.cmbip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbip.Name = "cmbip";
            this.cmbip.Size = new System.Drawing.Size(200, 20);
            this.cmbip.TabIndex = 16;
            // 
            // btnreceive
            // 
            this.btnreceive.Location = new System.Drawing.Point(549, 29);
            this.btnreceive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnreceive.Name = "btnreceive";
            this.btnreceive.Size = new System.Drawing.Size(76, 19);
            this.btnreceive.TabIndex = 15;
            this.btnreceive.Text = "连接";
            this.btnreceive.UseVisualStyleBackColor = true;
            this.btnreceive.Click += new System.EventHandler(this.btnreceive_Click);
            // 
            // textlog
            // 
            this.textlog.Location = new System.Drawing.Point(166, 302);
            this.textlog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textlog.Multiline = true;
            this.textlog.Name = "textlog";
            this.textlog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textlog.Size = new System.Drawing.Size(660, 235);
            this.textlog.TabIndex = 14;
            // 
            // textmsg
            // 
            this.textmsg.Location = new System.Drawing.Point(166, 63);
            this.textmsg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textmsg.Multiline = true;
            this.textmsg.Name = "textmsg";
            this.textmsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textmsg.Size = new System.Drawing.Size(660, 235);
            this.textmsg.TabIndex = 13;
            // 
            // textPoint
            // 
            this.textPoint.Location = new System.Drawing.Point(417, 29);
            this.textPoint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textPoint.Name = "textPoint";
            this.textPoint.Size = new System.Drawing.Size(90, 21);
            this.textPoint.TabIndex = 12;
            this.textPoint.Text = "50000";
            // 
            // textip
            // 
            this.textip.Location = new System.Drawing.Point(166, 30);
            this.textip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textip.Name = "textip";
            this.textip.Size = new System.Drawing.Size(192, 21);
            this.textip.TabIndex = 11;
            this.textip.Text = "192.168.1.122";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 565);
            this.Controls.Add(this.btnzd);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.textpath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textfile);
            this.Controls.Add(this.cmbip);
            this.Controls.Add(this.btnreceive);
            this.Controls.Add(this.textlog);
            this.Controls.Add(this.textmsg);
            this.Controls.Add(this.textPoint);
            this.Controls.Add(this.textip);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "服务器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnzd;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Button textpath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textfile;
        private System.Windows.Forms.ComboBox cmbip;
        private System.Windows.Forms.Button btnreceive;
        private System.Windows.Forms.TextBox textlog;
        private System.Windows.Forms.TextBox textmsg;
        private System.Windows.Forms.TextBox textPoint;
        private System.Windows.Forms.TextBox textip;
    }
}

