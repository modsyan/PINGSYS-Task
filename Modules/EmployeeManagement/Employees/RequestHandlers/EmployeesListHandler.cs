using Newtonsoft.Json.Linq;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MySereneApp.EmployeeManagement.EmployeesRow>;
using MyRow = MySereneApp.EmployeeManagement.EmployeesRow;

namespace MySereneApp.EmployeeManagement;

public interface IEmployeesListHandler : IListHandler<MyRow, MyRequest, MyResponse>
{
}

public class EmployeesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IEmployeesListHandler
{
    public EmployeesListHandler(IRequestContext context)
        : base(context)
    {
    }

    protected override MyRow ProcessEntity(MyRow row)
    {
        if (row.Certificates != null)
        {
            row.CertificatesCount = JArray.Parse(row.Certificates).Count;
        }

        return base.ProcessEntity(row);
    }
}