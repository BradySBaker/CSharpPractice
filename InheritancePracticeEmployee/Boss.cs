using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp {
    public class Boss: Employee {
        public string CompanyCar { get; private set; }
        public Boss(string firstName, string lastName, int salary, string companyCar): base(firstName, lastName, salary) { 
            CompanyCar = companyCar;
        }

        public void Lead() {
            Console.WriteLine($"Name: \"{FirstName}, {LastName}\", Salary: {Salary}, Company Car: {CompanyCar}");
        }
    }
}
