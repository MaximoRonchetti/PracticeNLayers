using Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ISprintRepository : IRepository<Sprint>
    {
        Sprint GetSprintById(int id);
    }
}
