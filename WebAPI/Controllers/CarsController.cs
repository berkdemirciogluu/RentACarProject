using Core.Business;
using Core.WebAPI;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : BaseController<Car>
    {
        public CarsController(IBaseService<Car> _baseService) : base(_baseService)
        {
        }
    }
}
