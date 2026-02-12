namespace OOP_Fundamentals_Library
{
    public static class ReportService
    {
        public static void GenerateEmployeeReport(Employee emp)
        {
            Console.WriteLine(emp.GetType().Name);
            emp.PrintInfo();
            Console.WriteLine(emp.Salary);
        }
    }
}
