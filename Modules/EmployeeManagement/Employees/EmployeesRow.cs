using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using NUglify.Helpers;

namespace MySereneApp.EmployeeManagement;

[ConnectionKey("Default"), Module("EmployeeManagement"), TableName("Employees")]
[DisplayName("Employees"), InstanceName("Employees")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class EmployeesRow : Row<EmployeesRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Employee Id"), Column("EmployeeID"), Identity, IdProperty]
    public int? EmployeeId
    {
        get => fields.EmployeeId[this];
        set => fields.EmployeeId[this] = value;
    }

    [DisplayName("First Name"), Size(20), NotNull, QuickSearch, NameProperty]
    public string FirstName
    {
        get => fields.FirstName[this];
        set => fields.FirstName[this] = value;
    }

    [DisplayName("Last Name"), Size(20), NotNull]
    public string LastName
    {
        get => fields.LastName[this];
        set => fields.LastName[this] = value;
    }

    [DisplayName("Gender"), NotNull]
    public short? Gender
    {
        get => fields.Gender[this];
        set => fields.Gender[this] = value;
    }

    [DisplayName("Birth Date")]
    public DateTime? BirthDate
    {
        get => fields.BirthDate[this];
        set => fields.BirthDate[this] = value;
    }

    [DisplayName("Is Active"), NotNull]
    public short? IsActive
    {
        get => fields.IsActive[this];
        set => fields.IsActive[this] = value;
    }

    [DisplayName("Employee Certificates")]
    [MultipleFileUploadEditor(FilenameFormat = "EmployeeCertificates/~", CopyToHistory = true)]
    public string Certificates
    {
        get => fields.Certificates[this];
        set => fields.Certificates[this] = value;
    }

    [DisplayName("Certificates Count"), NotMapped, Insertable(false), Updatable(false)]
    // count the number of certificates from Certificates field
    public int? CertificatesCount
    {
        get => fields.CertificatesCount[this];
        set => fields.CertificatesCount[this] = value;
    }


    public class RowFields : RowFieldsBase
    {
        public Int32Field EmployeeId;
        public StringField FirstName;
        public StringField LastName;
        public Int16Field Gender;
        public DateTimeField BirthDate;
        public Int16Field IsActive;
        public StringField Certificates;
        public Int32Field CertificatesCount;
    }
}