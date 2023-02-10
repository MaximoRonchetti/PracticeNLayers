using Microsoft.EntityFrameworkCore;
using Models.Data;
using Services.Interfaces;
using System.Windows.Forms;
using UI.Interfaces;

namespace UI
{
    public partial class EmployeeView : Form, IFormBase
    {
        IUnitOfWork _unitOfWork;
        public Employee _currentEmployee;

        public int GetCurrentEmployeeId
        {
            get
            {
                if (dgvEmployees.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvEmployees.SelectedRows[0];
                    return Convert.ToInt32(row.Cells["Id"].Value);
                }
                return 0;
            }
        }
        public EmployeeView(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }
        public void Initialize()
        {
            FillCboDepartaments();
            dgvEmployees.AutoGenerateColumns = false;
            FillCheckedListProject();
            ReloadDataGridView();
        }
        private void FormOne_Load(object sender, EventArgs e)
        {
            Initialize();
        }




        public void SaveEmployee()
        {
            using (var transaction = _unitOfWork.GetTransaction())
            {
                try
                {
                    Employee employee;
                    if (String.IsNullOrEmpty(txtIdEmployee.Text))
                    {
                        employee = new Employee();
                    }
                    else
                    {
                        employee = _currentEmployee;
                        _unitOfWork.EmployeeProjectRepository.RemoveProjectsByEmployee(employee.EmployeeProjects.ToList());
                    }

                    employee.Name = txtNameEmployee.Text;
                    employee.LastName = txtLastNameEmployee.Text;
                    employee.DateOfBirth = dtpDateOfBirthEmployee.Value;
                    employee.IdNumber = txtIDNumEmployee.Text;

                    foreach (var item in chkListProject.CheckedItems)
                    {
                        var row = item as Project;
                        employee.EmployeeProjects.Add(new EmployeeProject
                        {
                            ProjectId = row.Id
                        });
                    }
                    if (cboDepartaments.SelectedValue != null)
                    {
                        employee.DepartamentId = Convert.ToInt32(cboDepartaments.SelectedValue);
                    }
                    else
                    {
                        employee.DepartamentId = 0;
                    }

                    if (String.IsNullOrEmpty(txtIdEmployee.Text))
                    {
                        _unitOfWork.EmployeeRepository.Add(employee);
                    }
                    else
                    {
                        _unitOfWork.EmployeeRepository.Update(employee);
                    }

                    _unitOfWork.CommitTransaction(transaction);
                }
                catch (Exception ex)
                {
                    _unitOfWork.RollbackTransaction(transaction);
                    MessageBox.Show($"{ex}");
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    SaveEmployee();
                    CleanControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + (ex.Message));
            }

        }

        void GetAndLoadEmployee()
        {
            try
            {
                if (GetCurrentEmployeeId != 0)
                {
                    var currentEmployee = _unitOfWork.EmployeeRepository.GetEmployeeById(GetCurrentEmployeeId);
                    if (currentEmployee != null)
                    {
                        txtIdEmployee.Text = currentEmployee.Id.ToString();
                        txtNameEmployee.Text = currentEmployee.Name;
                        txtLastNameEmployee.Text = currentEmployee.LastName;
                        txtIDNumEmployee.Text = currentEmployee.IdNumber.ToString();
                        dtpDateOfBirthEmployee.Value = currentEmployee.DateOfBirth;
                        cboDepartaments.SelectedValue = currentEmployee.DepartamentId;
                        for (int i = 0; i < chkListProject.Items.Count; i++)
                        {
                            var project = (Project)chkListProject.Items[i];
                            if (currentEmployee.EmployeeProjects.Any(x => project.Id == x.ProjectId))
                            {
                                chkListProject.SetItemChecked(i, true);
                            }
                        }

                        _currentEmployee = currentEmployee;
                    }
                }
            }
            catch (Exception)
            {


            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CleanControls(false);
            GetAndLoadEmployee();
        }

        void DeleteEmployee()
        {
            try
            {
                if (GetCurrentEmployeeId == 0)
                {
                    MessageBox.Show("You must select an employee");
                    return;
                }
                var currentEmployee = _unitOfWork.EmployeeRepository.GetEmployeeById(GetCurrentEmployeeId);
                if (currentEmployee != null)
                {
                    if (currentEmployee.EmployeeProjects.Any())
                    {
                        if (MessageBox.Show("The employee has associated projects, do you want to continue?", "Delete Employee", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            MessageBox.Show("Operation cancelled");
                            return;
                        }
                    }
                    using (var transaction = _unitOfWork.GetTransaction())
                    {
                        try
                        {
                            if (MessageBox.Show("You are about to delete an employee, do you want to continue?", "Delete Employee", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                _unitOfWork.EmployeeProjectRepository.RemoveProjectsByEmployee(currentEmployee.EmployeeProjects.ToList());
                                _unitOfWork.EmployeeRepository.Delete(currentEmployee);
                                _unitOfWork.CommitTransaction(transaction);
                            }
                        }
                        catch (Exception)
                        {

                            transaction.Rollback();
                            throw;
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Operation Cancelled, Error {ex}");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteEmployee();
            CleanControls();
        }




        private void FillCboDepartaments()
        {
            var departaments = _unitOfWork.DepartamentRepository.GetAll();
            cboDepartaments.DataSource = departaments;
            cboDepartaments.ValueMember = nameof(Departament.Id);
            cboDepartaments.DisplayMember = nameof(Departament.Description);
        }

        public void FillCheckedListProject()
        {
            var listProject = _unitOfWork.ProjectRepository.GetAll();
            ((ListBox)chkListProject).DataSource = listProject;
            ((ListBox)chkListProject).DisplayMember = nameof(Project.Title);
        }

        private void ReloadDataGridView()
        {
            dgvEmployees.DataSource = null;
            dgvEmployees.DataSource = _unitOfWork.EmployeeRepository.GetAll().ToList();
        }

        public void CleanControls(bool reloadDataGrid = true)
        {
            txtNameEmployee.Text = string.Empty;
            txtLastNameEmployee.Text = string.Empty;
            txtIDNumEmployee.Text = string.Empty;
            dtpDateOfBirthEmployee.Value = DateTime.Now;
            if (reloadDataGrid)
            {
                ReloadDataGridView();
            }
            cboDepartaments.SelectedValue = "-1";
            for (int i = 0; i < chkListProject.Items.Count; i++)
            {
                chkListProject.SetItemChecked(i, false);
            }
            txtIdEmployee.Text = string.Empty;
            _currentEmployee = null;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CleanControls();
        }

        private bool IsValid()
        {
            if (string.IsNullOrEmpty(txtNameEmployee.Text) || string.IsNullOrEmpty(txtLastNameEmployee.Text)
                || string.IsNullOrEmpty(txtIDNumEmployee.Text))
            {
                MessageBox.Show("All fields are mandatory");
                return false;
            }
            return true;
        }


    }
}