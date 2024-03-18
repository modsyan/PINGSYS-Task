using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MySereneApp.EmployeeManagement.EmployeesRow>;
using MyRow = MySereneApp.EmployeeManagement.EmployeesRow;

namespace MySereneApp.EmployeeManagement;

public interface IEmployeesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class EmployeesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IEmployeesRetrieveHandler
{
    public EmployeesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}