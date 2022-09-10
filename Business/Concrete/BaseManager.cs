using Business.Constants;
using Core.DataAccess.EntityFramework;
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
            if (entity == null)
                return new ErrorResult(Messages.InvalidDataEntrance);
            _entityDal.Add(entity);
            return new SuccessResult(Messages.SuccesfullProcess);
        }

        public virtual IResult Delete(int id)
        {
            var entity = GetById(id);
            if (entity == null)
                return new ErrorResult(Messages.EntityNotFound);
            _entityDal.Delete(id);
            return new SuccessResult(Messages.SuccesfullProcess);
        }

        public virtual IDataResult<List<T>> GetAll()
        {
            return new SuccessDataResult<List<T>>(_entityDal.GetAll(),Messages.SuccesfullProcess);
        }

        public virtual IDataResult<T> GetById(int id)
        {
            if (id == null)
                return new ErrorDataResult<T>(Messages.InvalidDataEntrance);
            return new SuccessDataResult<T>(_entityDal.GetById(id),Messages.SuccesfullProcess);                
        }

        public virtual IResult Update(T entity)
        {
            if (entity == null)
                return new ErrorResult(Messages.InvalidDataEntrance);
            _entityDal.Update(entity);
            return new SuccessResult(Messages.SuccesfullProcess);
        }
    }
}
