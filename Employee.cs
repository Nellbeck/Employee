using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public float Salary { get; set; }

        public Employee(int id, string name, string gender, float salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }
        public void GetInfo() 
        {
            Console.WriteLine($"{Id} - {Name} - {Gender} - {Salary}");
        }
    }
}
