using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskWithGenericRepositoryAlsoWithInterface
{
    public class GenericRepository<T>: IGenericRepository<T> where T:class
    {
       

        public void Add(T data)
        {
            throw new NotImplementedException();
        }

        public void Delete(T data)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<T> Update(T data)
        {
            throw new NotImplementedException();
        }
    }
}
