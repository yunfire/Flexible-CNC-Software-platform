namespace EPCIO
{
    partial class File_management
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
            this.ProductList = new System.Windows.Forms.ListBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_DeleteGcode = new System.Windows.Forms.Button();
            this.Btn_Choose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lb_Product = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lb_Smoothing = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lb_Roughing = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_ChooseSmooth = new System.Windows.Forms.Button();
            this.Btn_ChooseRough = new System.Windows.Forms.Button();
            this.Rb_Notebook = new System.Windows.Forms.RadioButton();
            this.Rb_Coaster = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Lb_Grouping = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductList
            // 
            this.ProductList.Font = new System.Drawing.Font("新細明體", 20F);
            this.ProductList.FormattingEnabled = true;
            this.ProductList.ItemHeight = 33;
            this.ProductList.Location = new System.Drawing.Point(3, 3);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(901, 664);
            this.ProductList.TabIndex = 0;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Font = new System.Drawing.Font("新細明體", 20F);
            this.Btn_Add.Location = new System.Drawing.Point(910, 482);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(536, 82);
            this.Btn_Add.TabIndex = 1;
            this.Btn_Add.Text = "添加Gcode檔案";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_DeleteGcode
            // 
            this.Btn_DeleteGcode.Font = new System.Drawing.Font("新細明體", 20F);
            this.Btn_DeleteGcode.Location = new System.Drawing.Point(910, 582);
            this.Btn_DeleteGcode.Name = "Btn_DeleteGcode";
            this.Btn_DeleteGcode.Size = new System.Drawing.Size(536, 82);
            this.Btn_DeleteGcode.TabIndex = 2;
            this.Btn_DeleteGcode.Text = "刪除Gcode檔案";
            this.Btn_DeleteGcode.UseVisualStyleBackColor = true;
            this.Btn_DeleteGcode.Click += new System.EventHandler(this.Btn_DeleteGcode_Click);
            // 
            // Btn_Choose
            // 
            this.Btn_Choose.Font = new System.Drawing.Font("新細明體", 20F);
            this.Btn_Choose.Location = new System.Drawing.Point(15, 22);
            this.Btn_Choose.Name = "Btn_Choose";
            this.Btn_Choose.Size = new System.Drawing.Size(493, 82);
            this.Btn_Choose.TabIndex = 3;
            this.Btn_Choose.Text = "確認檔案";
            this.Btn_Choose.UseVisualStyleBackColor = true;
            this.Btn_Choose.Click += new System.EventHandler(this.Btn_Choose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lb_Grouping);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Lb_Product);
            this.groupBox1.Controls.Add(this.Btn_Choose);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Lb_Smoothing);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Lb_Roughing);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Btn_ChooseSmooth);
            this.groupBox1.Controls.Add(this.Btn_ChooseRough);
            this.groupBox1.Controls.Add(this.Rb_Notebook);
            this.groupBox1.Controls.Add(this.Rb_Coaster);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 15F);
            this.groupBox1.Location = new System.Drawing.Point(913, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 422);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "產品";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 137;
            // 
            // Lb_Product
            // 
            this.Lb_Product.AutoSize = true;
            this.Lb_Product.Location = new System.Drawing.Point(249, 133);
            this.Lb_Product.Name = "Lb_Product";
            this.Lb_Product.Size = new System.Drawing.Size(37, 25);
            this.Lb_Product.TabIndex = 136;
            this.Lb_Product.Text = "無";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 135;
            this.label6.Text = "產品:";
            // 
            // Lb_Smoothing
            // 
            this.Lb_Smoothing.AutoSize = true;
            this.Lb_Smoothing.Location = new System.Drawing.Point(249, 332);
            this.Lb_Smoothing.Name = "Lb_Smoothing";
            this.Lb_Smoothing.Size = new System.Drawing.Size(37, 25);
            this.Lb_Smoothing.TabIndex = 134;
            this.Lb_Smoothing.Text = "無";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 133;
            this.label2.Text = "檔案:";
            // 
            // Lb_Roughing
            // 
            this.Lb_Roughing.AutoSize = true;
            this.Lb_Roughing.Location = new System.Drawing.Point(249, 245);
            this.Lb_Roughing.Name = "Lb_Roughing";
            this.Lb_Roughing.Size = new System.Drawing.Size(37, 25);
            this.Lb_Roughing.TabIndex = 131;
            this.Lb_Roughing.Text = "無";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 129;
            this.label1.Text = "檔案:";
            // 
            // Btn_ChooseSmooth
            // 
            this.Btn_ChooseSmooth.Font = new System.Drawing.Font("新細明體", 10F);
            this.Btn_ChooseSmooth.Location = new System.Drawing.Point(6, 322);
            this.Btn_ChooseSmooth.Name = "Btn_ChooseSmooth";
            this.Btn_ChooseSmooth.Size = new System.Drawing.Size(150, 49);
            this.Btn_ChooseSmooth.TabIndex = 128;
            this.Btn_ChooseSmooth.Text = "選取精加工檔案";
            this.Btn_ChooseSmooth.UseVisualStyleBackColor = true;
            this.Btn_ChooseSmooth.Click += new System.EventHandler(this.Btn_ChooseSmooth_Click);
            // 
            // Btn_ChooseRough
            // 
            this.Btn_ChooseRough.Font = new System.Drawing.Font("新細明體", 10F);
            this.Btn_ChooseRough.Location = new System.Drawing.Point(6, 235);
            this.Btn_ChooseRough.Name = "Btn_ChooseRough";
            this.Btn_ChooseRough.Size = new System.Drawing.Size(150, 49);
            this.Btn_ChooseRough.TabIndex = 127;
            this.Btn_ChooseRough.Text = "選取粗加工檔案";
            this.Btn_ChooseRough.UseVisualStyleBackColor = true;
            this.Btn_ChooseRough.Click += new System.EventHandler(this.Btn_ChooseRough_Click);
            // 
            // Rb_Notebook
            // 
            this.Rb_Notebook.AutoSize = true;
            this.Rb_Notebook.Font = new System.Drawing.Font("新細明體", 20F);
            this.Rb_Notebook.Location = new System.Drawing.Point(15, 161);
            this.Rb_Notebook.Name = "Rb_Notebook";
            this.Rb_Notebook.Size = new System.Drawing.Size(138, 38);
            this.Rb_Notebook.TabIndex = 1;
            this.Rb_Notebook.TabStop = true;
            this.Rb_Notebook.Text = "筆記本";
            this.Rb_Notebook.UseVisualStyleBackColor = true;
            this.Rb_Notebook.CheckedChanged += new System.EventHandler(this.Rb_Notebook_CheckedChanged);
            // 
            // Rb_Coaster
            // 
            this.Rb_Coaster.AutoSize = true;
            this.Rb_Coaster.Font = new System.Drawing.Font("新細明體", 20F);
            this.Rb_Coaster.Location = new System.Drawing.Point(15, 120);
            this.Rb_Coaster.Name = "Rb_Coaster";
            this.Rb_Coaster.Size = new System.Drawing.Size(104, 38);
            this.Rb_Coaster.TabIndex = 0;
            this.Rb_Coaster.TabStop = true;
            this.Rb_Coaster.Text = "杯墊";
            this.Rb_Coaster.UseVisualStyleBackColor = true;
            this.Rb_Coaster.CheckedChanged += new System.EventHandler(this.Rb_Coaster_CheckedChanged);
            // 
            // Lb_Grouping
            // 
            this.Lb_Grouping.AutoSize = true;
            this.Lb_Grouping.Location = new System.Drawing.Point(249, 170);
            this.Lb_Grouping.Name = "Lb_Grouping";
            this.Lb_Grouping.Size = new System.Drawing.Size(37, 25);
            this.Lb_Grouping.TabIndex = 139;
            this.Lb_Grouping.Text = "無";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 138;
            this.label5.Text = "群集:";
            // 
            // File_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_DeleteGcode);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.ProductList);
            this.Name = "File_management";
            this.Size = new System.Drawing.Size(1449, 748);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_DeleteGcode;
        public System.Windows.Forms.Button Btn_Choose;
        public System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rb_Notebook;
        private System.Windows.Forms.RadioButton Rb_Coaster;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button Btn_ChooseSmooth;
        public System.Windows.Forms.Button Btn_ChooseRough;
        public System.Windows.Forms.Label Lb_Product;
        public System.Windows.Forms.Label Lb_Smoothing;
        public System.Windows.Forms.Label Lb_Roughing;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label Lb_Grouping;
        private System.Windows.Forms.Label label5;
    }
}
