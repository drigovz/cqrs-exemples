using CustomersCqrs.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CustomersCqrs.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Customer request)
        {
            var customer = new Customer(request.UserName, request.FirstName, request.LastName, request.Email, request.Cpf, request.Rg, request.Phone);

            return Ok(customer);
        }
    }
}
