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
    internal class GenaricRepository<T>:IGenaricRepository<T> where T : class
    {
        private protected readonly CompanyDBContext _companydbcontext;
        public GenaricRepository(CompanyDBContext companyDBContext)
        {
            _companydbcontext = companyDBContext;
        }
        public int Add(T T)
        {
            _companydbcontext.Add(T);
            return _companydbcontext.SaveChanges();
        }

        public int Delete(T T)
        {
            _companydbcontext.Remove(T);
            return _companydbcontext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _companydbcontext.Set<T>().AsNoTracking().ToList();
        }

        public T GetById(int id)
        {
            return _companydbcontext.Set<T>().Find(id);
        }

        public int Update(T T)
        {
            _companydbcontext.Update(T);
            return _companydbcontext.SaveChanges();
        }
    }
}
