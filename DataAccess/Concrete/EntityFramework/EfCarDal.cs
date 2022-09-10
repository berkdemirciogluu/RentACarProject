using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, Context>, ICarDal
    {
        public List<CarDetailDto> GetCarsDetails()
        {
            using (Context context = new Context())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             select new CarDetailDto { CarName = c.Name, BrandName = b.Name, ColorName = co.Name, DailyPrice = c.DailyPrice };

                return result.ToList();
            }
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            using (Context context = new Context())
            {
                var result = from car in context.Cars
                             where car.BrandId == id
                             select car;

                return result.ToList();
            }
        }

        public List<Car> GetCarsByColorId(int id)
        {
            using (Context context = new Context())
            {
                var result = from car in context.Cars
                             where car.ColorId == id
                             select car;

                return result.ToList();
            }
        }
    }
}
