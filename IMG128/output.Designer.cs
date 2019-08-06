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
            this.cBoxOutRstMode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxOutWire = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxOutMode = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tBoxDuration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxOutDelay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rBtnIgnoreLearn = new System.Windows.Forms.RadioButton();
            this.rBtnIgnoreFirst = new System.Windows.Forms.RadioButton();
            this.rBtnNormal = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.rBtnNC = new System.Windows.Forms.RadioButton();
            this.rBtnNO = new System.Windows.Forms.RadioButton();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBoxOutRstMode
            // 
            this.cBoxOutRstMode.Enabled = false;
            this.cBoxOutRstMode.FormattingEnabled = true;
            this.cBoxOutRstMode.Items.AddRange(new object[] {
            "延时自动复位"});
            this.cBoxOutRstMode.Location = new System.Drawing.Point(302, 213);
            this.cBoxOutRstMode.Name = "cBoxOutRstMode";
            this.cBoxOutRstMode.Size = new System.Drawing.Size(121, 20);
            this.cBoxOutRstMode.TabIndex = 22;
            this.cBoxOutRstMode.Text = "延时自动复位";
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
            // cBoxOutWire
            // 
            this.cBoxOutWire.FormattingEnabled = true;
            this.cBoxOutWire.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cBoxOutWire.Location = new System.Drawing.Point(60, 142);
            this.cBoxOutWire.Name = "cBoxOutWire";
            this.cBoxOutWire.Size = new System.Drawing.Size(121, 20);
            this.cBoxOutWire.TabIndex = 19;
            this.cBoxOutWire.Text = "1";
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
            // cBoxOutMode
            // 
            this.cBoxOutMode.FormattingEnabled = true;
            this.cBoxOutMode.Items.AddRange(new object[] {
            "合格品输出脉冲",
            "不良品输出脉冲",
            "合格/不良品都输出脉冲"});
            this.cBoxOutMode.Location = new System.Drawing.Point(60, 110);
            this.cBoxOutMode.Name = "cBoxOutMode";
            this.cBoxOutMode.Size = new System.Drawing.Size(121, 20);
            this.cBoxOutMode.TabIndex = 17;
            this.cBoxOutMode.Text = "合格品输出脉冲";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tBoxDuration);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.tBoxOutDelay);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(212, 113);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 91);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "复位时间";
            // 
            // tBoxDuration
            // 
            this.tBoxDuration.Location = new System.Drawing.Point(111, 54);
            this.tBoxDuration.Name = "tBoxDuration";
            this.tBoxDuration.Size = new System.Drawing.Size(100, 21);
            this.tBoxDuration.TabIndex = 13;
            this.tBoxDuration.Text = "100";
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
            // tBoxOutDelay
            // 
            this.tBoxOutDelay.Location = new System.Drawing.Point(111, 27);
            this.tBoxOutDelay.Name = "tBoxOutDelay";
            this.tBoxOutDelay.Size = new System.Drawing.Size(100, 21);
            this.tBoxOutDelay.TabIndex = 11;
            this.tBoxOutDelay.Text = "0";
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
            this.groupBox3.Controls.Add(this.rBtnIgnoreLearn);
            this.groupBox3.Controls.Add(this.rBtnIgnoreFirst);
            this.groupBox3.Controls.Add(this.rBtnNormal);
            this.groupBox3.Location = new System.Drawing.Point(212, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 90);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "输出选项";
            // 
            // rBtnIgnoreLearn
            // 
            this.rBtnIgnoreLearn.AutoSize = true;
            this.rBtnIgnoreLearn.Location = new System.Drawing.Point(20, 64);
            this.rBtnIgnoreLearn.Name = "rBtnIgnoreLearn";
            this.rBtnIgnoreLearn.Size = new System.Drawing.Size(95, 16);
            this.rBtnIgnoreLearn.TabIndex = 3;
            this.rBtnIgnoreLearn.Text = "忽略所有学习";
            this.rBtnIgnoreLearn.UseVisualStyleBackColor = true;
            // 
            // rBtnIgnoreFirst
            // 
            this.rBtnIgnoreFirst.AutoSize = true;
            this.rBtnIgnoreFirst.Location = new System.Drawing.Point(20, 42);
            this.rBtnIgnoreFirst.Name = "rBtnIgnoreFirst";
            this.rBtnIgnoreFirst.Size = new System.Drawing.Size(107, 16);
            this.rBtnIgnoreFirst.TabIndex = 2;
            this.rBtnIgnoreFirst.Text = "忽略学习第一条";
            this.rBtnIgnoreFirst.UseVisualStyleBackColor = true;
            // 
            // rBtnNormal
            // 
            this.rBtnNormal.AutoSize = true;
            this.rBtnNormal.Checked = true;
            this.rBtnNormal.Location = new System.Drawing.Point(20, 21);
            this.rBtnNormal.Name = "rBtnNormal";
            this.rBtnNormal.Size = new System.Drawing.Size(71, 16);
            this.rBtnNormal.TabIndex = 1;
            this.rBtnNormal.TabStop = true;
            this.rBtnNormal.Text = "始终有效";
            this.rBtnNormal.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.rBtnNC);
            this.groupBox.Controls.Add(this.rBtnNO);
            this.groupBox.Location = new System.Drawing.Point(3, 3);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(178, 90);
            this.groupBox.TabIndex = 14;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "输出状态";
            // 
            // rBtnNC
            // 
            this.rBtnNC.AutoSize = true;
            this.rBtnNC.Location = new System.Drawing.Point(16, 51);
            this.rBtnNC.Name = "rBtnNC";
            this.rBtnNC.Size = new System.Drawing.Size(47, 16);
            this.rBtnNC.TabIndex = 1;
            this.rBtnNC.Text = "常闭";
            this.rBtnNC.UseVisualStyleBackColor = true;
            // 
            // rBtnNO
            // 
            this.rBtnNO.AutoSize = true;
            this.rBtnNO.Checked = true;
            this.rBtnNO.Location = new System.Drawing.Point(16, 29);
            this.rBtnNO.Name = "rBtnNO";
            this.rBtnNO.Size = new System.Drawing.Size(47, 16);
            this.rBtnNO.TabIndex = 0;
            this.rBtnNO.TabStop = true;
            this.rBtnNO.Text = "常开";
            this.rBtnNO.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cBoxOutRstMode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBoxOutWire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxOutMode);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox);
            this.Name = "output";
            this.Size = new System.Drawing.Size(463, 255);
            this.Load += new System.EventHandler(this.Output_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cBoxOutRstMode;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cBoxOutWire;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cBoxOutMode;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.TextBox tBoxDuration;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tBoxOutDelay;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.RadioButton rBtnIgnoreLearn;
        public System.Windows.Forms.RadioButton rBtnIgnoreFirst;
        public System.Windows.Forms.RadioButton rBtnNormal;
        public System.Windows.Forms.GroupBox groupBox;
        public System.Windows.Forms.RadioButton rBtnNC;
        public System.Windows.Forms.RadioButton rBtnNO;
    }
}
