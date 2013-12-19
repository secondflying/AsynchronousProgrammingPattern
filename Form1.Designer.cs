namespace AsynchronousProgrammingPattern
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(438, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "http://www.sina.com.cn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(535, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(296, 566);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "将同步方法封装为Delegate后异步调用";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(34, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 71);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "APM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "使用WebRequest内置的异步方法";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(34, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 219);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EAP";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(256, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "使用WebClient内置的异步方法";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(298, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "取消";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 190);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(457, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(298, 74);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "取消";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(17, 74);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(256, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "使用BackgroundWorker封装WebRequest";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 605);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}

