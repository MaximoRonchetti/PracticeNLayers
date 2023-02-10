using Models.Data;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class EmployeeProjectRepository : RepositoryBase<EmployeeProject>, IEmployeeProjectRepository
    {
        public EmployeeProjectRepository(PracticeNLayersContext context) : base(context)
        {

        }

        public void RemoveProjectsByEmployee(List<EmployeeProject> listToRemove)
        {
            _context.EmployeeProjects.RemoveRange(listToRemove);
            _context.SaveChanges();
        }
    }
}
