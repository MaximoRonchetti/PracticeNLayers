using System;
using System.Collections.Generic;

namespace Models.Data
{
    public partial class Departament
    {
        public Departament()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public bool IsActive { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
