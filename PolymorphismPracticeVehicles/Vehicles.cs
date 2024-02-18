using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp {
    public class Vehicle {
        public int HP { get; protected set; }
        public string Color { get; protected set; }
        public string Type { get; protected set; }
        protected VehicleIDInfo vehicleIDInfo = new VehicleIDInfo();

        public void SetVehicleIDInfo(int idNum, string owner) {
            vehicleIDInfo.IDNum = idNum;
            vehicleIDInfo.Owner = owner;
        }

        public void ShowVehicleIDInfo() {
            vehicleIDInfo.ShowInfo();
        }


        public Vehicle(int hp, string color, string type) {
            HP = hp;
            Color = color;
            Type = type;
        }

        public void ShowDetails() {
            Console.WriteLine($"Horse Power: {HP}, Color: {Color}");
        }

        public virtual void Repair() {
            Console.WriteLine (Type + "  was repaired!");
        }
    }




    public class VehicleIDInfo() {
        public int IDNum { get; set; } = 0;
        public string Owner { get; set; } = "No owner";

        public void ShowInfo() {
            Console.WriteLine($"Vehicle of ID {IDNum} is owned by {Owner}");
        }
    }





    public class BMW : Vehicle {
        public string Model {  get; private set; }
        private string _brand = "BMW";
        public BMW(int hp, string color, string model) : base (hp, color, "Car") {
            Model = model;
        }

        public sealed override void Repair() {
            Console.WriteLine(_brand + " was reparied!");
        }


    }




    public class Audi : Vehicle {
        public string Model { get; private set; }
        private string _brand = "Audi";
        public Audi(int hp, string color, string model) : base(hp, color, "Car") {
            Model = model;
        }

        public sealed override void Repair() {
            Console.WriteLine(_brand + " was reparied!");
        }

        public new void ShowDetails() {
            base.ShowDetails();
            Console.WriteLine($"Brand: {_brand}, Model: {Model}");
        }
    }
}
