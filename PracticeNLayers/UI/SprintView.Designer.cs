namespace UI
{
    partial class SprintView
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvSprint = new System.Windows.Forms.DataGridView();
            this.btnRefreshDepartament = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboProjects = new System.Windows.Forms.ComboBox();
            this.dtpDateOfFinish = new System.Windows.Forms.DateTimePicker();
            this.dtpDateOfStart = new System.Windows.Forms.DateTimePicker();
            this.txtMaxDaysToComplete = new System.Windows.Forms.TextBox();
            this.txtPercentComplete = new System.Windows.Forms.TextBox();
            this.txtOrderSprint = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdSprint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescriptionSprint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentComplete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDaysToComplete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSprint)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1347, 102);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1336, 62);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(116, 34);
            this.btnLoad.TabIndex = 21;
            this.btnLoad.Text = "Load Sprint";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvSprint
            // 
            this.dgvSprint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSprint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Description,
            this.percentComplete,
            this.startingDate,
            this.maxDaysToComplete,
            this.endingDate});
            this.dgvSprint.Location = new System.Drawing.Point(384, 19);
            this.dgvSprint.Name = "dgvSprint";
            this.dgvSprint.ReadOnly = true;
            this.dgvSprint.RowHeadersWidth = 51;
            this.dgvSprint.RowTemplate.Height = 29;
            this.dgvSprint.Size = new System.Drawing.Size(919, 266);
            this.dgvSprint.TabIndex = 19;
            // 
            // btnRefreshDepartament
            // 
            this.btnRefreshDepartament.Location = new System.Drawing.Point(1347, 137);
            this.btnRefreshDepartament.Name = "btnRefreshDepartament";
            this.btnRefreshDepartament.Size = new System.Drawing.Size(94, 29);
            this.btnRefreshDepartament.TabIndex = 20;
            this.btnRefreshDepartament.Text = "Refresh";
            this.btnRefreshDepartament.UseVisualStyleBackColor = true;
            this.btnRefreshDepartament.Click += new System.EventHandler(this.btnRefreshDepartament_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboProjects);
            this.groupBox1.Controls.Add(this.dtpDateOfFinish);
            this.groupBox1.Controls.Add(this.dtpDateOfStart);
            this.groupBox1.Controls.Add(this.txtMaxDaysToComplete);
            this.groupBox1.Controls.Add(this.txtPercentComplete);
            this.groupBox1.Controls.Add(this.txtOrderSprint);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdSprint);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescriptionSprint);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(20, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 465);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sprint";
            // 
            // cboProjects
            // 
            this.cboProjects.FormattingEnabled = true;
            this.cboProjects.Location = new System.Drawing.Point(156, 345);
            this.cboProjects.Name = "cboProjects";
            this.cboProjects.Size = new System.Drawing.Size(151, 28);
            this.cboProjects.TabIndex = 33;
            // 
            // dtpDateOfFinish
            // 
            this.dtpDateOfFinish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfFinish.Location = new System.Drawing.Point(165, 247);
            this.dtpDateOfFinish.Name = "dtpDateOfFinish";
            this.dtpDateOfFinish.Size = new System.Drawing.Size(125, 27);
            this.dtpDateOfFinish.TabIndex = 32;
            // 
            // dtpDateOfStart
            // 
            this.dtpDateOfStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfStart.Location = new System.Drawing.Point(165, 201);
            this.dtpDateOfStart.Name = "dtpDateOfStart";
            this.dtpDateOfStart.Size = new System.Drawing.Size(125, 27);
            this.dtpDateOfStart.TabIndex = 23;
            // 
            // txtMaxDaysToComplete
            // 
            this.txtMaxDaysToComplete.Location = new System.Drawing.Point(165, 297);
            this.txtMaxDaysToComplete.Name = "txtMaxDaysToComplete";
            this.txtMaxDaysToComplete.Size = new System.Drawing.Size(125, 27);
            this.txtMaxDaysToComplete.TabIndex = 31;
            // 
            // txtPercentComplete
            // 
            this.txtPercentComplete.Location = new System.Drawing.Point(165, 158);
            this.txtPercentComplete.Name = "txtPercentComplete";
            this.txtPercentComplete.Size = new System.Drawing.Size(125, 27);
            this.txtPercentComplete.TabIndex = 30;
            // 
            // txtOrderSprint
            // 
            this.txtOrderSprint.Location = new System.Drawing.Point(165, 113);
            this.txtOrderSprint.Name = "txtOrderSprint";
            this.txtOrderSprint.Size = new System.Drawing.Size(125, 27);
            this.txtOrderSprint.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Project";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Max to Complete";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ending Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "% Complete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Order";
            // 
            // txtIdSprint
            // 
            this.txtIdSprint.Enabled = false;
            this.txtIdSprint.Location = new System.Drawing.Point(165, 30);
            this.txtIdSprint.Name = "txtIdSprint";
            this.txtIdSprint.ReadOnly = true;
            this.txtIdSprint.Size = new System.Drawing.Size(125, 27);
            this.txtIdSprint.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // txtDescriptionSprint
            // 
            this.txtDescriptionSprint.Location = new System.Drawing.Point(122, 68);
            this.txtDescriptionSprint.Multiline = true;
            this.txtDescriptionSprint.Name = "txtDescriptionSprint";
            this.txtDescriptionSprint.Size = new System.Drawing.Size(212, 29);
            this.txtDescriptionSprint.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(240, 421);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 110;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 200;
            // 
            // percentComplete
            // 
            this.percentComplete.DataPropertyName = "PercentComplete";
            this.percentComplete.HeaderText = "% Complete";
            this.percentComplete.MinimumWidth = 6;
            this.percentComplete.Name = "percentComplete";
            this.percentComplete.ReadOnly = true;
            this.percentComplete.Width = 80;
            // 
            // startingDate
            // 
            this.startingDate.DataPropertyName = "DateInit";
            this.startingDate.HeaderText = "Starting Date";
            this.startingDate.MinimumWidth = 6;
            this.startingDate.Name = "startingDate";
            this.startingDate.ReadOnly = true;
            this.startingDate.Width = 115;
            // 
            // maxDaysToComplete
            // 
            this.maxDaysToComplete.DataPropertyName = "MaxDaysToComplete";
            this.maxDaysToComplete.HeaderText = "Max Days Duration";
            this.maxDaysToComplete.MinimumWidth = 6;
            this.maxDaysToComplete.Name = "maxDaysToComplete";
            this.maxDaysToComplete.ReadOnly = true;
            this.maxDaysToComplete.Width = 125;
            // 
            // endingDate
            // 
            this.endingDate.DataPropertyName = "DateFinish";
            this.endingDate.HeaderText = "Ending Date";
            this.endingDate.MinimumWidth = 6;
            this.endingDate.Name = "endingDate";
            this.endingDate.ReadOnly = true;
            this.endingDate.Width = 115;
            // 
            // SprintView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 533);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvSprint);
            this.Controls.Add(this.btnRefreshDepartament);
            this.Controls.Add(this.groupBox1);
            this.Name = "SprintView";
            this.Text = "SprintView";
            this.Load += new System.EventHandler(this.SprintView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSprint)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDelete;
        private Button btnLoad;
        private DataGridView dgvSprint;
        private Button btnRefreshDepartament;
        private GroupBox groupBox1;
        private TextBox txtIdSprint;
        private Label label1;
        private TextBox txtDescriptionSprint;
        private Label label2;
        private Button btnSave;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtMaxDaysToComplete;
        private TextBox txtPercentComplete;
        private TextBox txtOrderSprint;
        private DateTimePicker dtpDateOfFinish;
        private DateTimePicker dtpDateOfStart;
        private ComboBox cboProjects;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn percentComplete;
        private DataGridViewTextBoxColumn startingDate;
        private DataGridViewTextBoxColumn maxDaysToComplete;
        private DataGridViewTextBoxColumn endingDate;
    }
}