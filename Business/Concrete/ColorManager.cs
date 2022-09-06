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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return _colorDal.GetAll();
        }

        public IDataResult<Color> GetById(int id)
        {
            return _colorDal.Get(c => c.Id == id);
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}
