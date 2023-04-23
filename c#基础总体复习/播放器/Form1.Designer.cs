namespace 播放器
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnplayerorpuase = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.btndirectory = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muiscplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnshang = new System.Windows.Forms.Button();
            this.btnxia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muiscplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "播放";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "停止";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "暂停";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(918, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 198);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnplayerorpuase
            // 
            this.btnplayerorpuase.Location = new System.Drawing.Point(37, 471);
            this.btnplayerorpuase.Name = "btnplayerorpuase";
            this.btnplayerorpuase.Size = new System.Drawing.Size(98, 29);
            this.btnplayerorpuase.TabIndex = 5;
            this.btnplayerorpuase.Text = "播放";
            this.btnplayerorpuase.UseVisualStyleBackColor = true;
            this.btnplayerorpuase.Click += new System.EventHandler(this.btnplayerorpuase_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(213, 471);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(98, 29);
            this.btnstop.TabIndex = 6;
            this.btnstop.Text = "停止";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btndirectory
            // 
            this.btndirectory.Location = new System.Drawing.Point(609, 21);
            this.btndirectory.Name = "btndirectory";
            this.btndirectory.Size = new System.Drawing.Size(98, 29);
            this.btndirectory.TabIndex = 7;
            this.btndirectory.Text = "打开文件";
            this.btndirectory.UseVisualStyleBackColor = true;
            this.btndirectory.Click += new System.EventHandler(this.btndirectory_Click);
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(609, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(264, 292);
            this.listBox1.TabIndex = 8;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // muiscplayer
            // 
            this.muiscplayer.Enabled = true;
            this.muiscplayer.Location = new System.Drawing.Point(12, 12);
            this.muiscplayer.Name = "muiscplayer";
            this.muiscplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("muiscplayer.OcxState")));
            this.muiscplayer.Size = new System.Drawing.Size(518, 420);
            this.muiscplayer.TabIndex = 0;
            // 
            // btnshang
            // 
            this.btnshang.Location = new System.Drawing.Point(44, 529);
            this.btnshang.Name = "btnshang";
            this.btnshang.Size = new System.Drawing.Size(91, 29);
            this.btnshang.TabIndex = 9;
            this.btnshang.Text = "下一曲";
            this.btnshang.UseVisualStyleBackColor = true;
            this.btnshang.Click += new System.EventHandler(this.btnshang_Click);
            // 
            // btnxia
            // 
            this.btnxia.Location = new System.Drawing.Point(213, 529);
            this.btnxia.Name = "btnxia";
            this.btnxia.Size = new System.Drawing.Size(91, 29);
            this.btnxia.TabIndex = 10;
            this.btnxia.Text = "上一曲";
            this.btnxia.UseVisualStyleBackColor = true;
            this.btnxia.Click += new System.EventHandler(this.btnxia_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(404, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 123);
            this.label1.TabIndex = 12;
            this.label1.Tag = "0";
            this.label1.Text = "静音";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(759, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // lab3
            // 
            this.lab3.Location = new System.Drawing.Point(332, 621);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(541, 88);
            this.lab3.TabIndex = 14;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 792);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnxia);
            this.Controls.Add(this.btnshang);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btndirectory);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnplayerorpuase);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.muiscplayer);
            this.Name = "Form1";
            this.Text = "播放器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.muiscplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer muiscplayer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnplayerorpuase;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btndirectory;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnshang;
        private System.Windows.Forms.Button btnxia;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Timer timer2;
    }
}

