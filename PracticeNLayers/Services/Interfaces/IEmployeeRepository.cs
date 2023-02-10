using Models.Data;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Employee GetEmployeeById(int id);

        IEnumerable<Employee> GetAll(EmployeeSearchDTO employeeSearchDTO);
    }
}
