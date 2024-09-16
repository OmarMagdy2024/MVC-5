using Company_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_BLL.Interfaces
{
    public interface IGenaticRepository<T> where T : ModelBase
    {
        public IEnumerable<T> GetAll();
        public T GetById(int id);
        public int Add(T t);
        public int Update(T t);
        public int Delete(T t);
    }
}
