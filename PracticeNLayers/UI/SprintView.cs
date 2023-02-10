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
    public partial class SprintView : Form, IFormBase
    {
        IUnitOfWork _unitOfWork;
        Sprint _currentSprint;

        int GetCurrentSprintId
        {
            get
            {
                if (dgvSprint.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvSprint.SelectedRows[0];
                    return Convert.ToInt32(row.Cells["Id"].Value);
                }
                return 0;
            }
        }
        public SprintView(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }
        private void SprintView_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        public void Initialize()
        {
            FillCboProjects();
            dgvSprint.AutoGenerateColumns = false;
            ReloadDataGridView();
        }




        public void SaveSprint()
        {
            Sprint sprint;

            if (txtIdSprint.Text == String.Empty)
            {
                sprint = new Sprint();
            }
            else
            {
                sprint = _currentSprint;
            }

            sprint.Description = txtDescriptionSprint.Text;
            sprint.Order = Convert.ToInt32(txtOrderSprint.Text);
            sprint.PercentComplete = Convert.ToDecimal(txtPercentComplete.Text);
            sprint.DateInit = dtpDateOfStart.Value;
            sprint.DateFinish = dtpDateOfFinish.Value;
            sprint.MaxDaysToComplete = Convert.ToInt32(txtMaxDaysToComplete.Text);
            sprint.ProjectId = Convert.ToInt32(cboProjects.SelectedValue);

            if (txtIdSprint.Text == String.Empty)
            {
                _unitOfWork.SprintRepository.Add(sprint);
            }
            else
            {
                _unitOfWork.SprintRepository.Update(sprint);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveSprint();
                CleanControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Save Error {ex}", "Error");
            }
        }

        void SelectAndLoadSprint()
        {
            try
            {
                if (GetCurrentSprintId != 0)
                {
                    Sprint currentSprint = _unitOfWork.SprintRepository.GetSprintById(GetCurrentSprintId);
                    if (currentSprint != null)
                    {
                        txtIdSprint.Text = currentSprint.Id.ToString();
                        txtOrderSprint.Text = currentSprint.Order.ToString();
                        txtDescriptionSprint.Text = currentSprint.Description;
                        txtMaxDaysToComplete.Text = currentSprint.MaxDaysToComplete.ToString();
                        txtPercentComplete.Text = currentSprint.PercentComplete.ToString();
                        cboProjects.SelectedValue = currentSprint.ProjectId;
                        dtpDateOfStart.Value = currentSprint.DateInit.Value;
                        dtpDateOfFinish.Value = currentSprint.DateFinish.Value;

                        _currentSprint = currentSprint;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error {ex}");
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                CleanControls(false);
                SelectAndLoadSprint();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Select Error {ex}", "Error");
            }
        }

        void DeleteSprint()
        {
            try
            {
                if (GetCurrentSprintId == 0)
                {
                    MessageBox.Show("You must select a sprint");
                }
                _currentSprint = _unitOfWork.SprintRepository.GetSprintById(GetCurrentSprintId);
                if (_currentSprint != null)
                {
                    if (MessageBox.Show("Are you about to delete a sprint, are you sure?", "Delete Sprint", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        _unitOfWork.SprintRepository.Delete(_currentSprint);
                        MessageBox.Show("Sprint removed successfully");
                    }
                    else
                    {
                        MessageBox.Show("Operation cancelled");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteSprint();
                CleanControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Delete Error {ex}", "Error");
            }
        }





        public void CleanControls(bool reloadDataGrid = true)
        {
            txtIdSprint.Text = String.Empty;
            txtDescriptionSprint.Text = String.Empty;   
            txtOrderSprint.Text = String.Empty;
            txtPercentComplete.Text = String.Empty;
            txtMaxDaysToComplete.Text = String.Empty;
            dtpDateOfStart.Value = DateTime.Now;
            dtpDateOfFinish.Value = DateTime.Now;
            cboProjects.SelectedValue = "-1";
            if (reloadDataGrid)
            {
                ReloadDataGridView();
            }
            _currentSprint = null;
        }
        private void btnRefreshDepartament_Click(object sender, EventArgs e)
        {
            CleanControls();
        }
        void FillCboProjects()
        {
            var projects = _unitOfWork.ProjectRepository.GetAll();
            cboProjects.DataSource = projects;
            cboProjects.ValueMember = nameof(Project.Id);
            cboProjects.DisplayMember = nameof(Project.Title);
        }
        void ReloadDataGridView()
        {
            dgvSprint.DataSource = null;
            dgvSprint.DataSource = _unitOfWork.SprintRepository.GetAll().ToList();
        }

    }
}
