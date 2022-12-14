using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business
{
    public interface IBaseService<T>
    {
        IDataResult<List<T>> GetAll();

        IDataResult<T> GetById(int id);

        IResult Delete(int id);

        IResult Update(T entity);

        IResult Add(T entity);
    }
}
