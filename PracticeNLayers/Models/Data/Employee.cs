using System;
using System.Collections.Generic;

namespace Models.Data
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeProjects = new HashSet<EmployeeProject>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string IdNumber { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public int DepartamentId { get; set; }

        public virtual Departament Departament { get; set; } = null!;
        public virtual ICollection<EmployeeProject> EmployeeProjects { get; set; }
    }
}
