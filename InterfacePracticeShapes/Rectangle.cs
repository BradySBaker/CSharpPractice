using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp {
    public class Rectangle : Shape {
        public float Width { get; set; }
        public float Height { get; set; }

        public Rectangle(float width, float height) {
            Width = width;
            Height = height;
        }
        public float CalculateArea() {
            return Width * Height;
        }

        public float CalculatePerimiter() {
            return (Height * 2) + (Width * 2);
        }
    }
}
