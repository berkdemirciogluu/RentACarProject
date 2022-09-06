using Business.Abstract;
using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            _carDal.Add(car);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public IDataResult<List<Car>> GetAll()
        {
           return _carDal.GetAll();
        }

        public IDataResult<Car> GetById(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId).ToList();
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId).ToList();
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
