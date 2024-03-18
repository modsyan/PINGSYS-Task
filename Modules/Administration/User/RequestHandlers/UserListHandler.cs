using MyRow = MySereneApp.Administration.UserRow;
using MyRequest = MySereneApp.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<MySereneApp.Administration.UserRow>;

namespace MySereneApp.Administration;

public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}