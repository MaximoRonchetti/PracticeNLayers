using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository EmployeeRepository { get; }
        IDepartamentRepository DepartamentRepository { get; }
        IProjectRepository ProjectRepository { get; }
        IEmployeeProjectRepository EmployeeProjectRepository { get; }
        ISprintRepository SprintRepository { get; }
        int Commit();
        public IDbContextTransaction GetTransaction();
        public void CommitTransaction(IDbContextTransaction transaction);
        public void RollbackTransaction(IDbContextTransaction transaction);
    }
}
