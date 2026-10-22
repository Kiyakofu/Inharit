using Inharit;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Inharit
{
    internal class Human
    {
        private int _id;
        protected string _firstname;
        protected string _lastname;
        DateTime _birthDate;
        public Human(string firstname, string lastname, DateTime birthDate)
        {
            _id = 0;
            _firstname = firstname;
            _lastname = lastname;
            _birthDate = birthDate;
        }
        public void Show()
        {
            WriteLine($"Name {_firstname},\n Lastname {_lastname},\n birthDate {_birthDate}");
        }
    }

    internal sealed class Employee : Human
    {
        double _salary;

        public Employee(string fname, string lname, double salary, DateTime date) : base(fname, lname, date) 
        {
            _firstname = fname;
            _lastname = lname;
            _salary = salary;
        }

        public void Print()
        {
            WriteLine($"Name: {_firstname}\nLastname: {_lastname}\nSalary: {_salary}");
        }
    }
}
