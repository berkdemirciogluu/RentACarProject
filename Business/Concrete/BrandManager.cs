using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Core.Business;
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
    public class BrandManager : BaseManager<Brand>, IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal) : base(brandDal)
        {
            _brandDal = brandDal;
        }

        [SecuredOperation("brand.add,admin")]
        public override IResult Add(Brand entity)
        {
            return base.Add(entity);
        }
    }
}
