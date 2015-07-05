namespace WindowsFormsApplication1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtByName = new System.Windows.Forms.TextBox();
            this.txtByNumber = new System.Windows.Forms.TextBox();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.btnSearchByNumber = new System.Windows.Forms.Button();
            this.dgvContact = new System.Windows.Forms.DataGridView();
            this.Name_zdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender_zdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_zdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number_zdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_zdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Relationship_zdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.btnSearchByGroup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(39, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新增信息";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(164, 44);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 25);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "修改信息";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(298, 44);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除信息";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtByName
            // 
            this.txtByName.Location = new System.Drawing.Point(39, 100);
            this.txtByName.Name = "txtByName";
            this.txtByName.Size = new System.Drawing.Size(150, 20);
            this.txtByName.TabIndex = 4;
            // 
            // txtByNumber
            // 
            this.txtByNumber.Location = new System.Drawing.Point(298, 96);
            this.txtByNumber.Name = "txtByNumber";
            this.txtByNumber.Size = new System.Drawing.Size(131, 20);
            this.txtByNumber.TabIndex = 5;
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Location = new System.Drawing.Point(195, 96);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(75, 25);
            this.btnSearchByName.TabIndex = 6;
            this.btnSearchByName.Text = "按姓名查找";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // btnSearchByNumber
            // 
            this.btnSearchByNumber.Location = new System.Drawing.Point(456, 100);
            this.btnSearchByNumber.Name = "btnSearchByNumber";
            this.btnSearchByNumber.Size = new System.Drawing.Size(108, 25);
            this.btnSearchByNumber.TabIndex = 7;
            this.btnSearchByNumber.Text = "按电话号码查找";
            this.btnSearchByNumber.UseVisualStyleBackColor = true;
            this.btnSearchByNumber.Click += new System.EventHandler(this.btnSearchByNumber_Click);
            // 
            // dgvContact
            // 
            this.dgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_zdt,
            this.Gender_zdt,
            this.Unit_zdt,
            this.Number_zdt,
            this.Address_zdt,
            this.Relationship_zdt});
            this.dgvContact.Location = new System.Drawing.Point(30, 145);
            this.dgvContact.Name = "dgvContact";
            this.dgvContact.RowTemplate.Height = 23;
            this.dgvContact.Size = new System.Drawing.Size(649, 322);
            this.dgvContact.TabIndex = 8;
            this.dgvContact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContact_CellContentClick);
            // 
            // Name_zdt
            // 
            this.Name_zdt.DataPropertyName = "Name_zdt";
            this.Name_zdt.HeaderText = "姓名";
            this.Name_zdt.Name = "Name_zdt";
            // 
            // Gender_zdt
            // 
            this.Gender_zdt.DataPropertyName = "Gender_zdt";
            this.Gender_zdt.HeaderText = "性别";
            this.Gender_zdt.Name = "Gender_zdt";
            // 
            // Unit_hs
            // 
            this.Unit_zdt.DataPropertyName = "Unit_zdt";
            this.Unit_zdt.HeaderText = "单位";
            this.Unit_zdt.Name = "Unit_zdt";
            // 
            // Number_zdt
            // 
            this.Number_zdt.DataPropertyName = "Number_zdt";
            this.Number_zdt.HeaderText = "电话";
            this.Number_zdt.Name = "Number_zdt";
            // 
            // Address_zdt
            // 
            this.Address_zdt.DataPropertyName = "Address_zdt";
            this.Address_zdt.HeaderText = "住址";
            this.Address_zdt.Name = "Address_zdt";
            // 
            // Relationship_zdt
            // 
            this.Relationship_zdt.DataPropertyName = "Relationship_zdt";
            this.Relationship_zdt.HeaderText = "关系";
            this.Relationship_zdt.Name = "Relationship_zdt";
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Items.AddRange(new object[] {
            "朋友",
            "同事",
            "家人",
            "全部"});
            this.cmbGroup.Location = new System.Drawing.Point(456, 23);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(121, 21);
            this.cmbGroup.TabIndex = 9;
            // 
            // btnSearchByGroup
            // 
            this.btnSearchByGroup.Location = new System.Drawing.Point(604, 21);
            this.btnSearchByGroup.Name = "btnSearchByGroup";
            this.btnSearchByGroup.Size = new System.Drawing.Size(75, 25);
            this.btnSearchByGroup.TabIndex = 10;
            this.btnSearchByGroup.Text = "按分组查找";
            this.btnSearchByGroup.UseVisualStyleBackColor = true;
            this.btnSearchByGroup.Click += new System.EventHandler(this.btnSearchByGroup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 540);
            this.Controls.Add(this.btnSearchByGroup);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.dgvContact);
            this.Controls.Add(this.btnSearchByNumber);
            this.Controls.Add(this.btnSearchByName);
            this.Controls.Add(this.txtByNumber);
            this.Controls.Add(this.txtByName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtByName;
        private System.Windows.Forms.TextBox txtByNumber;
        private System.Windows.Forms.Button btnSearchByName;
        private System.Windows.Forms.Button btnSearchByNumber;
        private System.Windows.Forms.DataGridView dgvContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_zdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender_zdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_zdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_zdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_zdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Relationship_zdt;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Button btnSearchByGroup;
    }
}

