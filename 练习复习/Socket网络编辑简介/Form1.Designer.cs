namespace Socket网络编辑简介
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
            this.textserver = new System.Windows.Forms.TextBox();
            this.textport = new System.Windows.Forms.TextBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.textlog = new System.Windows.Forms.TextBox();
            this.textMsg = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textpath = new System.Windows.Forms.TextBox();
            this.btnxz = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.cboUsers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textserver
            // 
            this.textserver.Location = new System.Drawing.Point(196, 150);
            this.textserver.Margin = new System.Windows.Forms.Padding(4);
            this.textserver.Name = "textserver";
            this.textserver.Size = new System.Drawing.Size(247, 25);
            this.textserver.TabIndex = 0;
            this.textserver.Text = "192.168.0.33";
            // 
            // textport
            // 
            this.textport.Location = new System.Drawing.Point(504, 150);
            this.textport.Margin = new System.Windows.Forms.Padding(4);
            this.textport.Multiline = true;
            this.textport.Name = "textport";
            this.textport.Size = new System.Drawing.Size(100, 24);
            this.textport.TabIndex = 1;
            this.textport.Text = "50000";
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(669, 150);
            this.btnstart.Margin = new System.Windows.Forms.Padding(4);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(153, 25);
            this.btnstart.TabIndex = 2;
            this.btnstart.Text = "连接";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // textlog
            // 
            this.textlog.Location = new System.Drawing.Point(177, 182);
            this.textlog.Margin = new System.Windows.Forms.Padding(4);
            this.textlog.Multiline = true;
            this.textlog.Name = "textlog";
            this.textlog.Size = new System.Drawing.Size(1015, 226);
            this.textlog.TabIndex = 3;
            // 
            // textMsg
            // 
            this.textMsg.Location = new System.Drawing.Point(177, 419);
            this.textMsg.Margin = new System.Windows.Forms.Padding(4);
            this.textMsg.Multiline = true;
            this.textMsg.Name = "textMsg";
            this.textMsg.Size = new System.Drawing.Size(1015, 255);
            this.textMsg.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1211, 702);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "发送文件";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textpath
            // 
            this.textpath.Location = new System.Drawing.Point(191, 704);
            this.textpath.Margin = new System.Windows.Forms.Padding(4);
            this.textpath.Name = "textpath";
            this.textpath.Size = new System.Drawing.Size(799, 25);
            this.textpath.TabIndex = 6;
            // 
            // btnxz
            // 
            this.btnxz.Location = new System.Drawing.Point(1043, 698);
            this.btnxz.Margin = new System.Windows.Forms.Padding(4);
            this.btnxz.Name = "btnxz";
            this.btnxz.Size = new System.Drawing.Size(87, 36);
            this.btnxz.TabIndex = 7;
            this.btnxz.Text = "选择";
            this.btnxz.UseVisualStyleBackColor = true;
            this.btnxz.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1304, 556);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 39);
            this.button4.TabIndex = 8;
            this.button4.Text = "发送消息";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1304, 616);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 38);
            this.button5.TabIndex = 9;
            this.button5.Text = "震动";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1296, 138);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 45);
            this.button6.TabIndex = 10;
            this.button6.Text = "button1";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // cboUsers
            // 
            this.cboUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Location = new System.Drawing.Point(887, 149);
            this.cboUsers.Margin = new System.Windows.Forms.Padding(4);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(220, 23);
            this.cboUsers.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 770);
            this.Controls.Add(this.cboUsers);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnxz);
            this.Controls.Add(this.textpath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textMsg);
            this.Controls.Add(this.textlog);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.textport);
            this.Controls.Add(this.textserver);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "服务器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textserver;
        private System.Windows.Forms.TextBox textport;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.TextBox textlog;
        private System.Windows.Forms.TextBox textMsg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textpath;
        private System.Windows.Forms.Button btnxz;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox cboUsers;
    }
}

