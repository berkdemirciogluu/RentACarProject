using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car() { Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2015, DailyPrice = 188.000, Description = "Audi A3"},
                new Car() { Id = 2, BrandId = 1, ColorId = 3, ModelYear = 2005, DailyPrice = 140.000, Description = "Audi A3"},
                new Car() { Id = 3, BrandId = 2, ColorId = 2, ModelYear = 2018, DailyPrice = 250.000, Description = "Audi A3"},
                new Car() { Id = 4, BrandId = 2, ColorId = 5, ModelYear = 2013, DailyPrice = 170.000, Description = "Audi A3"},
                new Car() { Id = 5, BrandId = 2, ColorId = 4, ModelYear = 2014, DailyPrice = 160.000, Description = "Audi A3"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(int id)
        {
            Car carToDelete = _cars.Where(c => c.Id == id).SingleOrDefault();
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.Where(c => c.Id == id).SingleOrDefault();
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarsDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarsByBrandId()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarsByColorId()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.Where(c => c.Id == car.Id).SingleOrDefault();
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
