namespace OOP_Fundamentals_Library
{
    public class Employee : Person, IPayable
    {
        private decimal _salary;
        public string Position { get; set; }
        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value <= null)
                {
                    throw new ArgumentNullException("Что-то пошло не так, упс...");
                }
                _salary = value;
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Сотрудник: {Name}, {Age} лет, Позиция: {Position}");
        }

        public virtual void ProcessSalary()
        {
            Console.WriteLine($"Обработка заработной платы сотрудника {Name}: {Salary}");
        }


        public virtual decimal CalculateBonus(int years, bool hasCertification)
        {
            decimal bonus = Salary * 0.1m;
            if (years > 5) bonus += 500;
            if (hasCertification) bonus += 300;
            return bonus;
        }
    }
}
