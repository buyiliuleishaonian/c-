namespace 石头剪刀布
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
            this.labplayer = new System.Windows.Forms.Label();
            this.labelnumber = new System.Windows.Forms.Label();
            this.labcomputer = new System.Windows.Forms.Label();
            this.labernumber1 = new System.Windows.Forms.Label();
            this.labcaipan = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnshitou = new System.Windows.Forms.Button();
            this.btnjiandao = new System.Windows.Forms.Button();
            this.btnbu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labplayer
            // 
            this.labplayer.AutoSize = true;
            this.labplayer.Location = new System.Drawing.Point(141, 92);
            this.labplayer.Name = "labplayer";
            this.labplayer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labplayer.Size = new System.Drawing.Size(29, 12);
            this.labplayer.TabIndex = 0;
            this.labplayer.Text = "玩家";
            // 
            // labelnumber
            // 
            this.labelnumber.AutoSize = true;
            this.labelnumber.Location = new System.Drawing.Point(275, 92);
            this.labelnumber.Name = "labelnumber";
            this.labelnumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelnumber.Size = new System.Drawing.Size(41, 12);
            this.labelnumber.TabIndex = 1;
            this.labelnumber.Text = "label2";
            // 
            // labcomputer
            // 
            this.labcomputer.AutoSize = true;
            this.labcomputer.Location = new System.Drawing.Point(632, 92);
            this.labcomputer.Name = "labcomputer";
            this.labcomputer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labcomputer.Size = new System.Drawing.Size(29, 12);
            this.labcomputer.TabIndex = 2;
            this.labcomputer.Text = "电脑";
            // 
            // labernumber1
            // 
            this.labernumber1.AutoSize = true;
            this.labernumber1.Location = new System.Drawing.Point(783, 92);
            this.labernumber1.Name = "labernumber1";
            this.labernumber1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labernumber1.Size = new System.Drawing.Size(41, 12);
            this.labernumber1.TabIndex = 3;
            this.labernumber1.Text = "label4";
            // 
            // labcaipan
            // 
            this.labcaipan.AutoSize = true;
            this.labcaipan.Location = new System.Drawing.Point(409, 288);
            this.labcaipan.Name = "labcaipan";
            this.labcaipan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labcaipan.Size = new System.Drawing.Size(29, 12);
            this.labcaipan.TabIndex = 4;
            this.labcaipan.Text = "裁判";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(562, 288);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // btnshitou
            // 
            this.btnshitou.Location = new System.Drawing.Point(198, 407);
            this.btnshitou.Name = "btnshitou";
            this.btnshitou.Size = new System.Drawing.Size(104, 31);
            this.btnshitou.TabIndex = 6;
            this.btnshitou.Text = "石头";
            this.btnshitou.UseVisualStyleBackColor = true;
            this.btnshitou.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnjiandao
            // 
            this.btnjiandao.Location = new System.Drawing.Point(411, 407);
            this.btnjiandao.Name = "btnjiandao";
            this.btnjiandao.Size = new System.Drawing.Size(104, 31);
            this.btnjiandao.TabIndex = 7;
            this.btnjiandao.Text = "剪刀";
            this.btnjiandao.UseVisualStyleBackColor = true;
            this.btnjiandao.Click += new System.EventHandler(this.btnjiandao_Click);
            // 
            // btnbu
            // 
            this.btnbu.Location = new System.Drawing.Point(686, 407);
            this.btnbu.Name = "btnbu";
            this.btnbu.Size = new System.Drawing.Size(104, 31);
            this.btnbu.TabIndex = 8;
            this.btnbu.Text = "布";
            this.btnbu.UseVisualStyleBackColor = true;
            this.btnbu.Click += new System.EventHandler(this.btndao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 626);
            this.Controls.Add(this.btnbu);
            this.Controls.Add(this.btnjiandao);
            this.Controls.Add(this.btnshitou);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labcaipan);
            this.Controls.Add(this.labernumber1);
            this.Controls.Add(this.labcomputer);
            this.Controls.Add(this.labelnumber);
            this.Controls.Add(this.labplayer);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labplayer;
        private System.Windows.Forms.Label labelnumber;
        private System.Windows.Forms.Label labcomputer;
        private System.Windows.Forms.Label labernumber1;
        private System.Windows.Forms.Label labcaipan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnshitou;
        private System.Windows.Forms.Button btnjiandao;
        private System.Windows.Forms.Button btnbu;
    }
}

