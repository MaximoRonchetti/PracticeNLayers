using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Interfaces
{
    public interface ISearchForm : IFormBase
    {
        void Search();
        void BindDataGrid();
    }
}
