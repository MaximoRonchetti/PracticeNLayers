using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class EmployeeSearchDTO
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? IdNumber { get; set; }
        public int? DepartamentId { get; set; }
    }
}
