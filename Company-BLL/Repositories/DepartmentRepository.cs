using Company_BLL.Interfaces;
using Company_DAL.Connection;
using Company_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_BLL.Repositories
{
    public class DepartmentRepository : GenaricRepository<Department>,IDepartmentRepository
    {
        //private readonly CompanyDBContext _companydbcontext;
        public DepartmentRepository(CompanyDBContext companyDBContext):base(companyDBContext)
        {
            //_companydbcontext = companyDBContext;
        }
        
    }
}
