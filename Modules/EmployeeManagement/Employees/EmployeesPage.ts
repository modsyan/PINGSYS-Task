import { initFullHeightGridPage } from '@serenity-is/corelib';
import { EmployeesGrid } from './EmployeesGrid';

export default function pageInit() {
    initFullHeightGridPage(new EmployeesGrid($('#GridDiv')).element);
}