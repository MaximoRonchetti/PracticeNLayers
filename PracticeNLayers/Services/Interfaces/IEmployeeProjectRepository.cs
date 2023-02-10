using Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IEmployeeProjectRepository : IRepository<EmployeeProject>
    {
        void RemoveProjectsByEmployee(List<EmployeeProject> listToRemove);
    }
}
