using Models.Data;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class DepartamentRepository : RepositoryBase<Departament>, IDepartamentRepository
    {
        public DepartamentRepository(PracticeNLayersContext context) : base(context)
        {

        }

        public Departament GetDepartamentById(int id)
        {
            return this._context.Departaments.FirstOrDefault(x => x.Id == id);
        }
    }
}
