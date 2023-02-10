using Microsoft.EntityFrameworkCore.Storage;
using Models.Data;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PracticeNLayersContext _context;
        public IEmployeeRepository EmployeeRepository { get; }

        public IDepartamentRepository DepartamentRepository { get; }

        public IProjectRepository ProjectRepository { get; }

        public IEmployeeProjectRepository EmployeeProjectRepository { get; }

        public ISprintRepository SprintRepository { get; }

        public UnitOfWork(PracticeNLayersContext context, IEmployeeRepository employeeRepository, IDepartamentRepository departamentRepository, 
            IProjectRepository projectRepository, IEmployeeProjectRepository employeeProjectRepository, ISprintRepository sprintRepository)
        {
            _context = context;
            EmployeeRepository = employeeRepository;
            DepartamentRepository = departamentRepository;
            ProjectRepository = projectRepository;
            EmployeeProjectRepository = employeeProjectRepository;
            SprintRepository = sprintRepository;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
        public void CommitTransaction(IDbContextTransaction transaction)
        {
            transaction.Commit();
        }
        public IDbContextTransaction GetTransaction()
        {
            return _context.Database.BeginTransaction();
        }
        public void RollbackTransaction(IDbContextTransaction transaction)
        {
            transaction?.Rollback();
        }
    }
}
