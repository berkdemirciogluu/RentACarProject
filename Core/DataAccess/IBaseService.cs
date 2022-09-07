using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IBaseService<T> 
    {
        IDataResult<List<T>> GetAll();

        IDataResult<T> GetById(int id);

        IResult Delete(T entity);

        IResult Update(T entity);

        IResult Add(T entity);
    }
}
