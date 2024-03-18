import { EmployeesColumns, EmployeesRow, EmployeesService } from '@/ServerTypes/EmployeeManagement';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { EmployeesDialog } from './EmployeesDialog';

@Decorators.registerClass('MySereneApp.EmployeeManagement.EmployeesGrid')
export class EmployeesGrid extends EntityGrid<EmployeesRow, any> {
    protected getColumnsKey() { return EmployeesColumns.columnsKey; }
    protected getDialogType() { return EmployeesDialog; }
    protected getRowDefinition() { return EmployeesRow; }
    protected getService() { return EmployeesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}