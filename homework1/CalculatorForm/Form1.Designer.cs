namespace CalculatorForm
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
            this.num1Txt = new System.Windows.Forms.TextBox();
            this.num2Txt = new System.Windows.Forms.TextBox();
            this.calBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox1.Location = new System.Drawing.Point(211, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(57, 20);
            this.comboBox1.TabIndex = 0;
            // 
            // num1Txt
            // 
            this.num1Txt.Location = new System.Drawing.Point(66, 86);
            this.num1Txt.Name = "num1Txt";
            this.num1Txt.Size = new System.Drawing.Size(100, 21);
            this.num1Txt.TabIndex = 1;
            // 
            // num2Txt
            // 
            this.num2Txt.Location = new System.Drawing.Point(313, 86);
            this.num2Txt.Name = "num2Txt";
            this.num2Txt.Size = new System.Drawing.Size(100, 21);
            this.num2Txt.TabIndex = 2;
            // 
            // calBtn
            // 
            this.calBtn.Location = new System.Drawing.Point(470, 83);
            this.calBtn.Name = "calBtn";
            this.calBtn.Size = new System.Drawing.Size(75, 23);
            this.calBtn.TabIndex = 3;
            this.calBtn.Text = "计算";
            this.calBtn.UseVisualStyleBackColor = true;
            this.calBtn.Click += new System.EventHandler(this.calBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "计算结果";
            // 
            // resultTxt
            // 
            this.resultTxt.Location = new System.Drawing.Point(147, 159);
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.Size = new System.Drawing.Size(100, 21);
            this.resultTxt.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 261);
            this.Controls.Add(this.resultTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calBtn);
            this.Controls.Add(this.num2Txt);
            this.Controls.Add(this.num1Txt);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox num1Txt;
        private System.Windows.Forms.TextBox num2Txt;
        private System.Windows.Forms.Button calBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultTxt;
    }
}

