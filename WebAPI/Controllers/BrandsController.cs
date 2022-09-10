using Core.Business;
using Core.WebAPI;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController<Brand>
    {
        public BrandsController(IBaseService<Brand> _baseService) : base(_baseService)
        {
        }
    }
}
