using System;
using System.Collections.Generic;

namespace Models.Data
{
    public partial class EmployeeProject
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual Project Project { get; set; } = null!;
    }
}
