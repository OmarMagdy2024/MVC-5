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
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly CompanyDBContext _companydbcontext;
        public EmployeeRepository(CompanyDBContext companyDBContext)
        {
            _companydbcontext = companyDBContext;
        }
        public int Add(Employee employee)
        {
            _companydbcontext.Employees.Add(employee);
            return _companydbcontext.SaveChanges();
        }

        public int Delete(Employee employee)
        {
            _companydbcontext.Employees.Remove(employee);
            return _companydbcontext.SaveChanges();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _companydbcontext.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return _companydbcontext.Employees.Where(E=>E.Id == id).FirstOrDefault();
        }

        public int Update(Employee employee)
        {
            _companydbcontext.Employees.Update(employee);
            return _companydbcontext.SaveChanges();
        }
    }
}
