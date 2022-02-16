namespace EPCIO
{
    partial class MotionControl_UC
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
            this.components = new System.ComponentModel.Container();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.GcodeMoveBtn = new System.Windows.Forms.Button();
            this.Btn_Import = new System.Windows.Forms.Button();
            this.Btn_Export = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Btn_Move = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.zMoveValTextBox = new System.Windows.Forms.TextBox();
            this.yMoveValTextBox = new System.Windows.Forms.TextBox();
            this.xMoveValTextBox = new System.Windows.Forms.TextBox();
            this.Ptb_M1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.MotionType = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SystemStatusButton = new System.Windows.Forms.PictureBox();
            this.zEncoderTextBox = new System.Windows.Forms.TextBox();
            this.zCurPosTextBox = new System.Windows.Forms.TextBox();
            this.yEncoderTextBox = new System.Windows.Forms.TextBox();
            this.yCurPosTextBox = new System.Windows.Forms.TextBox();
            this.xEncoderTextBox = new System.Windows.Forms.TextBox();
            this.xCurPosTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SystemButton = new System.Windows.Forms.Button();
            this.cb_MA = new System.Windows.Forms.CheckBox();
            this.cb_MB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Ptb_M2 = new System.Windows.Forms.PictureBox();
            this.Ptb_M3 = new System.Windows.Forms.PictureBox();
            this.Ptb_M4 = new System.Windows.Forms.PictureBox();
            this.cb_MD = new System.Windows.Forms.CheckBox();
            this.cb_MC = new System.Windows.Forms.CheckBox();
            this.cb_MoveMD = new System.Windows.Forms.CheckBox();
            this.cb_MoveMC = new System.Windows.Forms.CheckBox();
            this.cb_MoveMB = new System.Windows.Forms.CheckBox();
            this.cb_MoveMA = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Lb_statusA = new System.Windows.Forms.Label();
            this.Lb_statusB = new System.Windows.Forms.Label();
            this.Lb_statusC = new System.Windows.Forms.Label();
            this.Lb_statusD = new System.Windows.Forms.Label();
            this.Btn_Produce = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.Lb_machingA = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Lb_grouping = new System.Windows.Forms.Label();
            this.Lb_product = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Lb_machingB = new System.Windows.Forms.Label();
            this.Lbx_Produce = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_M1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemStatusButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_M2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_M3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_M4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Items.AddRange(new object[] {
            "nGroup",
            "nGroup1",
            "nGroup2",
            "nGroup3"});
            this.groupComboBox.Location = new System.Drawing.Point(373, 183);
            this.groupComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(202, 23);
            this.groupComboBox.TabIndex = 105;
            // 
            // GcodeMoveBtn
            // 
            this.GcodeMoveBtn.Location = new System.Drawing.Point(368, 23);
            this.GcodeMoveBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GcodeMoveBtn.Name = "GcodeMoveBtn";
            this.GcodeMoveBtn.Size = new System.Drawing.Size(88, 44);
            this.GcodeMoveBtn.TabIndex = 104;
            this.GcodeMoveBtn.Text = "Gcode移動";
            this.GcodeMoveBtn.UseVisualStyleBackColor = true;
            this.GcodeMoveBtn.Click += new System.EventHandler(this.GcodeMoveBtn_Click);
            // 
            // Btn_Import
            // 
            this.Btn_Import.Location = new System.Drawing.Point(113, 385);
            this.Btn_Import.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Import.Name = "Btn_Import";
            this.Btn_Import.Size = new System.Drawing.Size(88, 44);
            this.Btn_Import.TabIndex = 103;
            this.Btn_Import.Text = "匯入腳本";
            this.Btn_Import.UseVisualStyleBackColor = true;
            this.Btn_Import.Click += new System.EventHandler(this.Btn_Import_Click);
            // 
            // Btn_Export
            // 
            this.Btn_Export.Location = new System.Drawing.Point(17, 385);
            this.Btn_Export.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Export.Name = "Btn_Export";
            this.Btn_Export.Size = new System.Drawing.Size(88, 44);
            this.Btn_Export.TabIndex = 102;
            this.Btn_Export.Text = "匯出腳本";
            this.Btn_Export.UseVisualStyleBackColor = true;
            this.Btn_Export.Click += new System.EventHandler(this.Btn_Export_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(17, 434);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(265, 292);
            this.richTextBox1.TabIndex = 101;
            this.richTextBox1.Text = "";
            // 
            // Btn_Move
            // 
            this.Btn_Move.Location = new System.Drawing.Point(303, 134);
            this.Btn_Move.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Move.Name = "Btn_Move";
            this.Btn_Move.Size = new System.Drawing.Size(59, 57);
            this.Btn_Move.TabIndex = 100;
            this.Btn_Move.Text = "移動";
            this.Btn_Move.UseVisualStyleBackColor = true;
            this.Btn_Move.Click += new System.EventHandler(this.Btn_Move_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("新細明體", 15F);
            this.label16.Location = new System.Drawing.Point(242, 162);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 25);
            this.label16.TabIndex = 99;
            this.label16.Text = "z";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("新細明體", 15F);
            this.label12.Location = new System.Drawing.Point(143, 162);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 25);
            this.label12.TabIndex = 98;
            this.label12.Text = "y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("新細明體", 15F);
            this.label11.Location = new System.Drawing.Point(30, 162);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 25);
            this.label11.TabIndex = 97;
            this.label11.Text = "x";
            // 
            // zMoveValTextBox
            // 
            this.zMoveValTextBox.Location = new System.Drawing.Point(213, 134);
            this.zMoveValTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zMoveValTextBox.Name = "zMoveValTextBox";
            this.zMoveValTextBox.Size = new System.Drawing.Size(85, 25);
            this.zMoveValTextBox.TabIndex = 96;
            // 
            // yMoveValTextBox
            // 
            this.yMoveValTextBox.Location = new System.Drawing.Point(106, 134);
            this.yMoveValTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.yMoveValTextBox.Name = "yMoveValTextBox";
            this.yMoveValTextBox.Size = new System.Drawing.Size(85, 25);
            this.yMoveValTextBox.TabIndex = 95;
            // 
            // xMoveValTextBox
            // 
            this.xMoveValTextBox.Location = new System.Drawing.Point(3, 134);
            this.xMoveValTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.xMoveValTextBox.Name = "xMoveValTextBox";
            this.xMoveValTextBox.Size = new System.Drawing.Size(85, 25);
            this.xMoveValTextBox.TabIndex = 94;
            // 
            // Ptb_M1
            // 
            this.Ptb_M1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ptb_M1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ptb_M1.Location = new System.Drawing.Point(594, 46);
            this.Ptb_M1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ptb_M1.Name = "Ptb_M1";
            this.Ptb_M1.Size = new System.Drawing.Size(393, 299);
            this.Ptb_M1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ptb_M1.TabIndex = 93;
            this.Ptb_M1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 188);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 15);
            this.label15.TabIndex = 92;
            this.label15.Text = "MotionType";
            // 
            // MotionType
            // 
            this.MotionType.AutoSize = true;
            this.MotionType.Location = new System.Drawing.Point(95, 188);
            this.MotionType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MotionType.Name = "MotionType";
            this.MotionType.Size = new System.Drawing.Size(103, 15);
            this.MotionType.TabIndex = 91;
            this.MotionType.Text = "Current_Position";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 8);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 15);
            this.label14.TabIndex = 89;
            this.label14.Text = "SystemStatus";
            // 
            // SystemStatusButton
            // 
            this.SystemStatusButton.BackColor = System.Drawing.SystemColors.Control;
            this.SystemStatusButton.Image = global::EPCIO.Properties.Resources.綠燈;
            this.SystemStatusButton.Location = new System.Drawing.Point(35, 27);
            this.SystemStatusButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SystemStatusButton.Name = "SystemStatusButton";
            this.SystemStatusButton.Size = new System.Drawing.Size(88, 83);
            this.SystemStatusButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SystemStatusButton.TabIndex = 81;
            this.SystemStatusButton.TabStop = false;
            this.SystemStatusButton.Visible = false;
            // 
            // zEncoderTextBox
            // 
            this.zEncoderTextBox.Location = new System.Drawing.Point(176, 348);
            this.zEncoderTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zEncoderTextBox.Name = "zEncoderTextBox";
            this.zEncoderTextBox.Size = new System.Drawing.Size(132, 25);
            this.zEncoderTextBox.TabIndex = 74;
            // 
            // zCurPosTextBox
            // 
            this.zCurPosTextBox.Location = new System.Drawing.Point(35, 348);
            this.zCurPosTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zCurPosTextBox.Name = "zCurPosTextBox";
            this.zCurPosTextBox.Size = new System.Drawing.Size(132, 25);
            this.zCurPosTextBox.TabIndex = 73;
            // 
            // yEncoderTextBox
            // 
            this.yEncoderTextBox.Location = new System.Drawing.Point(176, 286);
            this.yEncoderTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.yEncoderTextBox.Name = "yEncoderTextBox";
            this.yEncoderTextBox.Size = new System.Drawing.Size(132, 25);
            this.yEncoderTextBox.TabIndex = 72;
            // 
            // yCurPosTextBox
            // 
            this.yCurPosTextBox.Location = new System.Drawing.Point(35, 286);
            this.yCurPosTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.yCurPosTextBox.Name = "yCurPosTextBox";
            this.yCurPosTextBox.Size = new System.Drawing.Size(132, 25);
            this.yCurPosTextBox.TabIndex = 71;
            // 
            // xEncoderTextBox
            // 
            this.xEncoderTextBox.Location = new System.Drawing.Point(176, 229);
            this.xEncoderTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.xEncoderTextBox.Name = "xEncoderTextBox";
            this.xEncoderTextBox.Size = new System.Drawing.Size(132, 25);
            this.xEncoderTextBox.TabIndex = 70;
            // 
            // xCurPosTextBox
            // 
            this.xCurPosTextBox.Location = new System.Drawing.Point(35, 229);
            this.xCurPosTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.xCurPosTextBox.Name = "xCurPosTextBox";
            this.xCurPosTextBox.Size = new System.Drawing.Size(132, 25);
            this.xCurPosTextBox.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 207);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 68;
            this.label8.Text = "Encoder";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 207);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 67;
            this.label7.Text = "Current_Position";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 80;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SystemButton
            // 
            this.SystemButton.Font = new System.Drawing.Font("新細明體", 9F);
            this.SystemButton.Location = new System.Drawing.Point(131, 18);
            this.SystemButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SystemButton.Name = "SystemButton";
            this.SystemButton.Size = new System.Drawing.Size(151, 51);
            this.SystemButton.TabIndex = 106;
            this.SystemButton.Text = "System On/Off";
            this.SystemButton.UseVisualStyleBackColor = true;
            this.SystemButton.Click += new System.EventHandler(this.SystemButton_Click);
            // 
            // cb_MA
            // 
            this.cb_MA.AutoSize = true;
            this.cb_MA.Location = new System.Drawing.Point(130, 75);
            this.cb_MA.Name = "cb_MA";
            this.cb_MA.Size = new System.Drawing.Size(88, 19);
            this.cb_MA.TabIndex = 108;
            this.cb_MA.Text = "MachineA";
            this.cb_MA.UseVisualStyleBackColor = true;
            // 
            // cb_MB
            // 
            this.cb_MB.AutoSize = true;
            this.cb_MB.Location = new System.Drawing.Point(130, 92);
            this.cb_MB.Name = "cb_MB";
            this.cb_MB.Size = new System.Drawing.Size(87, 19);
            this.cb_MB.TabIndex = 109;
            this.cb_MB.Text = "MachineB";
            this.cb_MB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 110;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 111;
            this.label2.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 351);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 15);
            this.label4.TabIndex = 112;
            this.label4.Text = "Z";
            // 
            // Ptb_M2
            // 
            this.Ptb_M2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ptb_M2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ptb_M2.Location = new System.Drawing.Point(995, 48);
            this.Ptb_M2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ptb_M2.Name = "Ptb_M2";
            this.Ptb_M2.Size = new System.Drawing.Size(393, 299);
            this.Ptb_M2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ptb_M2.TabIndex = 113;
            this.Ptb_M2.TabStop = false;
            // 
            // Ptb_M3
            // 
            this.Ptb_M3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ptb_M3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ptb_M3.Location = new System.Drawing.Point(594, 412);
            this.Ptb_M3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ptb_M3.Name = "Ptb_M3";
            this.Ptb_M3.Size = new System.Drawing.Size(393, 299);
            this.Ptb_M3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ptb_M3.TabIndex = 114;
            this.Ptb_M3.TabStop = false;
            // 
            // Ptb_M4
            // 
            this.Ptb_M4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ptb_M4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ptb_M4.Location = new System.Drawing.Point(995, 412);
            this.Ptb_M4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ptb_M4.Name = "Ptb_M4";
            this.Ptb_M4.Size = new System.Drawing.Size(393, 299);
            this.Ptb_M4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ptb_M4.TabIndex = 115;
            this.Ptb_M4.TabStop = false;
            // 
            // cb_MD
            // 
            this.cb_MD.AutoSize = true;
            this.cb_MD.Location = new System.Drawing.Point(220, 92);
            this.cb_MD.Name = "cb_MD";
            this.cb_MD.Size = new System.Drawing.Size(88, 19);
            this.cb_MD.TabIndex = 117;
            this.cb_MD.Text = "MachineD";
            this.cb_MD.UseVisualStyleBackColor = true;
            // 
            // cb_MC
            // 
            this.cb_MC.AutoSize = true;
            this.cb_MC.Location = new System.Drawing.Point(221, 75);
            this.cb_MC.Name = "cb_MC";
            this.cb_MC.Size = new System.Drawing.Size(87, 19);
            this.cb_MC.TabIndex = 116;
            this.cb_MC.Text = "MachineC";
            this.cb_MC.UseVisualStyleBackColor = true;
            // 
            // cb_MoveMD
            // 
            this.cb_MoveMD.AutoSize = true;
            this.cb_MoveMD.Location = new System.Drawing.Point(488, 92);
            this.cb_MoveMD.Name = "cb_MoveMD";
            this.cb_MoveMD.Size = new System.Drawing.Size(88, 19);
            this.cb_MoveMD.TabIndex = 121;
            this.cb_MoveMD.Text = "MachineD";
            this.cb_MoveMD.UseVisualStyleBackColor = true;
            // 
            // cb_MoveMC
            // 
            this.cb_MoveMC.AutoSize = true;
            this.cb_MoveMC.Location = new System.Drawing.Point(488, 75);
            this.cb_MoveMC.Name = "cb_MoveMC";
            this.cb_MoveMC.Size = new System.Drawing.Size(87, 19);
            this.cb_MoveMC.TabIndex = 120;
            this.cb_MoveMC.Text = "MachineC";
            this.cb_MoveMC.UseVisualStyleBackColor = true;
            // 
            // cb_MoveMB
            // 
            this.cb_MoveMB.AutoSize = true;
            this.cb_MoveMB.Location = new System.Drawing.Point(377, 92);
            this.cb_MoveMB.Name = "cb_MoveMB";
            this.cb_MoveMB.Size = new System.Drawing.Size(87, 19);
            this.cb_MoveMB.TabIndex = 119;
            this.cb_MoveMB.Text = "MachineB";
            this.cb_MoveMB.UseVisualStyleBackColor = true;
            // 
            // cb_MoveMA
            // 
            this.cb_MoveMA.AutoSize = true;
            this.cb_MoveMA.Location = new System.Drawing.Point(377, 75);
            this.cb_MoveMA.Name = "cb_MoveMA";
            this.cb_MoveMA.Size = new System.Drawing.Size(88, 19);
            this.cb_MoveMA.TabIndex = 118;
            this.cb_MoveMA.Text = "MachineA";
            this.cb_MoveMA.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15F);
            this.label3.Location = new System.Drawing.Point(599, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 123;
            this.label3.Text = "MachineA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 15F);
            this.label5.Location = new System.Drawing.Point(995, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 124;
            this.label5.Text = "MachineB:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 15F);
            this.label6.Location = new System.Drawing.Point(593, 385);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 125;
            this.label6.Text = "MachineC:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 15F);
            this.label13.Location = new System.Drawing.Point(995, 385);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 25);
            this.label13.TabIndex = 126;
            this.label13.Text = "MachineD:";
            // 
            // Lb_statusA
            // 
            this.Lb_statusA.AutoSize = true;
            this.Lb_statusA.Font = new System.Drawing.Font("新細明體", 15F);
            this.Lb_statusA.Location = new System.Drawing.Point(712, 18);
            this.Lb_statusA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_statusA.Name = "Lb_statusA";
            this.Lb_statusA.Size = new System.Drawing.Size(62, 25);
            this.Lb_statusA.TabIndex = 127;
            this.Lb_statusA.Text = "關機";
            // 
            // Lb_statusB
            // 
            this.Lb_statusB.AutoSize = true;
            this.Lb_statusB.Font = new System.Drawing.Font("新細明體", 15F);
            this.Lb_statusB.Location = new System.Drawing.Point(1106, 18);
            this.Lb_statusB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_statusB.Name = "Lb_statusB";
            this.Lb_statusB.Size = new System.Drawing.Size(62, 25);
            this.Lb_statusB.TabIndex = 128;
            this.Lb_statusB.Text = "關機";
            // 
            // Lb_statusC
            // 
            this.Lb_statusC.AutoSize = true;
            this.Lb_statusC.Font = new System.Drawing.Font("新細明體", 15F);
            this.Lb_statusC.Location = new System.Drawing.Point(712, 384);
            this.Lb_statusC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_statusC.Name = "Lb_statusC";
            this.Lb_statusC.Size = new System.Drawing.Size(62, 25);
            this.Lb_statusC.TabIndex = 129;
            this.Lb_statusC.Text = "關機";
            // 
            // Lb_statusD
            // 
            this.Lb_statusD.AutoSize = true;
            this.Lb_statusD.Font = new System.Drawing.Font("新細明體", 15F);
            this.Lb_statusD.Location = new System.Drawing.Point(1106, 384);
            this.Lb_statusD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_statusD.Name = "Lb_statusD";
            this.Lb_statusD.Size = new System.Drawing.Size(62, 25);
            this.Lb_statusD.TabIndex = 130;
            this.Lb_statusD.Text = "關機";
            // 
            // Btn_Produce
            // 
            this.Btn_Produce.Location = new System.Drawing.Point(345, 232);
            this.Btn_Produce.Name = "Btn_Produce";
            this.Btn_Produce.Size = new System.Drawing.Size(95, 44);
            this.Btn_Produce.TabIndex = 131;
            this.Btn_Produce.Text = "客製化製作";
            this.Btn_Produce.UseVisualStyleBackColor = true;
            this.Btn_Produce.Click += new System.EventHandler(this.Btn_Produce_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("新細明體", 15F);
            this.label17.Location = new System.Drawing.Point(340, 324);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 25);
            this.label17.TabIndex = 133;
            this.label17.Text = "粗加工:";
            // 
            // Lb_machingA
            // 
            this.Lb_machingA.AutoSize = true;
            this.Lb_machingA.Font = new System.Drawing.Font("新細明體", 15F);
            this.Lb_machingA.Location = new System.Drawing.Point(442, 322);
            this.Lb_machingA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_machingA.Name = "Lb_machingA";
            this.Lb_machingA.Size = new System.Drawing.Size(89, 25);
            this.Lb_machingA.TabIndex = 134;
            this.Lb_machingA.Text = "Dog_up";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 15F);
            this.label9.Location = new System.Drawing.Point(363, 286);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 135;
            this.label9.Text = "群集:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 15F);
            this.label10.Location = new System.Drawing.Point(315, 402);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 25);
            this.label10.TabIndex = 136;
            this.label10.Text = "加工產品:";
            // 
            // Lb_grouping
            // 
            this.Lb_grouping.AutoSize = true;
            this.Lb_grouping.Font = new System.Drawing.Font("新細明體", 15F);
            this.Lb_grouping.Location = new System.Drawing.Point(441, 286);
            this.Lb_grouping.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_grouping.Name = "Lb_grouping";
            this.Lb_grouping.Size = new System.Drawing.Size(113, 25);
            this.Lb_grouping.TabIndex = 138;
            this.Lb_grouping.Text = "A=>B=>C";
            // 
            // Lb_product
            // 
            this.Lb_product.AutoSize = true;
            this.Lb_product.Font = new System.Drawing.Font("新細明體", 15F);
            this.Lb_product.Location = new System.Drawing.Point(442, 402);
            this.Lb_product.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_product.Name = "Lb_product";
            this.Lb_product.Size = new System.Drawing.Size(87, 25);
            this.Lb_product.TabIndex = 139;
            this.Lb_product.Text = "筆記本";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("新細明體", 12F);
            this.label19.Location = new System.Drawing.Point(370, 147);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(174, 20);
            this.label19.TabIndex = 141;
            this.label19.Text = "顯示加工機台資訊:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("新細明體", 15F);
            this.label18.Location = new System.Drawing.Point(340, 363);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 25);
            this.label18.TabIndex = 142;
            this.label18.Text = "精加工:";
            // 
            // Lb_machingB
            // 
            this.Lb_machingB.AutoSize = true;
            this.Lb_machingB.Font = new System.Drawing.Font("新細明體", 15F);
            this.Lb_machingB.Location = new System.Drawing.Point(441, 363);
            this.Lb_machingB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_machingB.Name = "Lb_machingB";
            this.Lb_machingB.Size = new System.Drawing.Size(118, 25);
            this.Lb_machingB.TabIndex = 143;
            this.Lb_machingB.Text = "Dog_down";
            // 
            // Lbx_Produce
            // 
            this.Lbx_Produce.FormattingEnabled = true;
            this.Lbx_Produce.ItemHeight = 15;
            this.Lbx_Produce.Location = new System.Drawing.Point(289, 436);
            this.Lbx_Produce.Name = "Lbx_Produce";
            this.Lbx_Produce.Size = new System.Drawing.Size(298, 289);
            this.Lbx_Produce.TabIndex = 144;
            // 
            // MotionControl_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Lbx_Produce);
            this.Controls.Add(this.Lb_machingB);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.Lb_product);
            this.Controls.Add(this.Lb_grouping);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Lb_machingA);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Btn_Produce);
            this.Controls.Add(this.Lb_statusD);
            this.Controls.Add(this.Lb_statusC);
            this.Controls.Add(this.Lb_statusB);
            this.Controls.Add(this.Lb_statusA);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_MoveMD);
            this.Controls.Add(this.cb_MoveMC);
            this.Controls.Add(this.cb_MoveMB);
            this.Controls.Add(this.cb_MoveMA);
            this.Controls.Add(this.cb_MD);
            this.Controls.Add(this.cb_MC);
            this.Controls.Add(this.Ptb_M4);
            this.Controls.Add(this.Ptb_M3);
            this.Controls.Add(this.Ptb_M2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_MB);
            this.Controls.Add(this.cb_MA);
            this.Controls.Add(this.SystemButton);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.GcodeMoveBtn);
            this.Controls.Add(this.Btn_Import);
            this.Controls.Add(this.Btn_Export);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Btn_Move);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.zMoveValTextBox);
            this.Controls.Add(this.yMoveValTextBox);
            this.Controls.Add(this.xMoveValTextBox);
            this.Controls.Add(this.Ptb_M1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.MotionType);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SystemStatusButton);
            this.Controls.Add(this.zEncoderTextBox);
            this.Controls.Add(this.zCurPosTextBox);
            this.Controls.Add(this.yEncoderTextBox);
            this.Controls.Add(this.yCurPosTextBox);
            this.Controls.Add(this.xEncoderTextBox);
            this.Controls.Add(this.xCurPosTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MotionControl_UC";
            this.Size = new System.Drawing.Size(1449, 748);
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_M1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemStatusButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_M2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_M3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_M4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.Button GcodeMoveBtn;
        private System.Windows.Forms.Button Btn_Import;
        private System.Windows.Forms.Button Btn_Export;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Btn_Move;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox zMoveValTextBox;
        private System.Windows.Forms.TextBox yMoveValTextBox;
        private System.Windows.Forms.TextBox xMoveValTextBox;
        private System.Windows.Forms.PictureBox Ptb_M1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label MotionType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox SystemStatusButton;
        private System.Windows.Forms.TextBox zEncoderTextBox;
        private System.Windows.Forms.TextBox zCurPosTextBox;
        private System.Windows.Forms.TextBox yEncoderTextBox;
        private System.Windows.Forms.TextBox yCurPosTextBox;
        private System.Windows.Forms.TextBox xEncoderTextBox;
        private System.Windows.Forms.TextBox xCurPosTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button SystemButton;
        private System.Windows.Forms.CheckBox cb_MA;
        private System.Windows.Forms.CheckBox cb_MB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Ptb_M2;
        private System.Windows.Forms.PictureBox Ptb_M3;
        private System.Windows.Forms.PictureBox Ptb_M4;
        private System.Windows.Forms.CheckBox cb_MD;
        private System.Windows.Forms.CheckBox cb_MC;
        private System.Windows.Forms.CheckBox cb_MoveMD;
        private System.Windows.Forms.CheckBox cb_MoveMC;
        private System.Windows.Forms.CheckBox cb_MoveMB;
        private System.Windows.Forms.CheckBox cb_MoveMA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Lb_statusA;
        private System.Windows.Forms.Label Lb_statusB;
        private System.Windows.Forms.Label Lb_statusC;
        private System.Windows.Forms.Label Lb_statusD;
        private System.Windows.Forms.Button Btn_Produce;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label Lb_machingA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label Lb_grouping;
        public System.Windows.Forms.Label Lb_product;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label Lb_machingB;
        private System.Windows.Forms.ListBox Lbx_Produce;
    }
}
