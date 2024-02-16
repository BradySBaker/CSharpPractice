using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp {
    public class Trainee : Employee {
        public int WorkingHours { get; protected set; }
        public int SchoolHours { get; protected set; }
        public Trainee(string firstName, string lastName, int salary, int workingHours, int schoolHours) : base(firstName, lastName, salary) {
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }

        public void Learn() {
            Console.WriteLine($"{FirstName}, {LastName} is learning for {SchoolHours} hours");
        }

        override public void Work() {
            Console.WriteLine($"{FirstName}, {LastName} is working for {WorkingHours} hours");
        }
    }
}
