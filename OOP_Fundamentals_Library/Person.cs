using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Fundamentals_Library
{
    public abstract class Person
    {
        private int _age;
        public string Name { get; set; }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Возраст не может быть меньше 0.");
                }
                _age = value;
            }
        }

        public abstract void PrintInfo();
    }
}
