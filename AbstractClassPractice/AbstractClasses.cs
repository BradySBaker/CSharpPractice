using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AbstractClassesC {

    public static class Program {
        static public void Main(string[] args) {
            Shape[] shapes = { new Sphere(10), new Cube(4) };

            foreach (Shape shape in shapes) {
                shape.GetInfo();

                Cube? cube = shape as Cube;
                if (cube != null) {
                    Console.WriteLine("The shape is a Cube and the surface area is " + cube.SurfaceArea());
                }
            }
        }
    }
}
