using ConsoleCalculatorB2A.Requests;
using System;

namespace ConsoleCalculatorB2A.Operations
{
    internal class Subtraction
    {
        public void Subtract()
        {
            Console.WriteLine("SUBTRACTION");
            var results = GetUserValues.InputValues();
            int x = results.xValue;
            int y = results.yValue;
            int total = x - y;
            Console.WriteLine("The subtracted numbers equal: " + total);
        }
    }
}
