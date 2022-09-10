using Business.Abstract;
using Business.Utilities.Constants;
using Core.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CarManager : BaseManager<Car>, ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal) : base(carDal)
        {
            _carDal = carDal;
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarsDetails(),Messages.SuccesfullProcess);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            if (brandId == 0)
                return new ErrorDataResult<List<Car>>(Messages.InvalidDataEntrance);
            return new SuccessDataResult<List<Car>>(_carDal.GetCarsByBrandId(brandId), Messages.SuccesfullProcess);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            if (colorId == 0)
                return new ErrorDataResult<List<Car>>(Messages.InvalidDataEntrance);
            return new SuccessDataResult<List<Car>>(_carDal.GetCarsByColorId(colorId), Messages.SuccesfullProcess);
        }

    }
}
