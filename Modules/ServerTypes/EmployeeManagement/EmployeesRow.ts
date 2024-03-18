import { fieldsProxy } from "@serenity-is/corelib";

export interface EmployeesRow {
    EmployeeId?: number;
    FirstName?: string;
    LastName?: string;
    Gender?: number;
    BirthDate?: string;
    IsActive?: number;
    Certificates?: string;
    CertificatesCount?: number;
}

export abstract class EmployeesRow {
    static readonly idProperty = 'EmployeeId';
    static readonly nameProperty = 'FirstName';
    static readonly localTextPrefix = 'EmployeeManagement.Employees';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<EmployeesRow>();
}