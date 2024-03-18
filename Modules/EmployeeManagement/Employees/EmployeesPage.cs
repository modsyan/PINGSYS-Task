using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MySereneApp.EmployeeManagement.Pages;

[PageAuthorize(typeof(EmployeesRow))]
public class EmployeesPage : Controller
{
    [Route("EmployeeManagement/Employees")]
    public ActionResult Index()
    {
        return this.GridPage("@/EmployeeManagement/Employees/EmployeesPage",
            EmployeesRow.Fields.PageTitle());
    }
}