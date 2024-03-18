import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { EmployeeGender } from "../Modules/EmployeeManagement.Employees.EmployeeGender";
import { EmployeesRow } from "./EmployeesRow";

export interface EmployeesColumns {
    EmployeeId: Column<EmployeesRow>;
    FirstName: Column<EmployeesRow>;
    LastName: Column<EmployeesRow>;
    CertificatesCount: Column<EmployeesRow>;
    Gender: Column<EmployeesRow>;
    BirthDate: Column<EmployeesRow>;
}

export class EmployeesColumns extends ColumnsBase<EmployeesRow> {
    static readonly columnsKey = 'EmployeeManagement.Employees';
    static readonly Fields = fieldsProxy<EmployeesColumns>();
}

[EmployeeGender]; // referenced types