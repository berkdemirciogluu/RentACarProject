using Business.Abstract;
using Core.Business;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : BaseManager<Customer>, ICustomerService
    {

        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal) : base(customerDal)
        {
            _customerDal = customerDal;
        }
    }
}
