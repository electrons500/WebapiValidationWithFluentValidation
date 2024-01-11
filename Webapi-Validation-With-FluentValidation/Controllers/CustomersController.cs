using Microsoft.AspNetCore.Mvc;
using Webapi_Validation_With_FluentValidation.Models;

namespace Webapi_Validation_With_FluentValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpPost(Name = "AddCustomer")]
       public IActionResult AddCustomer([FromBody] Customer customer)
       {
            return Ok();
       }
    }
}
