import { StringEditor, EnumEditor, MultipleImageUploadEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EmployeeGender } from "../Modules/EmployeeManagement.Employees.EmployeeGender";

export interface EmployeesForm {
    FirstName: StringEditor;
    LastName: StringEditor;
    Gender: EnumEditor;
    Certificates: MultipleImageUploadEditor;
    BirthDate: DateEditor;
    IsActive: BooleanEditor;
}

export class EmployeesForm extends PrefixedContext {
    static readonly formKey = 'EmployeeManagement.Employees';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!EmployeesForm.init)  {
            EmployeesForm.init = true;

            var w0 = StringEditor;
            var w1 = EnumEditor;
            var w2 = MultipleImageUploadEditor;
            var w3 = DateEditor;
            var w4 = BooleanEditor;

            initFormType(EmployeesForm, [
                'FirstName', w0,
                'LastName', w0,
                'Gender', w1,
                'Certificates', w2,
                'BirthDate', w3,
                'IsActive', w4
            ]);
        }
    }
}

[EmployeeGender]; // referenced types