namespace EPCIO
{
    partial class Parameter_UC
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_PPR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadPara_Btn = new System.Windows.Forms.Button();
            this.saveParaBtn = new System.Windows.Forms.Button();
            this.paraName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_RPM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_EncoderDir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_GearRatio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_HighLimit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Pitch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_LowLimit = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_PulseWidth = new System.Windows.Forms.TextBox();
            this.cb_PulseMode = new System.Windows.Forms.ComboBox();
            this.tb_CommandMode = new System.Windows.Forms.TextBox();
            this.tb_FeedSpeed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_Machine_Choose = new System.Windows.Forms.ComboBox();
            this.Pic_Machine = new System.Windows.Forms.PictureBox();
            this.Lb_MachineName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Machine)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_PPR
            // 
            this.tb_PPR.Location = new System.Drawing.Point(30, 247);
            this.tb_PPR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_PPR.Name = "tb_PPR";
            this.tb_PPR.Size = new System.Drawing.Size(132, 25);
            this.tb_PPR.TabIndex = 0;
            this.tb_PPR.Text = "10000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "PPR(馬達軸心旋轉一圈所需Pulse數)";
            // 
            // loadPara_Btn
            // 
            this.loadPara_Btn.Font = new System.Drawing.Font("新細明體", 11F);
            this.loadPara_Btn.Location = new System.Drawing.Point(162, 76);
            this.loadPara_Btn.Name = "loadPara_Btn";
            this.loadPara_Btn.Size = new System.Drawing.Size(164, 39);
            this.loadPara_Btn.TabIndex = 3;
            this.loadPara_Btn.Text = "顯示目前參數";
            this.loadPara_Btn.UseVisualStyleBackColor = true;
            this.loadPara_Btn.Click += new System.EventHandler(this.loadPara_Btn_Click);
            // 
            // saveParaBtn
            // 
            this.saveParaBtn.Font = new System.Drawing.Font("新細明體", 11F);
            this.saveParaBtn.Location = new System.Drawing.Point(337, 76);
            this.saveParaBtn.Name = "saveParaBtn";
            this.saveParaBtn.Size = new System.Drawing.Size(164, 39);
            this.saveParaBtn.TabIndex = 5;
            this.saveParaBtn.Text = "修改並儲存參數";
            this.saveParaBtn.UseVisualStyleBackColor = true;
            this.saveParaBtn.Click += new System.EventHandler(this.saveParaBtn_Click);
            // 
            // paraName
            // 
            this.paraName.AutoSize = true;
            this.paraName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paraName.Location = new System.Drawing.Point(24, 30);
            this.paraName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paraName.Name = "paraName";
            this.paraName.Size = new System.Drawing.Size(122, 31);
            this.paraName.TabIndex = 6;
            this.paraName.Text = "機台參數";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 287);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "RPM (每分轉速)";
            // 
            // tb_RPM
            // 
            this.tb_RPM.Location = new System.Drawing.Point(30, 335);
            this.tb_RPM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_RPM.Name = "tb_RPM";
            this.tb_RPM.Size = new System.Drawing.Size(132, 25);
            this.tb_RPM.TabIndex = 7;
            this.tb_RPM.Text = "3000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "EncoderDir (方向調整參數)";
            // 
            // tb_EncoderDir
            // 
            this.tb_EncoderDir.Location = new System.Drawing.Point(30, 164);
            this.tb_EncoderDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_EncoderDir.Name = "tb_EncoderDir";
            this.tb_EncoderDir.Size = new System.Drawing.Size(132, 25);
            this.tb_EncoderDir.TabIndex = 9;
            this.tb_EncoderDir.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 451);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "GearRatio(齒輪箱減速比)";
            // 
            // tb_GearRatio
            // 
            this.tb_GearRatio.Location = new System.Drawing.Point(30, 483);
            this.tb_GearRatio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_GearRatio.Name = "tb_GearRatio";
            this.tb_GearRatio.Size = new System.Drawing.Size(132, 25);
            this.tb_GearRatio.TabIndex = 15;
            this.tb_GearRatio.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 524);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "HighLimit(正方向邊界)";
            // 
            // tb_HighLimit
            // 
            this.tb_HighLimit.Location = new System.Drawing.Point(30, 556);
            this.tb_HighLimit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_HighLimit.Name = "tb_HighLimit";
            this.tb_HighLimit.Size = new System.Drawing.Size(132, 25);
            this.tb_HighLimit.TabIndex = 13;
            this.tb_HighLimit.Text = "50000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 376);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pitch(導螺桿間隙值)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Pitch
            // 
            this.tb_Pitch.Location = new System.Drawing.Point(30, 408);
            this.tb_Pitch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Pitch.Name = "tb_Pitch";
            this.tb_Pitch.Size = new System.Drawing.Size(132, 25);
            this.tb_Pitch.TabIndex = 11;
            this.tb_Pitch.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(523, 221);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 29);
            this.label9.TabIndex = 18;
            this.label9.Text = "LowLimit(負方向邊界)";
            // 
            // tb_LowLimit
            // 
            this.tb_LowLimit.Location = new System.Drawing.Point(528, 261);
            this.tb_LowLimit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_LowLimit.Name = "tb_LowLimit";
            this.tb_LowLimit.Size = new System.Drawing.Size(132, 25);
            this.tb_LowLimit.TabIndex = 17;
            this.tb_LowLimit.Text = "-50000";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(523, 390);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(295, 29);
            this.label16.TabIndex = 25;
            this.label16.Text = "PulseWidth(脈波輸出寬度)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(523, 475);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(485, 29);
            this.label14.TabIndex = 24;
            this.label14.Text = "CommandMode(運動命令輸出型式 預設為0)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(523, 301);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(296, 29);
            this.label15.TabIndex = 23;
            this.label15.Text = "PulseMode(脈波輸出格式)";
            // 
            // tb_PulseWidth
            // 
            this.tb_PulseWidth.Location = new System.Drawing.Point(528, 437);
            this.tb_PulseWidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_PulseWidth.Name = "tb_PulseWidth";
            this.tb_PulseWidth.Size = new System.Drawing.Size(132, 25);
            this.tb_PulseWidth.TabIndex = 28;
            this.tb_PulseWidth.Text = "100";
            // 
            // cb_PulseMode
            // 
            this.cb_PulseMode.FormattingEnabled = true;
            this.cb_PulseMode.Items.AddRange(new object[] {
            "DDA_FMT_CW"});
            this.cb_PulseMode.Location = new System.Drawing.Point(528, 349);
            this.cb_PulseMode.Name = "cb_PulseMode";
            this.cb_PulseMode.Size = new System.Drawing.Size(132, 23);
            this.cb_PulseMode.TabIndex = 29;
            this.cb_PulseMode.Text = "DDA_FMT_CW";
            // 
            // tb_CommandMode
            // 
            this.tb_CommandMode.Location = new System.Drawing.Point(528, 524);
            this.tb_CommandMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_CommandMode.Name = "tb_CommandMode";
            this.tb_CommandMode.Size = new System.Drawing.Size(132, 25);
            this.tb_CommandMode.TabIndex = 30;
            this.tb_CommandMode.Text = "0";
            // 
            // tb_FeedSpeed
            // 
            this.tb_FeedSpeed.Location = new System.Drawing.Point(528, 178);
            this.tb_FeedSpeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_FeedSpeed.Name = "tb_FeedSpeed";
            this.tb_FeedSpeed.Size = new System.Drawing.Size(132, 25);
            this.tb_FeedSpeed.TabIndex = 32;
            this.tb_FeedSpeed.Text = "50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(523, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 29);
            this.label7.TabIndex = 31;
            this.label7.Text = "進給速度";
            // 
            // cb_Machine_Choose
            // 
            this.cb_Machine_Choose.FormattingEnabled = true;
            this.cb_Machine_Choose.Items.AddRange(new object[] {
            "MachineA",
            "MachineB"});
            this.cb_Machine_Choose.Location = new System.Drawing.Point(25, 85);
            this.cb_Machine_Choose.Name = "cb_Machine_Choose";
            this.cb_Machine_Choose.Size = new System.Drawing.Size(121, 23);
            this.cb_Machine_Choose.TabIndex = 33;
            this.cb_Machine_Choose.SelectedIndexChanged += new System.EventHandler(this.cb_Machine_Choose_SelectedIndexChanged);
            // 
            // Pic_Machine
            // 
            this.Pic_Machine.Location = new System.Drawing.Point(928, 76);
            this.Pic_Machine.Name = "Pic_Machine";
            this.Pic_Machine.Size = new System.Drawing.Size(433, 372);
            this.Pic_Machine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Machine.TabIndex = 34;
            this.Pic_Machine.TabStop = false;
            // 
            // Lb_MachineName
            // 
            this.Lb_MachineName.AutoSize = true;
            this.Lb_MachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_MachineName.Location = new System.Drawing.Point(922, 30);
            this.Lb_MachineName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_MachineName.Name = "Lb_MachineName";
            this.Lb_MachineName.Size = new System.Drawing.Size(21, 31);
            this.Lb_MachineName.TabIndex = 35;
            this.Lb_MachineName.Text = " ";
            // 
            // Parameter_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lb_MachineName);
            this.Controls.Add(this.Pic_Machine);
            this.Controls.Add(this.cb_Machine_Choose);
            this.Controls.Add(this.tb_FeedSpeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_CommandMode);
            this.Controls.Add(this.cb_PulseMode);
            this.Controls.Add(this.tb_PulseWidth);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_LowLimit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_GearRatio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_HighLimit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Pitch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_EncoderDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_RPM);
            this.Controls.Add(this.paraName);
            this.Controls.Add(this.saveParaBtn);
            this.Controls.Add(this.loadPara_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_PPR);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Parameter_UC";
            this.Size = new System.Drawing.Size(1549, 732);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Machine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb_PPR;
        private System.Windows.Forms.Button loadPara_Btn;
        private System.Windows.Forms.Button saveParaBtn;
        public System.Windows.Forms.Label paraName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tb_RPM;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tb_EncoderDir;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_GearRatio;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tb_HighLimit;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tb_Pitch;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tb_LowLimit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox tb_PulseWidth;
        private System.Windows.Forms.ComboBox cb_PulseMode;
        public System.Windows.Forms.TextBox tb_CommandMode;
        public System.Windows.Forms.TextBox tb_FeedSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_Machine_Choose;
        private System.Windows.Forms.PictureBox Pic_Machine;
        public System.Windows.Forms.Label Lb_MachineName;
    }
}
