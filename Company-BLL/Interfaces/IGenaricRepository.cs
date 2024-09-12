using Company_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_BLL.Interfaces
{
    public interface IGenaricRepository<T> where T : class
    {
        public IEnumerable<T> GetAll();
        public T GetById(int id);
        public int Add(T department);
        public int Update(T department);
        public int Delete(T department);
    }
}
