using Microsoft.AspNetCore.Mvc;
using Permission.Application.Commands.Employee;
using Permission.Application.Queries.Employee;
using Permission.Core.Entities.EmployeeEntity;

namespace Permission.Api.Controllers.MasterDetails
{
    public class MasterDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] TBLEmployeeEntity Employee)
        {
            var result = await sender.Send(new AddCommand(Employee));
            return Ok(result);
        }



        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await sender.Send(new GetData());
            return Ok(result);
        }

        [HttpGet("GetDataByID/{id}")]
        public async Task<IActionResult> GetDataByID(int id)
        {
            var result = await sender.Send(new GetDataByID(id));
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(int id, [FromBody] TBLEmployeeEntity Entity)
        {
            var result = await sender.Send(new UpdateCommand(id, Entity));
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await sender.Send(new DeleteCommand(id));
            return Ok(result);
        }
    }
}
