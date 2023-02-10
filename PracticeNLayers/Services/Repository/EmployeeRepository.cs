using Microsoft.EntityFrameworkCore;
using Models.Data;
using Models.DTO;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(PracticeNLayersContext context) : base(context)
        {

        }

        public IEnumerable<Employee> GetAll(EmployeeSearchDTO employeeSearchDTO)
        {
            return _context.Employees.Include(x => x.Departament).Where(x => (employeeSearchDTO.Name == null || employeeSearchDTO.Name == "" || x.Name.Contains(employeeSearchDTO.Name)) &&
                                            (employeeSearchDTO.LastName == null || employeeSearchDTO.LastName == "" || x.LastName.Contains(employeeSearchDTO.LastName)) &&
                                             (employeeSearchDTO.IdNumber == null || employeeSearchDTO.IdNumber == "" || x.IdNumber.Contains(employeeSearchDTO.IdNumber)) &&
                                             (employeeSearchDTO.DepartamentId == null || employeeSearchDTO.DepartamentId == -1 || x.DepartamentId == employeeSearchDTO.DepartamentId ));
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.Include(x => x.EmployeeProjects).FirstOrDefault(x => x.Id == id);
        }

    }
}
