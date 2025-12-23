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

       
    }
}
