using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Data
{
    public partial class Employee : IModels
    {
        public string GetDepartamentDescription 
        { 
            get
            {
                if (this.Departament == null)
                {
                    return "";
                }
                return this.Departament.Description;
            } 
        }
    }
}
