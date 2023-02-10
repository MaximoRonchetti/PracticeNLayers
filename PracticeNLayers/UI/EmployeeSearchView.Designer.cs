namespace UI
{
    partial class EmployeeSearchView
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboDepartaments = new System.Windows.Forms.ComboBox();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvEmployeeSearch = new System.Windows.Forms.DataGridView();
            this.bndEmployeeList = new System.Windows.Forms.BindingSource(this.components);
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndEmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboDepartaments);
            this.groupBox1.Controls.Add(this.txtIdNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1423, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1323, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clean";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Departament";
            // 
            // cboDepartaments
            // 
            this.cboDepartaments.FormattingEnabled = true;
            this.cboDepartaments.Location = new System.Drawing.Point(382, 77);
            this.cboDepartaments.Name = "cboDepartaments";
            this.cboDepartaments.Size = new System.Drawing.Size(151, 28);
            this.cboDepartaments.TabIndex = 7;
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(408, 24);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(125, 27);
            this.txtIdNumber.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID Number";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(97, 78);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(125, 27);
            this.txtLastName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1323, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvEmployeeSearch
            // 
            this.dgvEmployeeSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colLastName,
            this.colIdNumber,
            this.colDepartament});
            this.dgvEmployeeSearch.Location = new System.Drawing.Point(12, 164);
            this.dgvEmployeeSearch.Name = "dgvEmployeeSearch";
            this.dgvEmployeeSearch.RowHeadersWidth = 51;
            this.dgvEmployeeSearch.RowTemplate.Height = 29;
            this.dgvEmployeeSearch.Size = new System.Drawing.Size(1423, 329);
            this.dgvEmployeeSearch.TabIndex = 1;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 125;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.MinimumWidth = 6;
            this.colLastName.Name = "colLastName";
            this.colLastName.Width = 125;
            // 
            // colIdNumber
            // 
            this.colIdNumber.DataPropertyName = "IdNumber";
            this.colIdNumber.HeaderText = "ID Number";
            this.colIdNumber.MinimumWidth = 6;
            this.colIdNumber.Name = "colIdNumber";
            this.colIdNumber.Width = 125;
            // 
            // colDepartament
            // 
            this.colDepartament.DataPropertyName = "GetDepartamentDescription";
            this.colDepartament.HeaderText = "Departament";
            this.colDepartament.MinimumWidth = 6;
            this.colDepartament.Name = "colDepartament";
            this.colDepartament.Width = 125;
            // 
            // EmployeeSearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 675);
            this.Controls.Add(this.dgvEmployeeSearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeeSearchView";
            this.Text = "EmployeeSearchView";
            this.Load += new System.EventHandler(this.EmployeeSearchView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndEmployeeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvEmployeeSearch;
        private Button btnSearch;
        private TextBox txtIdNumber;
        private Label label3;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private Label label4;
        private ComboBox cboDepartaments;
        private Button button1;
        private BindingSource bndEmployeeList;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colIdNumber;
        private DataGridViewTextBoxColumn colDepartament;
    }
}