using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_C_Sharp_LINQ
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age {  get; set; }
        public string Institution { get; set; }

        public Student(string name, string surname, int age, string institution)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Institution = institution;
        }

        public override string ToString()
        {
            return $"Name: {Name}. Surname: {Surname}. Age: {Age}. Institution: {Institution}";
        }


    }
}
