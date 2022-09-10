using Business.Abstract;
using Core.Business;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : BaseManager<User> , IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal) : base(userDal)
        {
            _userDal = userDal;
        }
    }
}
