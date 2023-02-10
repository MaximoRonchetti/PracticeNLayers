namespace UI
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.departamentToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(540, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.addToolStripMenuItem.Text = "Employee";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // departamentToolStripMenuItem
            // 
            this.departamentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departamentsToolStripMenuItem});
            this.departamentToolStripMenuItem.Name = "departamentToolStripMenuItem";
            this.departamentToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.departamentToolStripMenuItem.Text = "Departament";
            // 
            // departamentsToolStripMenuItem
            // 
            this.departamentsToolStripMenuItem.Name = "departamentsToolStripMenuItem";
            this.departamentsToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.departamentsToolStripMenuItem.Text = "Departament";
            this.departamentsToolStripMenuItem.Click += new System.EventHandler(this.departamentsToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem1,
            this.sprintToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // projectToolStripMenuItem1
            // 
            this.projectToolStripMenuItem1.Name = "projectToolStripMenuItem1";
            this.projectToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.projectToolStripMenuItem1.Text = "Project";
            this.projectToolStripMenuItem1.Click += new System.EventHandler(this.projectToolStripMenuItem1_Click);
            // 
            // sprintToolStripMenuItem
            // 
            this.sprintToolStripMenuItem.Name = "sprintToolStripMenuItem";
            this.sprintToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sprintToolStripMenuItem.Text = "Sprint";
            this.sprintToolStripMenuItem.Click += new System.EventHandler(this.sprintToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 368);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem departamentToolStripMenuItem;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStripMenuItem departamentsToolStripMenuItem;
        private ToolStripMenuItem projectToolStripMenuItem1;
        private ToolStripMenuItem sprintToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
    }
}