using PracticeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceC {
    class Program {
        static void Main(string[] args) {
            Employee employee = new Employee("Brady", "Baker", 90000);
            employee.Work();
            employee.Pause();

            Boss boss = new Boss("Bob", "Johansen", 200000, "Motorcycle");
            boss.Lead();
            boss.Work();

            Trainee trainee = new Trainee("Mike", "Briksley", 50000, 3, 4);

            trainee.Work();
            trainee.Learn();
            trainee.Pause();
        }


    }
}
