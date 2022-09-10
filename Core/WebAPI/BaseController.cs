using Core.Business;
using Microsoft.AspNetCore.Mvc;

namespace Core.WebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity> : ControllerBase
    {
        IBaseService<TEntity> _baseService;

        public BaseController(IBaseService<TEntity> baseService)
        {
            _baseService = baseService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _baseService.GetAll();
            if(result == null)
                return NotFound(result);
            else if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _baseService.GetById(id);
            if (result == null)
                return NotFound(result);
            else if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("Add")]
        public IActionResult Add([FromBody] TEntity entity)
        {
            var result = _baseService.Add(entity);
            if (result == null)
                return NotFound(result);
            else if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody] TEntity entity)
        {
            var result = _baseService.Update(entity);
            if (result == null)
                return NotFound(result);
            else if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

    }
}
