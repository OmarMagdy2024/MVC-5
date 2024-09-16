using Company_BLL.Interfaces;
using Company_DAL.Connection;
using Company_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_BLL.Repositories
{
    public class EmployeeRepository : GenaricRepository<Employee>, IEmployeeRepository
    {
        //private readonly CompanyDBContext _companydbcontext;
        public EmployeeRepository(CompanyDBContext companyDBContext):base(companyDBContext)
        {
            //_companydbcontext = companyDBContext;
        }

        public IQueryable<Employee> GetbyName(string name)
        {
            return _companydbcontext.Employees.Where(e=>e.Name.ToLower().Contains(name.ToLower())).Include(e=>e.Department).AsNoTracking();
        }
    }
}
