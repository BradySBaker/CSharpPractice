using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp {
    public class Circle : Shape {
        public float Radius { get; set; }
        public Circle(float radius) {
            Radius = radius;
        }

        public float CalculateArea() {
            return 2 * (float)Math.PI * Radius;
        }

        public float CalculatePerimiter() {
            return (float)Math.PI * (float)Math.Pow(Radius, 2);
        }
    }
}
