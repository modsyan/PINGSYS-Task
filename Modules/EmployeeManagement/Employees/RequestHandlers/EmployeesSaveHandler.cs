using MySereneApp.Modules.EmployeeManagement.Employees;
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MySereneApp.EmployeeManagement.EmployeesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MySereneApp.EmployeeManagement.EmployeesRow;

namespace MySereneApp.EmployeeManagement;

public interface IEmployeesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse>
{
}

public class EmployeesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IEmployeesSaveHandler
{
    private static MyRow.RowFields Fld => MyRow.Fields;

    public EmployeesSaveHandler(IRequestContext context)
        : base(context)
    {
    }

    protected override void GetEditableFields(HashSet<Field> editable)
    {
        base.GetEditableFields(editable);
    }


    protected override void ValidateRequest()
    {
        base.ValidateRequest();

        if (IsUpdate)
        {
            if (Old.FirstName != Row.FirstName)
            {
                Row.FirstName = EmployeesHelper.ValidateFirstName(Row.FirstName, Localizer);
            }

            if (Old.LastName != Row.LastName)
            {
                Row.LastName = EmployeesHelper.ValidateLastName(Row.LastName, Localizer);
            }

            if ((Old.BirthDate != Row.BirthDate) && Row.BirthDate.HasValue)
            {
                Row.BirthDate = EmployeesHelper.ValidateBirthDate(Row.BirthDate.Value, Localizer);
            }
        }

        if (IsCreate)
        {
            Row.FirstName = EmployeesHelper.ValidateFirstName(Row.FirstName, Localizer);

            Row.LastName = EmployeesHelper.ValidateLastName(Row.LastName, Localizer);

            if(Row.BirthDate.HasValue)
            {
                Row.BirthDate = EmployeesHelper.ValidateBirthDate(Row.BirthDate.Value, Localizer);
            }
        }
    }

    protected override void SetInternalFields()
    {
        base.SetInternalFields();

        if (IsCreate)
        {
        }

        if (IsUpdate)
        {
        }
    }

    protected override void AfterSave()
    {
        base.AfterSave();

        Cache.InvalidateOnCommit(UnitOfWork, Fld);
    }
}