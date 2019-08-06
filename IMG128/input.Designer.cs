namespace IMG128
{
    partial class input
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
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cBoxInputPolLvl1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cBoxInputModeLvl1 = new System.Windows.Forms.ComboBox();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Controls.Add(this.cBoxInputPolLvl1);
            this.groupBox10.Controls.Add(this.label12);
            this.groupBox10.Controls.Add(this.cBoxInputModeLvl1);
            this.groupBox10.Location = new System.Drawing.Point(3, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(204, 88);
            this.groupBox10.TabIndex = 19;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "输入1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 22;
            this.label13.Text = "输入极性";
            // 
            // cBoxInputPolLvl1
            // 
            this.cBoxInputPolLvl1.FormattingEnabled = true;
            this.cBoxInputPolLvl1.Items.AddRange(new object[] {
            "上升沿触发",
            "下降沿触发"});
            this.cBoxInputPolLvl1.Location = new System.Drawing.Point(72, 51);
            this.cBoxInputPolLvl1.Name = "cBoxInputPolLvl1";
            this.cBoxInputPolLvl1.Size = new System.Drawing.Size(121, 20);
            this.cBoxInputPolLvl1.TabIndex = 21;
            this.cBoxInputPolLvl1.Text = "下降沿触发";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 20;
            this.label12.Text = "输入模式";
            // 
            // cBoxInputModeLvl1
            // 
            this.cBoxInputModeLvl1.FormattingEnabled = true;
            this.cBoxInputModeLvl1.Items.AddRange(new object[] {
            "进入学习模式",
            "触发采样",
            "进入设置模式"});
            this.cBoxInputModeLvl1.Location = new System.Drawing.Point(72, 25);
            this.cBoxInputModeLvl1.Name = "cBoxInputModeLvl1";
            this.cBoxInputModeLvl1.Size = new System.Drawing.Size(121, 20);
            this.cBoxInputModeLvl1.TabIndex = 19;
            this.cBoxInputModeLvl1.Text = "进入学习模式";
            // 
            // input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox10);
            this.Name = "input";
            this.Size = new System.Drawing.Size(216, 97);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cBoxInputPolLvl1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cBoxInputModeLvl1;
    }
}
