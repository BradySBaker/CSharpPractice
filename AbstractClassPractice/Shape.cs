using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesC {
    public abstract class Shape {
        public string Name { get; set; } = "Default name";
        public virtual void GetInfo() {
            Console.Write($"\nThis is a {Name}");
        }

        public abstract double Volume();
    }

    public class Cube : Shape {
        public float Length { get; set; }
        public Cube(float length) {
            Name = "Cube";
            Length = length;
        }

        public override double Volume() {
            return Math.Pow(Length, 3);
        }

        public override void GetInfo() {
            base.GetInfo();
            Console.WriteLine($", the Cube has a length of {Length}");
        }

        public double SurfaceArea() {
            return Math.Pow(Length, 2);
        }
    }

    public class Sphere : Shape {
        public float Radius {  get; set; }
        public Sphere(float radius) {
           Name = "Sphere";
           Radius = radius;
        }

        public override double Volume() {
            return (4/3) * Math.PI * Math.Pow(Radius, 3);
        }

        public override void GetInfo() {
            base.GetInfo();
            Console.WriteLine($", the Sphere has a radius of {Radius}");
        }
    }
}
