using Business.Abstract;
using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : BaseManager<Color>, IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal) : base(colorDal)
        {
            _colorDal = colorDal;
        }
    }
}
