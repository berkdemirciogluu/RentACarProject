using Business.Abstract;
using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return _brandDal.GetAll();
        }

        public IDataResult<Brand> GetById(int id)
        {
            return _brandDal.Get(b => b.Id == id);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
        }
    }
}
