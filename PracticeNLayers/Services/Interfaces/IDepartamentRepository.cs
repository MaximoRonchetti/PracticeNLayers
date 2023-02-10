using Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IDepartamentRepository : IRepository<Departament>
    {
        Departament GetDepartamentById(int id);
    }
}
