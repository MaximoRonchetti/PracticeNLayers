namespace UI
{
    partial class ProjectView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsFinished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdProject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBudgetProject = new System.Windows.Forms.TextBox();
            this.chkIsFinished = new System.Windows.Forms.CheckBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.btnSaveProject = new System.Windows.Forms.Button();
            this.txtDurationDays = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitleProject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescriptionProject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefreshProjects = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Budget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProjects
            // 
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.IsActive,
            this.IsFinished});
            this.dgvProjects.Location = new System.Drawing.Point(337, 28);
            this.dgvProjects.MultiSelect = false;
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.RowHeadersWidth = 51;
            this.dgvProjects.RowTemplate.Height = 29;
            this.dgvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjects.Size = new System.Drawing.Size(881, 287);
            this.dgvProjects.TabIndex = 4;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn3.HeaderText = "Title";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DurationDays";
            this.dataGridViewTextBoxColumn4.HeaderText = "Duration Days";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Budget";
            this.dataGridViewTextBoxColumn5.HeaderText = "Budget";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
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
            // IsFinished
            // 
            this.IsFinished.DataPropertyName = "IsFinished";
            this.IsFinished.HeaderText = "Is Finished";
            this.IsFinished.MinimumWidth = 6;
            this.IsFinished.Name = "IsFinished";
            this.IsFinished.ReadOnly = true;
            this.IsFinished.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdProject);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBudgetProject);
            this.groupBox1.Controls.Add(this.chkIsFinished);
            this.groupBox1.Controls.Add(this.chkIsActive);
            this.groupBox1.Controls.Add(this.btnSaveProject);
            this.groupBox1.Controls.Add(this.txtDurationDays);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTitleProject);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDescriptionProject);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 403);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project";
            // 
            // txtIdProject
            // 
            this.txtIdProject.Enabled = false;
            this.txtIdProject.Location = new System.Drawing.Point(141, 38);
            this.txtIdProject.Name = "txtIdProject";
            this.txtIdProject.ReadOnly = true;
            this.txtIdProject.Size = new System.Drawing.Size(125, 27);
            this.txtIdProject.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            // 
            // txtBudgetProject
            // 
            this.txtBudgetProject.Location = new System.Drawing.Point(141, 212);
            this.txtBudgetProject.Name = "txtBudgetProject";
            this.txtBudgetProject.Size = new System.Drawing.Size(125, 27);
            this.txtBudgetProject.TabIndex = 18;
            // 
            // chkIsFinished
            // 
            this.chkIsFinished.AutoSize = true;
            this.chkIsFinished.Location = new System.Drawing.Point(141, 251);
            this.chkIsFinished.Name = "chkIsFinished";
            this.chkIsFinished.Size = new System.Drawing.Size(99, 24);
            this.chkIsFinished.TabIndex = 17;
            this.chkIsFinished.Text = "Is Finished";
            this.chkIsFinished.UseVisualStyleBackColor = true;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(11, 251);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(86, 24);
            this.chkIsActive.TabIndex = 16;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.Location = new System.Drawing.Point(172, 349);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(94, 29);
            this.btnSaveProject.TabIndex = 13;
            this.btnSaveProject.Text = "Save";
            this.btnSaveProject.UseVisualStyleBackColor = true;
            this.btnSaveProject.Click += new System.EventHandler(this.btnSaveProject_Click);
            // 
            // txtDurationDays
            // 
            this.txtDurationDays.Location = new System.Drawing.Point(141, 168);
            this.txtDurationDays.Name = "txtDurationDays";
            this.txtDurationDays.Size = new System.Drawing.Size(125, 27);
            this.txtDurationDays.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Duration Days";
            // 
            // txtTitleProject
            // 
            this.txtTitleProject.Location = new System.Drawing.Point(141, 126);
            this.txtTitleProject.Name = "txtTitleProject";
            this.txtTitleProject.Size = new System.Drawing.Size(125, 27);
            this.txtTitleProject.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Budget";
            // 
            // txtDescriptionProject
            // 
            this.txtDescriptionProject.Location = new System.Drawing.Point(141, 82);
            this.txtDescriptionProject.Name = "txtDescriptionProject";
            this.txtDescriptionProject.Size = new System.Drawing.Size(125, 27);
            this.txtDescriptionProject.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // btnRefreshProjects
            // 
            this.btnRefreshProjects.Location = new System.Drawing.Point(1269, 144);
            this.btnRefreshProjects.Name = "btnRefreshProjects";
            this.btnRefreshProjects.Size = new System.Drawing.Size(94, 29);
            this.btnRefreshProjects.TabIndex = 15;
            this.btnRefreshProjects.Text = "Refresh";
            this.btnRefreshProjects.UseVisualStyleBackColor = true;
            this.btnRefreshProjects.Click += new System.EventHandler(this.btnRefreshProjects_Click);
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
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 125;
            // 
            // DurationDays
            // 
            this.DurationDays.DataPropertyName = "DurationDays";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.DurationDays.DefaultCellStyle = dataGridViewCellStyle1;
            this.DurationDays.HeaderText = "Duration Days";
            this.DurationDays.MinimumWidth = 6;
            this.DurationDays.Name = "DurationDays";
            this.DurationDays.ReadOnly = true;
            this.DurationDays.Width = 125;
            // 
            // Budget
            // 
            this.Budget.HeaderText = "Budget";
            this.Budget.MinimumWidth = 6;
            this.Budget.Name = "Budget";
            this.Budget.ReadOnly = true;
            this.Budget.Width = 125;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1269, 32);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 51);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Load Project";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1269, 99);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 607);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvProjects);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRefreshProjects);
            this.Name = "ProjectView";
            this.Text = "ProjectView";
            this.Load += new System.EventHandler(this.ProjectView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvProjects;
        private GroupBox groupBox1;
        private Button btnRefreshProjects;
        private Button btnSaveProject;
        private TextBox txtDurationDays;
        private Label label4;
        private TextBox txtTitleProject;
        private Label label3;
        private Label label5;
        private TextBox txtDescriptionProject;
        private Label label2;
        private CheckBox chkIsFinished;
        private CheckBox chkIsActive;
        private TextBox txtBudgetProject;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn DurationDays;
        private DataGridViewTextBoxColumn Budget;
        private TextBox txtIdProject;
        private Label label1;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn IsActive;
        private DataGridViewTextBoxColumn IsFinished;
    }
}