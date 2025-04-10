using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsolprojekt
{
    public class Calculator : ICalculator
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
        public double Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException("Division by zero not allowed.");
            return (double)a / b;
        }
        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }
        public double SquareRoot(double a)
        {
            if (a < 0) throw new ArgumentException("Cannot calculate square root of a negative number.");
            return Math.Sqrt(a);
        }

    }
}
