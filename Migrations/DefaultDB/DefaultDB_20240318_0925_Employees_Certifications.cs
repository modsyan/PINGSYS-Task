using FluentMigrator;

namespace MySereneApp.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20240318_0925)]
public class DefaultDB_20240318_0925_Employees_Certifications : Migration
{
    public override void Up()
    {
        Alter.Table("Employees")
            .AddColumn("Certificates").AsString(int.MaxValue).Nullable();

        Delete.Table("EmployeeCertifications");
    }

    public override void Down()
    {
        Delete.Column("Certificates").FromTable("Employees");

        Create.Table("EmployeeCertifications")
            .WithColumn("EmployeeID").AsInt32().NotNullable()
            .ForeignKey("FK_EmployeeCertifications_EmployeeID", "Employees", "EmployeeID")
            .WithColumn("Certification").AsString(100).NotNullable();
    }
}