namespace UI
{
    partial class EmployeeView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdEmployee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkListProject = new System.Windows.Forms.CheckedListBox();
            this.cboDepartaments = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDateOfBirthEmployee = new System.Windows.Forms.DateTimePicker();
            this.txtIDNumEmployee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLastNameEmployee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNameEmployee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdEmployee);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkListProject);
            this.groupBox1.Controls.Add(this.cboDepartaments);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.dtpDateOfBirthEmployee);
            this.groupBox1.Controls.Add(this.txtIDNumEmployee);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtLastNameEmployee);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNameEmployee);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 461);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee";
            // 
            // txtIdEmployee
            // 
            this.txtIdEmployee.Enabled = false;
            this.txtIdEmployee.Location = new System.Drawing.Point(146, 26);
            this.txtIdEmployee.Name = "txtIdEmployee";
            this.txtIdEmployee.ReadOnly = true;
            this.txtIdEmployee.Size = new System.Drawing.Size(125, 27);
            this.txtIdEmployee.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Projects";
            // 
            // chkListProject
            // 
            this.chkListProject.FormattingEnabled = true;
            this.chkListProject.Location = new System.Drawing.Point(146, 282);
            this.chkListProject.Name = "chkListProject";
            this.chkListProject.Size = new System.Drawing.Size(150, 114);
            this.chkListProject.TabIndex = 16;
            // 
            // cboDepartaments
            // 
            this.cboDepartaments.FormattingEnabled = true;
            this.cboDepartaments.Location = new System.Drawing.Point(146, 238);
            this.cboDepartaments.Name = "cboDepartaments";
            this.cboDepartaments.Size = new System.Drawing.Size(151, 28);
            this.cboDepartaments.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(202, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDateOfBirthEmployee
            // 
            this.dtpDateOfBirthEmployee.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirthEmployee.Location = new System.Drawing.Point(146, 194);
            this.dtpDateOfBirthEmployee.Name = "dtpDateOfBirthEmployee";
            this.dtpDateOfBirthEmployee.Size = new System.Drawing.Size(125, 27);
            this.dtpDateOfBirthEmployee.TabIndex = 12;
            // 
            // txtIDNumEmployee
            // 
            this.txtIDNumEmployee.Location = new System.Drawing.Point(146, 150);
            this.txtIDNumEmployee.Name = "txtIDNumEmployee";
            this.txtIDNumEmployee.Size = new System.Drawing.Size(125, 27);
            this.txtIDNumEmployee.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Departament";
            // 
            // txtLastNameEmployee
            // 
            this.txtLastNameEmployee.Location = new System.Drawing.Point(146, 108);
            this.txtLastNameEmployee.Name = "txtLastNameEmployee";
            this.txtLastNameEmployee.Size = new System.Drawing.Size(125, 27);
            this.txtLastNameEmployee.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date of Birth";
            // 
            // txtNameEmployee
            // 
            this.txtNameEmployee.Location = new System.Drawing.Point(146, 64);
            this.txtNameEmployee.Name = "txtNameEmployee";
            this.txtNameEmployee.Size = new System.Drawing.Size(125, 27);
            this.txtNameEmployee.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FullName,
            this.IdNumber,
            this.DateOfBirth});
            this.dgvEmployees.Location = new System.Drawing.Point(339, 21);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 29;
            this.dgvEmployees.Size = new System.Drawing.Size(722, 266);
            this.dgvEmployees.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "GetFullName";
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 125;
            // 
            // IdNumber
            // 
            this.IdNumber.DataPropertyName = "IdNumber";
            this.IdNumber.HeaderText = "ID Number";
            this.IdNumber.MinimumWidth = 6;
            this.IdNumber.Name = "IdNumber";
            this.IdNumber.ReadOnly = true;
            this.IdNumber.Width = 125;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.DateOfBirth.DefaultCellStyle = dataGridViewCellStyle1;
            this.DateOfBirth.HeaderText = "Date of Birth";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            this.DateOfBirth.Width = 125;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1168, 112);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1168, 45);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 51);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Load Employee";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1168, 157);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 29);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 541);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeeView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormOne_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private TextBox txtLastNameEmployee;
        private Label label3;
        private TextBox txtNameEmployee;
        private Label label2;
        private TextBox txtIDNumEmployee;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpDateOfBirthEmployee;
        private Button btnSave;
        private DataGridView dgvEmployees;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn IdNumber;
        private DataGridViewTextBoxColumn DateOfBirth;
        private ComboBox cboDepartaments;
        private Label label6;
        private Label label1;
        private CheckedListBox chkListProject;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnRefresh;
        private TextBox txtIdEmployee;
        private Label label7;
    }
}