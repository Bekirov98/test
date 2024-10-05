using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IService<T> where T : BaseEntity
    {
        public List<T> Create(T entity);
        public List<T> Update(T entity);
        public List<T> Delete(int id);
        public List<T> GetAll();
       
        
    }
}
