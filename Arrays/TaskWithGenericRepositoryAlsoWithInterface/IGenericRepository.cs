using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskWithGenericRepositoryAlsoWithInterface
{
    public interface IGenericRepository<T> where T: class
    {
        void Add(T data);
        List<T> GetAll();
        void Delete(T data);
        List<T> Update(T data);
        
    }
}
