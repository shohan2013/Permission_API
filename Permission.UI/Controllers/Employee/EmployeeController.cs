using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Permission.Application.Commands.Employee;
using Permission.Core.Entities.EmployeeEntity;

namespace Permission.Api.Controllers.Employee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(ISender sender) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] TBLEmployeeEntity Employee)
        {
            var result = await sender.Send(new AddCommand(Employee));
            return Ok(result);
        }
    }
}
