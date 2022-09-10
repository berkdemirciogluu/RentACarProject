using Core.Business;
using Core.WebAPI;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : BaseController<Customer>
    {
        public CustomersController(IBaseService<Customer> _baseService) : base(_baseService)
        {
        }
    }
}
