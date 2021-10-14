using System;
using System.Collections.Generic;

namespace ORM_Grundlagen.models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public decimal Salary { get; set; }
        public Gender Gender { get; set; }
        private int _Department;
        public char Department { get => (char)_Department; set => _Department = value; }
        
        // NAVIGATIONS-PROPERTY für 1:n-Verknüpfung (1-Seite)
        public List<Address> Addresses { get; set; }

        public Person():this(0,"","",DateTime.MinValue,0.0m,new Gender(), '-'){}

        public Person(int id, string fName, string lName, DateTime bDay, decimal salary, Gender sex, char department)
        {
            Id = id;
            FirstName = fName;
            LastName = lName;
            Birthdate = bDay;
            Salary = salary;
            this.Gender = sex;
            _Department = department;
        }

        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName} {Birthdate.ToLongDateString()} {Gender} {Salary} {Department}";
        }
    }
}