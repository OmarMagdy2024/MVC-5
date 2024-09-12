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
    internal class EmployeeRepository:GenaricRepository<Employee>,IEmployeeRepository
    {
        public EmployeeRepository(CompanyDBContext companyDBContext):base(companyDBContext) 
        {
            
        }

        public IQueryable<Employee> GetByAddress(string address)
        {
           return _companydbcontext.Employees.Where(e=>e.Address.ToLower()==address.ToLower());
        }
    }
}
