namespace IMG128
{
    partial class output
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cBoxOutRstMode1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxOutWire1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxOutMode1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tBoxDuration1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxOutDelay1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rBtnIgnoreLearn1 = new System.Windows.Forms.RadioButton();
            this.rBtnIgnoreFirst1 = new System.Windows.Forms.RadioButton();
            this.rBtnNormal1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBtnNC1 = new System.Windows.Forms.RadioButton();
            this.rBtnNO1 = new System.Windows.Forms.RadioButton();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBoxOutRstMode1
            // 
            this.cBoxOutRstMode1.Enabled = false;
            this.cBoxOutRstMode1.FormattingEnabled = true;
            this.cBoxOutRstMode1.Items.AddRange(new object[] {
            "延时自动复位"});
            this.cBoxOutRstMode1.Location = new System.Drawing.Point(302, 213);
            this.cBoxOutRstMode1.Name = "cBoxOutRstMode1";
            this.cBoxOutRstMode1.Size = new System.Drawing.Size(121, 20);
            this.cBoxOutRstMode1.TabIndex = 22;
            this.cBoxOutRstMode1.Text = "延时自动复位";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "输出复位模式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "线型";
            // 
            // cBoxOutWire1
            // 
            this.cBoxOutWire1.FormattingEnabled = true;
            this.cBoxOutWire1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cBoxOutWire1.Location = new System.Drawing.Point(60, 142);
            this.cBoxOutWire1.Name = "cBoxOutWire1";
            this.cBoxOutWire1.Size = new System.Drawing.Size(121, 20);
            this.cBoxOutWire1.TabIndex = 19;
            this.cBoxOutWire1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "输出模式";
            // 
            // cBoxOutMode1
            // 
            this.cBoxOutMode1.FormattingEnabled = true;
            this.cBoxOutMode1.Items.AddRange(new object[] {
            "合格品输出脉冲",
            "不良品输出脉冲",
            "合格/不良品都输出脉冲"});
            this.cBoxOutMode1.Location = new System.Drawing.Point(60, 110);
            this.cBoxOutMode1.Name = "cBoxOutMode1";
            this.cBoxOutMode1.Size = new System.Drawing.Size(121, 20);
            this.cBoxOutMode1.TabIndex = 17;
            this.cBoxOutMode1.Text = "合格品输出脉冲";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tBoxDuration1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.tBoxOutDelay1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(212, 113);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 91);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "复位时间";
            // 
            // tBoxDuration1
            // 
            this.tBoxDuration1.Location = new System.Drawing.Point(111, 54);
            this.tBoxDuration1.Name = "tBoxDuration1";
            this.tBoxDuration1.Size = new System.Drawing.Size(100, 21);
            this.tBoxDuration1.TabIndex = 13;
            this.tBoxDuration1.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "持续时间(ms)";
            // 
            // tBoxOutDelay1
            // 
            this.tBoxOutDelay1.Location = new System.Drawing.Point(111, 27);
            this.tBoxOutDelay1.Name = "tBoxOutDelay1";
            this.tBoxOutDelay1.Size = new System.Drawing.Size(100, 21);
            this.tBoxOutDelay1.TabIndex = 11;
            this.tBoxOutDelay1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "延时输出(ms)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rBtnIgnoreLearn1);
            this.groupBox3.Controls.Add(this.rBtnIgnoreFirst1);
            this.groupBox3.Controls.Add(this.rBtnNormal1);
            this.groupBox3.Location = new System.Drawing.Point(212, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 90);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "输出选项";
            // 
            // rBtnIgnoreLearn1
            // 
            this.rBtnIgnoreLearn1.AutoSize = true;
            this.rBtnIgnoreLearn1.Location = new System.Drawing.Point(20, 64);
            this.rBtnIgnoreLearn1.Name = "rBtnIgnoreLearn1";
            this.rBtnIgnoreLearn1.Size = new System.Drawing.Size(95, 16);
            this.rBtnIgnoreLearn1.TabIndex = 3;
            this.rBtnIgnoreLearn1.Text = "忽略所有学习";
            this.rBtnIgnoreLearn1.UseVisualStyleBackColor = true;
            // 
            // rBtnIgnoreFirst1
            // 
            this.rBtnIgnoreFirst1.AutoSize = true;
            this.rBtnIgnoreFirst1.Location = new System.Drawing.Point(20, 42);
            this.rBtnIgnoreFirst1.Name = "rBtnIgnoreFirst1";
            this.rBtnIgnoreFirst1.Size = new System.Drawing.Size(107, 16);
            this.rBtnIgnoreFirst1.TabIndex = 2;
            this.rBtnIgnoreFirst1.Text = "忽略学习第一条";
            this.rBtnIgnoreFirst1.UseVisualStyleBackColor = true;
            // 
            // rBtnNormal1
            // 
            this.rBtnNormal1.AutoSize = true;
            this.rBtnNormal1.Checked = true;
            this.rBtnNormal1.Location = new System.Drawing.Point(20, 21);
            this.rBtnNormal1.Name = "rBtnNormal1";
            this.rBtnNormal1.Size = new System.Drawing.Size(71, 16);
            this.rBtnNormal1.TabIndex = 1;
            this.rBtnNormal1.TabStop = true;
            this.rBtnNormal1.Text = "始终有效";
            this.rBtnNormal1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBtnNC1);
            this.groupBox2.Controls.Add(this.rBtnNO1);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 90);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出状态";
            // 
            // rBtnNC1
            // 
            this.rBtnNC1.AutoSize = true;
            this.rBtnNC1.Location = new System.Drawing.Point(16, 51);
            this.rBtnNC1.Name = "rBtnNC1";
            this.rBtnNC1.Size = new System.Drawing.Size(47, 16);
            this.rBtnNC1.TabIndex = 1;
            this.rBtnNC1.Text = "常闭";
            this.rBtnNC1.UseVisualStyleBackColor = true;
            // 
            // rBtnNO1
            // 
            this.rBtnNO1.AutoSize = true;
            this.rBtnNO1.Checked = true;
            this.rBtnNO1.Location = new System.Drawing.Point(16, 29);
            this.rBtnNO1.Name = "rBtnNO1";
            this.rBtnNO1.Size = new System.Drawing.Size(47, 16);
            this.rBtnNO1.TabIndex = 0;
            this.rBtnNO1.TabStop = true;
            this.rBtnNO1.Text = "常开";
            this.rBtnNO1.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cBoxOutRstMode1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBoxOutWire1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxOutMode1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "output";
            this.Size = new System.Drawing.Size(463, 255);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxOutRstMode1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxOutWire1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxOutMode1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tBoxDuration1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxOutDelay1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rBtnIgnoreLearn1;
        private System.Windows.Forms.RadioButton rBtnIgnoreFirst1;
        private System.Windows.Forms.RadioButton rBtnNormal1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBtnNC1;
        private System.Windows.Forms.RadioButton rBtnNO1;
    }
}
