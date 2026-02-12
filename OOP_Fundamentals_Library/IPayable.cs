using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Fundamentals_Library
{
    public interface IPayable
    {
        decimal Salary { get; set; }
        void ProcessSalary();
        decimal CalculateBonus(int years, bool hasCertification);
    }
}