using Services.Interfaces;
using Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Menu : Form
    {
        public IUnitOfWork _unitOfWork;
        public Menu(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeView employeeView = new EmployeeView(_unitOfWork);
            this.Hide();
            employeeView.ShowDialog();
            this.Show();
        }

        private void departamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartamentView departamentView = new DepartamentView(_unitOfWork);
            this.Hide();
            departamentView.ShowDialog();
            this.Show();
        }

        private void projectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProjectView projectView = new ProjectView(_unitOfWork);
            this.Hide();
            projectView.ShowDialog();
            this.Show();
        }

        private void sprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SprintView sprintView = new SprintView(_unitOfWork);
            this.Hide();
            sprintView.ShowDialog();
            this.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSearchView employeeSearchView = new EmployeeSearchView(_unitOfWork);
            this.Hide();
            employeeSearchView.ShowDialog();
            this.Show();
        }
    }
}
