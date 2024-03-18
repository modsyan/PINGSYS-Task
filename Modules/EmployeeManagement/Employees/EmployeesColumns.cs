using Serenity.ComponentModel;
using System;
using System.ComponentModel;
using MySereneApp.Modules.EmployeeManagement.Employees;

namespace MySereneApp.EmployeeManagement.Columns;

[ColumnsScript("EmployeeManagement.Employees")]
[BasedOnRow(typeof(EmployeesRow), CheckNames = true)]
public class EmployeesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId")]
    public int EmployeeId { get; set; }

    [EditLink, Width(150)] public string FirstName { get; set; }
    [EditLink, Width(150)] public string LastName { get; set; }

    [Width(200)]
    [DisplayName("Forms.Employee.CertificatesCount")]
    public int CertificatesCount { get; set; }

    [Width(100)] public EmployeeGender Gender { get; set; }

    [Width(150), DisplayName("Forms.Employee.BirthDate")]
    public DateTime BirthDate { get; set; }
}