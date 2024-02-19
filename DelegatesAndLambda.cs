using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp {
    public delegate float OperationDelegate(float num1, float num2);
    public class Delegates {
        
        public static float Add(float num1, float num2) {
            return num1 + num2;
        }

        public static float Subtract(float num1, float num2) {
            return num1 - num2;
        }

        public static float Multiply(float num1, float num2) {
            return num1 * num2;
        }

        public static float Divide(float num1, float num2) {
            return num1 / num2;
        }

        public static float ApplyOperation(float num1, float num2, OperationDelegate operation) {
            return operation(num1, num2);
        }
    }
}
