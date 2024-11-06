using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week09DemoA
{
    internal class MyMath
    {
        public static double Add(double a, double b) { return a + b; }
        public static double Subtract(double a, double b) {return a - b; }
        public static double Multiply(double a, double b) { return a * b; }
        public static double Divide(double a, double b) { 
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return (a / b); }
        public static double PowPow(double a, double b) { return Math.Pow(a, b); }
        public static double Squrtle(double a) 
        {
            if (a < 0)
            {
                throw new ArithmeticException("Cannot take the square root of a negative number");
            }
            return Math.Sqrt(a); 
        }



    }
}
