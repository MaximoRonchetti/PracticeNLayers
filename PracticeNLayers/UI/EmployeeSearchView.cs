using Models.Data;
using Models.DTO;
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
    public partial class EmployeeSearchView : Form, ISearchForm
    {
        IUnitOfWork _unitOfWork;
        public EmployeeSearchView(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }
        private void EmployeeSearchView_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        public void Initialize()
        {
            FillCboDepartaments();
            BindDataGrid();
            dgvEmployeeSearch.AutoGenerateColumns = false;
        }
        private void FillCboDepartaments()
        {
            var departamentNull = new Departament
            {
                Id = -1,
                Description = "[Sin seleccionar]"
            };
            var departaments = _unitOfWork.DepartamentRepository.GetAll().ToList();
            departaments.Add(departamentNull);
            cboDepartaments.DataSource = departaments;
            cboDepartaments.ValueMember = nameof(Departament.Id);
            cboDepartaments.DisplayMember = nameof(Departament.Description);
            cboDepartaments.SelectedValue = -1;
        }
        //public void BindDataFilters()
        //{
        //    txtName.DataBindings.Add(nameof(TextBox.Text), bndEmployeeSearchDTO, nameof(EmployeeSearchDTO.Name), true, DataSourceUpdateMode.OnPropertyChanged);
        //    txtLastName.DataBindings.Add(nameof(TextBox.Text), bndEmployeeSearchDTO, nameof(EmployeeSearchDTO.LastName));
        //    txtIdNumber.DataBindings.Add(nameof(TextBox.Text), bndEmployeeSearchDTO, nameof(EmployeeSearchDTO.IdNumber));
        //    cboDepartaments.DataBindings.Add(nameof(ComboBox.SelectedValue), bndEmployeeSearchDTO, nameof(EmployeeSearchDTO.DepartamentId));
        //}

        public void CleanControls(bool reloadDataGrid = true)
        {
            txtName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtIdNumber.Text = String.Empty;
            cboDepartaments.SelectedValue = -1;
            bndEmployeeList.DataSource = null;
            BindDataGrid();
        }



        public void Search()
        {
            FillBindingSource();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Search();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            } 
        }

        public void BindDataGrid()
        {
            dgvEmployeeSearch.DataSource = bndEmployeeList.DataSource;
        }

        public void FillBindingSource()
        {
            EmployeeSearchDTO employeeSearchDTO = new EmployeeSearchDTO
            {
                Name = txtName.Text,
                LastName = txtLastName.Text,
                IdNumber = txtIdNumber.Text,
                DepartamentId = Convert.ToInt32(cboDepartaments.SelectedValue)
            };

            var results = _unitOfWork.EmployeeRepository.GetAll(employeeSearchDTO).ToList();
            bndEmployeeList.DataSource = results;
            BindDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CleanControls();
        }
    }
}
