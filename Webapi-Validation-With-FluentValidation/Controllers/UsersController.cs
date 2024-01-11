using Microsoft.AspNetCore.Mvc;
using Webapi_Validation_With_FluentValidation.Models;


namespace Webapi_Validation_With_FluentValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/<UsersController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

     

        // POST api/<UsersController>
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            return Ok();
        }

       
    }
}
