using Business.Abstract;
using Core.Business;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RentalManager : BaseManager<Rental>, IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal) : base(rentalDal)
        {
            _rentalDal = rentalDal;
        }
    }
}
