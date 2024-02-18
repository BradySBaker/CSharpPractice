using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PracticeApp {

    public static class Polymorphism {
        static public void Main(string[] args) {
            List<Vehicle> vehicleList = new List<Vehicle> {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3")

            };

            foreach (Vehicle vehicle in vehicleList) {
                vehicle.Repair();
                vehicle.ShowDetails();
            }

            Audi audi = new Audi(200, "blue", "A1");
            audi.ShowDetails();

            audi.SetVehicleIDInfo(1235, "John Bob");
            audi.ShowVehicleIDInfo();
        }
    }
}
