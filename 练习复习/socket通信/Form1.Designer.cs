namespace socket通信
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textMsg = new System.Windows.Forms.TextBox();
            this.textlog = new System.Windows.Forms.TextBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.textport = new System.Windows.Forms.TextBox();
            this.textserver = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(574, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 20);
            this.comboBox1.TabIndex = 24;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(881, 75);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 36);
            this.button6.TabIndex = 23;
            this.button6.Text = "button1";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(831, 522);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 30);
            this.button5.TabIndex = 22;
            this.button5.Text = "震动";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(703, 522);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 31);
            this.button4.TabIndex = 21;
            this.button4.Text = "发送消息";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(897, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 29);
            this.button3.TabIndex = 20;
            this.button3.Text = "选择";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(52, 528);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(600, 21);
            this.textBox5.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(874, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 20);
            this.button2.TabIndex = 18;
            this.button2.Text = "发送信息";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textMsg
            // 
            this.textMsg.Location = new System.Drawing.Point(42, 300);
            this.textMsg.Multiline = true;
            this.textMsg.Name = "textMsg";
            this.textMsg.Size = new System.Drawing.Size(762, 205);
            this.textMsg.TabIndex = 17;
            // 
            // textlog
            // 
            this.textlog.Location = new System.Drawing.Point(42, 111);
            this.textlog.Multiline = true;
            this.textlog.Name = "textlog";
            this.textlog.Size = new System.Drawing.Size(762, 182);
            this.textlog.TabIndex = 16;
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(411, 85);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(115, 20);
            this.btnstart.TabIndex = 15;
            this.btnstart.Text = "连接";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // textport
            // 
            this.textport.Location = new System.Drawing.Point(287, 85);
            this.textport.Multiline = true;
            this.textport.Name = "textport";
            this.textport.Size = new System.Drawing.Size(76, 20);
            this.textport.TabIndex = 14;
            this.textport.Text = "50001";
            // 
            // textserver
            // 
            this.textserver.Location = new System.Drawing.Point(56, 85);
            this.textserver.Name = "textserver";
            this.textserver.Size = new System.Drawing.Size(186, 21);
            this.textserver.TabIndex = 13;
            this.textserver.Text = "192.168.1.122";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 628);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textMsg);
            this.Controls.Add(this.textlog);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.textport);
            this.Controls.Add(this.textserver);
            this.Name = "Form1";
            this.Text = "服务器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textMsg;
        private System.Windows.Forms.TextBox textlog;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.TextBox textport;
        private System.Windows.Forms.TextBox textserver;
    }
}

