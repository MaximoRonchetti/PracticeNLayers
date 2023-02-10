namespace UI
{
    partial class DepartamentView
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
            this.dgvDepartaments = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdDepartament = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkIsActiveDepartament = new System.Windows.Forms.CheckBox();
            this.txtDescriptionDepartament = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefreshDepartament = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartaments)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDepartaments
            // 
            this.dgvDepartaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartaments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Description,
            this.IsActive});
            this.dgvDepartaments.Location = new System.Drawing.Point(413, 24);
            this.dgvDepartaments.Name = "dgvDepartaments";
            this.dgvDepartaments.ReadOnly = true;
            this.dgvDepartaments.RowHeadersWidth = 51;
            this.dgvDepartaments.RowTemplate.Height = 29;
            this.dgvDepartaments.Size = new System.Drawing.Size(679, 266);
            this.dgvDepartaments.TabIndex = 4;
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
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 300;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "Is Active";
            this.IsActive.MinimumWidth = 6;
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            this.IsActive.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdDepartament);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkIsActiveDepartament);
            this.groupBox1.Controls.Add(this.txtDescriptionDepartament);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 251);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Departament";
            // 
            // txtIdDepartament
            // 
            this.txtIdDepartament.Enabled = false;
            this.txtIdDepartament.Location = new System.Drawing.Point(139, 50);
            this.txtIdDepartament.Name = "txtIdDepartament";
            this.txtIdDepartament.ReadOnly = true;
            this.txtIdDepartament.Size = new System.Drawing.Size(125, 27);
            this.txtIdDepartament.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // chkIsActiveDepartament
            // 
            this.chkIsActiveDepartament.AutoSize = true;
            this.chkIsActiveDepartament.Location = new System.Drawing.Point(21, 142);
            this.chkIsActiveDepartament.Name = "chkIsActiveDepartament";
            this.chkIsActiveDepartament.Size = new System.Drawing.Size(86, 24);
            this.chkIsActiveDepartament.TabIndex = 16;
            this.chkIsActiveDepartament.Text = "Is Active";
            this.chkIsActiveDepartament.UseVisualStyleBackColor = true;
            // 
            // txtDescriptionDepartament
            // 
            this.txtDescriptionDepartament.Location = new System.Drawing.Point(139, 93);
            this.txtDescriptionDepartament.Multiline = true;
            this.txtDescriptionDepartament.Name = "txtDescriptionDepartament";
            this.txtDescriptionDepartament.Size = new System.Drawing.Size(212, 77);
            this.txtDescriptionDepartament.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(257, 203);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefreshDepartament
            // 
            this.btnRefreshDepartament.Location = new System.Drawing.Point(1160, 148);
            this.btnRefreshDepartament.Name = "btnRefreshDepartament";
            this.btnRefreshDepartament.Size = new System.Drawing.Size(94, 29);
            this.btnRefreshDepartament.TabIndex = 15;
            this.btnRefreshDepartament.Text = "Refresh";
            this.btnRefreshDepartament.UseVisualStyleBackColor = true;
            this.btnRefreshDepartament.Click += new System.EventHandler(this.btnRefreshDepartament_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1160, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1149, 38);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 51);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Load Departament";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // DepartamentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 449);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvDepartaments);
            this.Controls.Add(this.btnRefreshDepartament);
            this.Controls.Add(this.groupBox1);
            this.Name = "DepartamentView";
            this.Text = "DepartamentView";
            this.Load += new System.EventHandler(this.DepartamentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartaments)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvDepartaments;
        private GroupBox groupBox1;
        private Button btnRefreshDepartament;
        private Button btnSave;
        private TextBox txtDescriptionDepartament;
        private Label label2;
        private CheckBox chkIsActiveDepartament;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn IsActive;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtIdDepartament;
        private Label label1;
    }
}