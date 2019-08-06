namespace IMG128
{
    partial class DevCfgDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btUploadCfg = new System.Windows.Forms.Button();
            this.btUpdateCfg = new System.Windows.Forms.Button();
            this.btOpenProfile = new System.Windows.Forms.Button();
            this.btSaveProfile = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tBoxMinSetupDuration = new System.Windows.Forms.TextBox();
            this.tBoxFiringTimeOut = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabCtlOut = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.output3 = new output();
            this.checkBoxOutIgnoreWhileOutActive = new System.Windows.Forms.CheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnSetupCCD = new System.Windows.Forms.Button();
            this.tBoxSensorSensitivity = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cBoxLearnNum = new System.Windows.Forms.ComboBox();
            this.ckBoxAutoAdjSpeed = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxModelNum = new System.Windows.Forms.ComboBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.xxcs3 = new  xxcs();
            this.xxcs1 = new  xxcs();
            this.xxcs2 = new  xxcs();
            this.input1 = new  input();
            this.input2 = new  input();
            this.input3 = new  input();
            this.input4 = new  input();
            this.output1 = new  output();
            this.output2 = new  output();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabCtlOut.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // btUploadCfg
            // 
            this.btUploadCfg.Location = new System.Drawing.Point(296, 425);
            this.btUploadCfg.Name = "btUploadCfg";
            this.btUploadCfg.Size = new System.Drawing.Size(105, 23);
            this.btUploadCfg.TabIndex = 18;
            this.btUploadCfg.Text = "读取设备配置";
            this.btUploadCfg.UseVisualStyleBackColor = true;
            // 
            // btUpdateCfg
            // 
            this.btUpdateCfg.Location = new System.Drawing.Point(415, 425);
            this.btUpdateCfg.Name = "btUpdateCfg";
            this.btUpdateCfg.Size = new System.Drawing.Size(105, 23);
            this.btUpdateCfg.TabIndex = 19;
            this.btUpdateCfg.Text = "更新设备配置";
            this.btUpdateCfg.UseVisualStyleBackColor = true;
            this.btUpdateCfg.Click += new System.EventHandler(this.btUpdateCfg_Click);
            // 
            // btOpenProfile
            // 
            this.btOpenProfile.Location = new System.Drawing.Point(16, 425);
            this.btOpenProfile.Name = "btOpenProfile";
            this.btOpenProfile.Size = new System.Drawing.Size(105, 23);
            this.btOpenProfile.TabIndex = 20;
            this.btOpenProfile.Text = "打开配置文件";
            this.btOpenProfile.UseVisualStyleBackColor = true;
            // 
            // btSaveProfile
            // 
            this.btSaveProfile.Location = new System.Drawing.Point(127, 425);
            this.btSaveProfile.Name = "btSaveProfile";
            this.btSaveProfile.Size = new System.Drawing.Size(105, 23);
            this.btSaveProfile.TabIndex = 21;
            this.btSaveProfile.Text = "保存配置文件";
            this.btSaveProfile.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.xxcs2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(504, 365);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "线型参数2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.xxcs1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(504, 365);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "线型参数1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.input4);
            this.tabPage7.Controls.Add(this.input3);
            this.tabPage7.Controls.Add(this.input2);
            this.tabPage7.Controls.Add(this.input1);
            this.tabPage7.Controls.Add(this.tBoxMinSetupDuration);
            this.tabPage7.Controls.Add(this.tBoxFiringTimeOut);
            this.tabPage7.Controls.Add(this.label35);
            this.tabPage7.Controls.Add(this.label34);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(504, 365);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "输入";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tBoxMinSetupDuration
            // 
            this.tBoxMinSetupDuration.Location = new System.Drawing.Point(328, 319);
            this.tBoxMinSetupDuration.Name = "tBoxMinSetupDuration";
            this.tBoxMinSetupDuration.Size = new System.Drawing.Size(100, 21);
            this.tBoxMinSetupDuration.TabIndex = 35;
            this.tBoxMinSetupDuration.Text = "4000";
            // 
            // tBoxFiringTimeOut
            // 
            this.tBoxFiringTimeOut.Location = new System.Drawing.Point(328, 283);
            this.tBoxFiringTimeOut.Name = "tBoxFiringTimeOut";
            this.tBoxFiringTimeOut.Size = new System.Drawing.Size(100, 21);
            this.tBoxFiringTimeOut.TabIndex = 33;
            this.tBoxFiringTimeOut.Text = "500";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(167, 322);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(149, 12);
            this.label35.TabIndex = 34;
            this.label35.Text = "按键进入设置模式延时(ms)";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(209, 286);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(113, 12);
            this.label34.TabIndex = 32;
            this.label34.Text = "触发有效期长度(ms)";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tabCtlOut);
            this.tabPage6.Controls.Add(this.checkBoxOutIgnoreWhileOutActive);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(504, 365);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "输出";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabCtlOut
            // 
            this.tabCtlOut.Controls.Add(this.tabPage3);
            this.tabCtlOut.Controls.Add(this.tabPage4);
            this.tabCtlOut.Controls.Add(this.tabPage9);
            this.tabCtlOut.Location = new System.Drawing.Point(6, 6);
            this.tabCtlOut.Name = "tabCtlOut";
            this.tabCtlOut.SelectedIndex = 0;
            this.tabCtlOut.Size = new System.Drawing.Size(489, 283);
            this.tabCtlOut.TabIndex = 15;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.output1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(481, 257);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "输出1";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.output2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(481, 257);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "输出2";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.output3);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(481, 257);
            this.tabPage9.TabIndex = 2;
            this.tabPage9.Text = "输出3";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // output3
            // 
            this.output3.Location = new System.Drawing.Point(4, 4);
            this.output3.Name = "output3";
            this.output3.Size = new System.Drawing.Size(463, 255);
            this.output3.TabIndex = 0;
            // 
            // checkBoxOutIgnoreWhileOutActive
            // 
            this.checkBoxOutIgnoreWhileOutActive.AutoSize = true;
            this.checkBoxOutIgnoreWhileOutActive.Location = new System.Drawing.Point(32, 295);
            this.checkBoxOutIgnoreWhileOutActive.Name = "checkBoxOutIgnoreWhileOutActive";
            this.checkBoxOutIgnoreWhileOutActive.Size = new System.Drawing.Size(240, 16);
            this.checkBoxOutIgnoreWhileOutActive.TabIndex = 16;
            this.checkBoxOutIgnoreWhileOutActive.Text = "输出有效期间忽略输入（忽略返程阶段）";
            this.checkBoxOutIgnoreWhileOutActive.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnSetupCCD);
            this.tabPage5.Controls.Add(this.tBoxSensorSensitivity);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.cBoxLearnNum);
            this.tabPage5.Controls.Add(this.ckBoxAutoAdjSpeed);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.cBoxModelNum);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(504, 365);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "通用";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnSetupCCD
            // 
            this.btnSetupCCD.Location = new System.Drawing.Point(259, 278);
            this.btnSetupCCD.Name = "btnSetupCCD";
            this.btnSetupCCD.Size = new System.Drawing.Size(191, 32);
            this.btnSetupCCD.TabIndex = 20;
            this.btnSetupCCD.Text = "设置传感器";
            this.btnSetupCCD.UseVisualStyleBackColor = true;
            // 
            // tBoxSensorSensitivity
            // 
            this.tBoxSensorSensitivity.Location = new System.Drawing.Point(350, 243);
            this.tBoxSensorSensitivity.Name = "tBoxSensorSensitivity";
            this.tBoxSensorSensitivity.Size = new System.Drawing.Size(100, 21);
            this.tBoxSensorSensitivity.TabIndex = 19;
            this.tBoxSensorSensitivity.Text = "10";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(257, 246);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 12);
            this.label20.TabIndex = 18;
            this.label20.Text = "传感器灵敏度%";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(38, 89);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 12);
            this.label21.TabIndex = 17;
            this.label21.Text = "学习数量";
            // 
            // cBoxLearnNum
            // 
            this.cBoxLearnNum.FormattingEnabled = true;
            this.cBoxLearnNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.cBoxLearnNum.Location = new System.Drawing.Point(97, 86);
            this.cBoxLearnNum.Name = "cBoxLearnNum";
            this.cBoxLearnNum.Size = new System.Drawing.Size(121, 20);
            this.cBoxLearnNum.TabIndex = 16;
            this.cBoxLearnNum.Text = "1";
            // 
            // ckBoxAutoAdjSpeed
            // 
            this.ckBoxAutoAdjSpeed.AutoSize = true;
            this.ckBoxAutoAdjSpeed.Location = new System.Drawing.Point(66, 287);
            this.ckBoxAutoAdjSpeed.Name = "ckBoxAutoAdjSpeed";
            this.ckBoxAutoAdjSpeed.Size = new System.Drawing.Size(96, 16);
            this.ckBoxAutoAdjSpeed.TabIndex = 15;
            this.ckBoxAutoAdjSpeed.Text = "使能速度补偿";
            this.ckBoxAutoAdjSpeed.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "线型数量";
            // 
            // cBoxModelNum
            // 
            this.cBoxModelNum.FormattingEnabled = true;
            this.cBoxModelNum.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cBoxModelNum.Location = new System.Drawing.Point(97, 56);
            this.cBoxModelNum.Name = "cBoxModelNum";
            this.cBoxModelNum.Size = new System.Drawing.Size(121, 20);
            this.cBoxModelNum.TabIndex = 10;
            this.cBoxModelNum.Text = "1";
            this.cBoxModelNum.SelectedIndexChanged += new System.EventHandler(this.cBoxModelNum_SelectedIndexChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(512, 391);
            this.tabControl2.TabIndex = 17;
            this.tabControl2.Tag = "";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.xxcs3);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(504, 365);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "线型参数3";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // xxcs3
            // 
            this.xxcs3.Location = new System.Drawing.Point(17, 6);
            this.xxcs3.Name = "xxcs3";
            this.xxcs3.Size = new System.Drawing.Size(468, 349);
            this.xxcs3.TabIndex = 0;
            // 
            // xxcs1
            // 
            this.xxcs1.Location = new System.Drawing.Point(6, 6);
            this.xxcs1.Name = "xxcs1";
            this.xxcs1.Size = new System.Drawing.Size(468, 349);
            this.xxcs1.TabIndex = 0;
            // 
            // xxcs2
            // 
            this.xxcs2.Location = new System.Drawing.Point(6, 6);
            this.xxcs2.Name = "xxcs2";
            this.xxcs2.Size = new System.Drawing.Size(468, 349);
            this.xxcs2.TabIndex = 0;
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(6, 50);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(216, 97);
            this.input1.TabIndex = 36;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(282, 50);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(216, 97);
            this.input2.TabIndex = 37;
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(6, 153);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(216, 97);
            this.input3.TabIndex = 38;
            // 
            // input4
            // 
            this.input4.Location = new System.Drawing.Point(282, 153);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(216, 97);
            this.input4.TabIndex = 39;
            // 
            // output1
            // 
            this.output1.Location = new System.Drawing.Point(6, 6);
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(463, 255);
            this.output1.TabIndex = 0;
            // 
            // output2
            // 
            this.output2.Location = new System.Drawing.Point(6, 6);
            this.output2.Name = "output2";
            this.output2.Size = new System.Drawing.Size(463, 255);
            this.output2.TabIndex = 0;
            // 
            // DevCfgDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 460);
            this.Controls.Add(this.btSaveProfile);
            this.Controls.Add(this.btOpenProfile);
            this.Controls.Add(this.btUpdateCfg);
            this.Controls.Add(this.btUploadCfg);
            this.Controls.Add(this.tabControl2);
            this.Name = "DevCfgDlg";
            this.Text = "参数配置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DevCfgDlg_FormClosing);
            this.Load += new System.EventHandler(this.DevCfgDlg_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabCtlOut.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btUploadCfg;
        private System.Windows.Forms.Button btUpdateCfg;
        private System.Windows.Forms.Button btOpenProfile;
        private System.Windows.Forms.Button btSaveProfile;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox tBoxMinSetupDuration;
        private System.Windows.Forms.TextBox tBoxFiringTimeOut;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabControl tabCtlOut;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox checkBoxOutIgnoreWhileOutActive;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnSetupCCD;
        private System.Windows.Forms.TextBox tBoxSensorSensitivity;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cBoxLearnNum;
        private System.Windows.Forms.CheckBox ckBoxAutoAdjSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxModelNum;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage8;
        private xxcs xxcs3;
        private System.Windows.Forms.TabPage tabPage9;
        private output output3;
        private xxcs xxcs2;
        private xxcs xxcs1;
        private input input4;
        private input input3;
        private input input2;
        private input input1;
        private output output1;
        private output output2;
    }
}