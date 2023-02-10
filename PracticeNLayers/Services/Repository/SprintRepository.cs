using Models.Data;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class SprintRepository : RepositoryBase<Sprint>, ISprintRepository
    {
        public SprintRepository(PracticeNLayersContext context) : base(context)
        {

        }

        public Sprint GetSprintById(int id)
        {
            return this._context.Sprints.FirstOrDefault(x => x.Id == id);
        }
    }
}
