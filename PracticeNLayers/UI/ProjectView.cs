using Models.Data;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Interfaces;

namespace UI
{
    public partial class ProjectView : Form, IFormBase
    {
        IUnitOfWork _unitOfWork;
        Project _currentProject;

        int CurrentProjectId
        { get
          {
            if (dgvProjects.SelectedRows.Count > 0)
            {
              DataGridViewRow row = dgvProjects.SelectedRows[0];
                    return Convert.ToInt32(row.Cells["colId"].Value); 
            }
            return 0;
          }
        }
        public ProjectView(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork; 
        }
        public void Initialize()
        {
            dgvProjects.AutoGenerateColumns = false;
            ReloadDataGridView();
        }
        private void ProjectView_Load(object sender, EventArgs e)
        {
            Initialize();
        }




        private void SaveNewProject()
        {
            Project project;

            if (String.IsNullOrEmpty(txtIdProject.Text))
            {
                 project = new Project();
            }
            else
            {
                project = _currentProject;
            }
            project.Descrption = txtDescriptionProject.Text;
            project.Title = txtTitleProject.Text;
            try
            {
                project.DurationDays = Convert.ToInt32(txtDurationDays.Text);
                project.Budget = Convert.ToDecimal(txtBudgetProject.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error {ex}, the fields must contain a number");
            }
            project.IsActive = chkIsActive.Checked;
            project.IsFinished = chkIsFinished.Checked;

            if (String.IsNullOrEmpty(txtIdProject.Text))
            {
                _unitOfWork.ProjectRepository.Add(project);
            }
            else
            {
                _unitOfWork.ProjectRepository.Update(project);
            }
        }
        private void btnSaveProject_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    SaveNewProject();
                    CleanControls();
                } 
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error {ex}");
            }
        }

        void GetAndLoadProject()
        {
            try
            {
                if (CurrentProjectId != 0)
                {
                    var currentProject = _unitOfWork.ProjectRepository.GetProjectById(CurrentProjectId);
                    if (currentProject != null)
                    {
                        txtIdProject.Text = currentProject.Id.ToString();
                        txtDescriptionProject.Text = currentProject.Descrption;
                        txtTitleProject.Text = currentProject.Title;
                        txtDurationDays.Text = currentProject.DurationDays.ToString();
                        txtBudgetProject.Text = currentProject.Budget.ToString();
                        chkIsActive.Checked = currentProject.IsActive;
                        chkIsFinished.Checked = currentProject.IsFinished;

                        _currentProject = currentProject;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GetAndLoadProject();
            CleanControls(false);
        }

        void DeleteProject()
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (CurrentProjectId != 0)
                    {
                        var currentProject = _unitOfWork.ProjectRepository.GetProjectById(CurrentProjectId);
                        if (currentProject.EmployeeProjects.Any())
                        {
                            MessageBox.Show("This project cannot be deleted because it is related to an employee", "Error");
                        }
                        else if (currentProject.Sprints.Any())
                        {
                            MessageBox.Show("This project cannot be deleted because it has a relationship with an sprint or more.", "Error");
                        }
                        else
                        {
                            _unitOfWork.ProjectRepository.Delete(currentProject);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteProject();
            CleanControls();
        }







        public void CleanControls(bool reloadDataGrid = true)
        {
            txtDescriptionProject.Text = String.Empty;
            txtTitleProject.Text = String.Empty;
            txtDurationDays.Text = String.Empty;
            txtBudgetProject.Text = String.Empty;
            txtIdProject.Text = String.Empty;
            chkIsActive.Checked = false;
            chkIsFinished.Checked = false;
            if (reloadDataGrid)
            {
                ReloadDataGridView();
            }
            _currentProject = null;
        }
        private void btnRefreshProjects_Click(object sender, EventArgs e)
        {
            CleanControls();
        }

        public void ReloadDataGridView()
        {
            dgvProjects.DataSource = null;
            dgvProjects.DataSource = _unitOfWork.ProjectRepository.GetAll().ToList();
        }

        private bool IsValid()
        {
            if (string.IsNullOrEmpty(txtDescriptionProject.Text) || string.IsNullOrEmpty(txtTitleProject.Text))
            {
                MessageBox.Show("All fields are mandatory");
                return false;
            }
            return true;
        }

    }
}
