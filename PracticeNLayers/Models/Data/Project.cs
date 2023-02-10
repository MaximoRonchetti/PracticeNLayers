using System;
using System.Collections.Generic;

namespace Models.Data
{
    public partial class Project
    {
        public Project()
        {
            EmployeeProjects = new HashSet<EmployeeProject>();
            Sprints = new HashSet<Sprint>();
        }

        public int Id { get; set; }
        public string Descrption { get; set; } = null!;
        public string Title { get; set; } = null!;
        public int? DurationDays { get; set; }
        public decimal? Budget { get; set; }
        public bool IsActive { get; set; }
        public bool IsFinished { get; set; }

        public virtual ICollection<EmployeeProject> EmployeeProjects { get; set; }
        public virtual ICollection<Sprint> Sprints { get; set; }
    }
}
