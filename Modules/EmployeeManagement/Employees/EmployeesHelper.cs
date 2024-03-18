using MyRow = MySereneApp.EmployeeManagement.EmployeesRow;

namespace MySereneApp.Modules.EmployeeManagement.Employees;

public static class EmployeesHelper
{
    private static MyRow.RowFields Fld => MyRow.Fields;

    public static int GetCertificateCount(string certificates)
    {
        return certificates.Split(',').Length;
    }

    public static string ValidateFirstName(string firstName, ITextLocalizer localizer)
    {
        if (string.IsNullOrEmpty(firstName))
            throw DataValidation.RequiredError(Fld.FirstName, localizer);

        if (firstName.Length <= 4)
            throw new ValidationError("InvalidFirstName", "FirstName",
                "First name should be at least 4 characters long");

        return firstName;
    }

    public static string ValidateLastName(string lastName, ITextLocalizer localizer)
    {
        if (string.IsNullOrEmpty(lastName))
            throw DataValidation.RequiredError(Fld.LastName, localizer);

        if (lastName.Length <= 4)
            throw new ValidationError("InvalidLastName", "LastName",
                "Last name should be at least 4 characters long");

        return lastName;
    }

    public static DateTime ValidateBirthDate(DateTime birthDate, ITextLocalizer localizer)
    {
        if (birthDate == DateTime.MinValue)
            throw DataValidation.RequiredError(Fld.BirthDate, localizer);

        if (birthDate > DateTime.Now - TimeSpan.FromDays(18 * 365))
            throw new ValidationError("InvalidBirthDate", "BirthDate",
                "Employee should be at least 18 years old");

        if (birthDate.Year < 1900)
            throw new ValidationError("InvalidBirthDate", "BirthDate",
                "Birth year should be after 1900");

        return birthDate;
    }
}