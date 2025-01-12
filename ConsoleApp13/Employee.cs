using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        private string gender;
        public string Gender
        {
            get { return gender; }
            set
            {
                if (value == "M" || value == "F")
                    gender = value;
                else
                    throw new ArgumentException("Gender must be 'M' or 'F'");
            }
        }

        public SecurityLevel SecurityPrivilege { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        public Employee(int id, string name, string gender, SecurityLevel securityPrivilege, decimal salary, DateTime hireDate)
        {
            ID = id;
            Name = name;
            Gender = gender;
            SecurityPrivilege = securityPrivilege;
            Salary = salary;
            HireDate = hireDate;
        }


        public override string ToString()
        {
            return $"ID: {ID}\n" +
                   $"Name: {Name}\n" +
                   $"Gender: {Gender}\n" +
                   $"Security Privilege: {SecurityPrivilege}\n" +
                   $"Salary: {String.Format("{0:C}", Salary)}\n" +
                   $"Hire Date: {HireDate.ToShortDateString()}";
        }
    }
}
