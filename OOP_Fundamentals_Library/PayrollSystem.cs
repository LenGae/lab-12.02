namespace OOP_Fundamentals_Library
{
    public class PayrollSystem
    {
        public void ProcessSalary(IPayable payable)
        {
            payable.ProcessSalary();
            if (payable is Manager) payable.Salary += 2000;
            else payable.Salary += 1000;
        }

        public decimal CalculateBonus(IPayable payable, int years, bool hasCertification)
        {
            return payable.CalculateBonus(years, hasCertification);
        }

    }
}
