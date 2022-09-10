using Core.Business;
using Core.WebAPI;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : BaseController<Color>
    {
        public ColorsController(IBaseService<Color> _baseService) : base(_baseService)
        {
        }
    }
}
