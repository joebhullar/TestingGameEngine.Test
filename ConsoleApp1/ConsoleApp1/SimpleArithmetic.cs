using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class SimpleArithmetic
    {
        public List<string> ArithmeticFunctions = new List<string>() {"Addition", "Subtraction", "Multiplication", "Division"}; 
        public double AddTwoDoubles(string d1, string d2)
        {
            return Convert.ToDouble(d1) + Convert.ToDouble(d2);
        }
        public double SubtractTwoDoubles(string d1, string d2)
        {
            return Convert.ToDouble(d2) - Convert.ToDouble(d1);
        }
        public double MultiplyTwoDoubles(string d1, string d2)
        {
            return Convert.ToDouble(d1)*Convert.ToDouble(d2);
        }
        public double DivideTwoDoubles(string d1, string d2)
        {
            return Convert.ToDouble(d2) / Convert.ToDouble(d1);
        }

    }
}
