using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;

namespace Core.DataAccess
{
    public class BaseManager<T> : IBaseService<T> 
    {
        IEntityRepository<T> _entityDal;

        public BaseManager(IEntityRepository<T> entityDal)
        {
            _entityDal = entityDal;


        }

        public virtual IResult Add(T entity)
        {
            _entityDal.Add(entity);
            return new SuccessResult();
        }

        public virtual IResult Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual IDataResult<List<T>> GetAll()
        {
            _entityDal.GetAll();
        }

        public virtual IDataResult<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public virtual IResult Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
