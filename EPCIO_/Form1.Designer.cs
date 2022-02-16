namespace EPCIO
{
    partial class Form1
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.verticalAxisLabe = new System.Windows.Forms.Label();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.MotionBtn = new System.Windows.Forms.Button();
            this.ParaBtn = new System.Windows.Forms.Button();
            this.btn_Tool = new System.Windows.Forms.Button();
            this.Btn_FileManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // verticalAxisLabe
            // 
            this.verticalAxisLabe.AutoSize = true;
            this.verticalAxisLabe.Font = new System.Drawing.Font("新細明體", 15F);
            this.verticalAxisLabe.Location = new System.Drawing.Point(-21, 554);
            this.verticalAxisLabe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.verticalAxisLabe.Name = "verticalAxisLabe";
            this.verticalAxisLabe.Size = new System.Drawing.Size(28, 25);
            this.verticalAxisLabe.TabIndex = 42;
            this.verticalAxisLabe.Text = "B";
            this.verticalAxisLabe.UseWaitCursor = true;
            // 
            // pnlShow
            // 
            this.pnlShow.Location = new System.Drawing.Point(1, 1);
            this.pnlShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(1449, 748);
            this.pnlShow.TabIndex = 67;
            // 
            // MotionBtn
            // 
            this.MotionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.MotionBtn.Location = new System.Drawing.Point(36, 755);
            this.MotionBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MotionBtn.Name = "MotionBtn";
            this.MotionBtn.Size = new System.Drawing.Size(184, 68);
            this.MotionBtn.TabIndex = 68;
            this.MotionBtn.Text = "軌跡控制";
            this.MotionBtn.UseVisualStyleBackColor = true;
            this.MotionBtn.Click += new System.EventHandler(this.MotionBtn_Click);
            // 
            // ParaBtn
            // 
            this.ParaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ParaBtn.Location = new System.Drawing.Point(254, 755);
            this.ParaBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ParaBtn.Name = "ParaBtn";
            this.ParaBtn.Size = new System.Drawing.Size(184, 68);
            this.ParaBtn.TabIndex = 69;
            this.ParaBtn.Text = "參數設定";
            this.ParaBtn.UseVisualStyleBackColor = true;
            this.ParaBtn.Click += new System.EventHandler(this.ParaBtn_Click);
            // 
            // btn_Tool
            // 
            this.btn_Tool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_Tool.Location = new System.Drawing.Point(472, 755);
            this.btn_Tool.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Tool.Name = "btn_Tool";
            this.btn_Tool.Size = new System.Drawing.Size(184, 68);
            this.btn_Tool.TabIndex = 70;
            this.btn_Tool.Text = "刀具設定";
            this.btn_Tool.UseVisualStyleBackColor = true;
            this.btn_Tool.Click += new System.EventHandler(this.btn_Tool_Click);
            // 
            // Btn_FileManagement
            // 
            this.Btn_FileManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Btn_FileManagement.Location = new System.Drawing.Point(690, 755);
            this.Btn_FileManagement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_FileManagement.Name = "Btn_FileManagement";
            this.Btn_FileManagement.Size = new System.Drawing.Size(184, 68);
            this.Btn_FileManagement.TabIndex = 71;
            this.Btn_FileManagement.Text = "產品管理";
            this.Btn_FileManagement.UseVisualStyleBackColor = true;
            this.Btn_FileManagement.Click += new System.EventHandler(this.Btn_FileManagement_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1445, 856);
            this.Controls.Add(this.Btn_FileManagement);
            this.Controls.Add(this.btn_Tool);
            this.Controls.Add(this.ParaBtn);
            this.Controls.Add(this.MotionBtn);
            this.Controls.Add(this.pnlShow);
            this.Controls.Add(this.verticalAxisLabe);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CNC加工平台";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label verticalAxisLabe;
        private System.Windows.Forms.Panel pnlShow;
        private System.Windows.Forms.Button MotionBtn;
        private System.Windows.Forms.Button ParaBtn;
        private System.Windows.Forms.Button btn_Tool;
        private System.Windows.Forms.Button Btn_FileManagement;
    }
}

