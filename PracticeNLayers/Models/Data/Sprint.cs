using System;
using System.Collections.Generic;

namespace Models.Data
{
    public partial class Sprint
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public int Order { get; set; }
        public decimal? PercentComplete { get; set; }
        public DateTime? DateInit { get; set; }
        public DateTime? DateFinish { get; set; }
        public int? MaxDaysToComplete { get; set; }
        public int ProjectId { get; set; }

        public virtual Project Project { get; set; } = null!;
    }
}
