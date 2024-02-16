using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp {
    public class Employee {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        protected int Salary { get; private set; }

        public Employee(string firstName, string lastName, int salary) {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        virtual public void Work() {
            Console.WriteLine($"{FirstName}, {LastName} is working");
        }

        public void Pause() {
            Console.WriteLine($"{FirstName}, {LastName} is having a break");
        }
    }
}
