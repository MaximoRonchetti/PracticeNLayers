using Microsoft.EntityFrameworkCore;
using Models.Data;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class ProjectRepository : RepositoryBase<Project>, IProjectRepository
    {
        public ProjectRepository(PracticeNLayersContext context) : base(context)
        {

        }

        public Project GetProjectById(int id)
        {
           return this._context.Projects.Include(x => x.EmployeeProjects).FirstOrDefault(x => x.Id == id);
        }
    }
}
