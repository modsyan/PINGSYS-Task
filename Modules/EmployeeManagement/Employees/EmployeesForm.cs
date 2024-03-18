using Serenity.ComponentModel;
using System;
using MySereneApp.Modules.EmployeeManagement.Employees;

namespace MySereneApp.EmployeeManagement.Forms;

[FormScript("EmployeeManagement.Employees")]
// [BasedOnRow(typeof(EmployeesRow), CheckNames = true)]
public class EmployeesForm
{
    [DisplayName("Forms.Employee.FirstName")]
    public string FirstName { get; set; }

    [DisplayName("Forms.Employee.LastName")]
    public string LastName { get; set; }

    [DisplayName("Forms.Employee.Gender")]
    public EmployeeGender Gender { get; set; }

    [MultipleFileUploadEditor]
    public List<string> Certificates { get; set; }

    [DisplayName("Forms.Employee.BirthDate")]
    public DateTime BirthDate { get; set; }

    public bool IsActive { get; set; }
}