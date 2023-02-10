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
    public partial class DepartamentView : Form, IFormBase
    {
        IUnitOfWork _unitOfWork;
        Departament _currentDepartament;

        int CurrentDepartamentId
        {
            get
            {
                if( dgvDepartaments.Rows.Count > 0)
                {
                    DataGridViewRow row = dgvDepartaments.Rows[0];
                    return Convert.ToInt32(row.Cells["Id"].Value);
                }
                return -1;
            }
        }
        public DepartamentView(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }
        public void Initialize()
        {
            dgvDepartaments.AutoGenerateColumns = false;
            ReloadDataGridView();
        }
        private void DepartamentView_Load(object sender, EventArgs e)
        {
            Initialize();
        }




        private void SaveDepartament()
        {
            Departament departament;
            if (txtIdDepartament.Text == String.Empty)
            {
                 departament = new Departament();
            }
            else
            {
                departament = _currentDepartament;
            }        
            departament.Description = txtDescriptionDepartament.Text;
            departament.IsActive = chkIsActiveDepartament.Checked;
            if (txtIdDepartament.Text == String.Empty)
            {
                _unitOfWork.DepartamentRepository.Add(departament);
            }
            else
            {
                _unitOfWork.DepartamentRepository.Update(departament);  
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    SaveDepartament();
                    CleanControls();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error {ex}");
            }
        }

        void GetAndLoadDepartament()
        {
            try
            {
                if (CurrentDepartamentId != 0)
                {
                    var currentDepartament = _unitOfWork.DepartamentRepository.GetDepartamentById(CurrentDepartamentId);
                    if (currentDepartament != null)
                    {
                        txtIdDepartament.Text = currentDepartament.Id.ToString();
                        txtDescriptionDepartament.Text = currentDepartament.Description;
                        chkIsActiveDepartament.Checked = currentDepartament.IsActive;

                        _currentDepartament = currentDepartament;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error {ex.Message}");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GetAndLoadDepartament();
        }

        void DeleteDepartament()
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (CurrentDepartamentId != 0)
                    {
                        Departament currentDepartament = _unitOfWork.DepartamentRepository.GetDepartamentById(CurrentDepartamentId);
                        if (currentDepartament.Employees.Any())
                        {
                            MessageBox.Show("This departament cannot be deleted because it is related to an employee", "Error");
                        }
                        else
                        {
                            _unitOfWork.DepartamentRepository.Delete(currentDepartament);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}", "Error");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteDepartament();
            CleanControls();
        }




        public void CleanControls(bool reloadDataGrid = true)
        {
            txtDescriptionDepartament.Text = String.Empty;
            chkIsActiveDepartament.Checked = false;
            if (reloadDataGrid)
            {
                ReloadDataGridView();
            }
        }
        private void btnRefreshDepartament_Click(object sender, EventArgs e)
        {
            CleanControls();
        }

        public void ReloadDataGridView()
        {
            dgvDepartaments.DataSource = null;
            dgvDepartaments.DataSource = _unitOfWork.DepartamentRepository.GetAll().ToList();
        }

        private bool IsValid()
        {
            if (string.IsNullOrEmpty(txtDescriptionDepartament.Text))
            {
                MessageBox.Show("All fields are mandatory");
                return false;
            }
            return true;
        }

 
    }
}
