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
    internal class DepartmentRepository:GenaricRepository<Department>,IDepartmentRepository
    {
        public DepartmentRepository(CompanyDBContext companyDBContext):base(companyDBContext)
        {
            
        }
    }
}
