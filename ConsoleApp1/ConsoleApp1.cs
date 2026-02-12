using System;
using System.Collections.Generic;
using System.Text;
using OOP_Fundamentals_Library;

namespace ConsoleApp1
{
    public class ConsoleApp1
    {
        static void Main(string[] args)
        {
            var customer = new Customer
            {
                Name = "John",
                Age = 30
            };

            var employee = new Employee
            {
                Name = "Alice",
                Age = 25,
                Salary = 50000,
                Position = "Developer"
            };

            var manager = new Manager
            {
                Name = "Bob",
                Age = 40,
                Salary = 80000,
                Department = "IT"
            };

            manager.AddTeamMember(employee);

            employee.Salary = 55000;

            customer.PrintInfo();
            employee.PrintInfo();
            manager.PrintInfo();

            var payroll = new PayrollSystem();
            payroll.ProcessSalary(employee);
            payroll.ProcessSalary(manager);

            ReportService.GenerateEmployeeReport(employee);
            ReportService.GenerateEmployeeReport(manager);
        }
    }
}
