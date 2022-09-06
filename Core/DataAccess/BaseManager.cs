using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public class BaseManager : IBaseService<T>
    {

        public IResult Add(T entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
