using Core.Business;
using Core.WebAPI;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : BaseController<Rental>
    {
        public RentalsController(IBaseService<Rental> _baseService) : base(_baseService)
        {
        }
    }
}
