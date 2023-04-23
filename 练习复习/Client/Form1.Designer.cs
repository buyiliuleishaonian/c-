namespace Client
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
            this.textip = new System.Windows.Forms.TextBox();
            this.textpoint = new System.Windows.Forms.TextBox();
            this.textlog = new System.Windows.Forms.TextBox();
            this.textmsg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textip
            // 
            this.textip.Location = new System.Drawing.Point(180, 102);
            this.textip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textip.Name = "textip";
            this.textip.Size = new System.Drawing.Size(280, 25);
            this.textip.TabIndex = 0;
            this.textip.Text = "192.168.0.33";
            // 
            // textpoint
            // 
            this.textpoint.Location = new System.Drawing.Point(564, 102);
            this.textpoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textpoint.Name = "textpoint";
            this.textpoint.Size = new System.Drawing.Size(183, 25);
            this.textpoint.TabIndex = 1;
            this.textpoint.Text = "50000";
            // 
            // textlog
            // 
            this.textlog.Location = new System.Drawing.Point(184, 170);
            this.textlog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textlog.Multiline = true;
            this.textlog.Name = "textlog";
            this.textlog.Size = new System.Drawing.Size(944, 305);
            this.textlog.TabIndex = 2;
            // 
            // textmsg
            // 
            this.textmsg.Location = new System.Drawing.Point(185, 508);
            this.textmsg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textmsg.Multiline = true;
            this.textmsg.Name = "textmsg";
            this.textmsg.Size = new System.Drawing.Size(941, 248);
            this.textmsg.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1216, 670);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1225, 414);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "发送消息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 794);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textmsg);
            this.Controls.Add(this.textlog);
            this.Controls.Add(this.textpoint);
            this.Controls.Add(this.textip);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "客户端";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textip;
        private System.Windows.Forms.TextBox textpoint;
        private System.Windows.Forms.TextBox textlog;
        private System.Windows.Forms.TextBox textmsg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

