using Serenity.Navigation;
using EmployeeManagement = MySereneApp.EmployeeManagement.Pages;

[assembly: NavigationMenu(10000, "Employee Management", icon: "fa-building-o")]
[assembly: NavigationLink(10100, "Employee Management/Employees", typeof(EmployeeManagement.EmployeesPage), icon: "fa-briefcase")]