using FluentMigrator;

namespace MySereneApp.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20240318_0620)]
public class DefaultDB_20240318_0620_Employees : AutoReversingMigration
{
    public override void Up()
    {
        this.CreateTableWithId32("Employees", "EmployeeID", s => s
            .WithColumn("FirstName").AsString(20).NotNullable()
            .WithColumn("LastName").AsString(20).NotNullable()
            .WithColumn("Gender").AsInt16().WithDefaultValue(0).NotNullable() // 0 => undefined
            .WithColumn("BirthDate").AsDateTime().Nullable()
            .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

        Create.Table("EmployeeCertifications")
            .WithColumn("EmployeeID").AsInt32().NotNullable()
            .ForeignKey("FK_EmployeeCertifications_EmployeeID", "Employees", "EmployeeID")
            .WithColumn("Certification").AsString(100).NotNullable();
    }
}