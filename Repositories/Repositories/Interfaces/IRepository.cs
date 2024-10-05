using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        public void Create(T entity);
        public void Update(T entity);
        public void Delete(int id);        
        public List<T> GetAll();
               

    }
}

