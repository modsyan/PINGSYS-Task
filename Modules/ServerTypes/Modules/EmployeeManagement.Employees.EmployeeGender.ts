import { Decorators } from "@serenity-is/corelib";

export enum EmployeeGender {
    Male = 1,
    Female = 2
}
Decorators.registerEnumType(EmployeeGender, 'MySereneApp.Modules.EmployeeManagement.Employees.EmployeeGender');