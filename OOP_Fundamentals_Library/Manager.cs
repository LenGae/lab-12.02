using System.Xml.Linq;

namespace OOP_Fundamentals_Library
{
    public class Manager : Employee
    {
        public string Department { get; set; }
        private List<Employee> _team = new();
        public IReadOnlyList<Employee> Team => _team.AsReadOnly();
        public void AddTeamMember(Employee emp) => _team.Add(emp);


        public override void PrintInfo()
        {
            Console.WriteLine($"Менеджер: {Name}, {Age} лет, Отделение: {Department}, Размер команды: {Team.Count}");
        }

        public override void ProcessSalary()
        {
            Console.WriteLine($"Заработная плата менеджера по обработке данных для {Name} (Отдел: {Department}): {Salary}");
        }

        public override decimal CalculateBonus(int years, bool hasCertification)
        {
            return base.CalculateBonus(years, hasCertification) + (Salary * 0.1m);
        }
    }
}
